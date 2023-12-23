using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class Memory
{
    protected struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;

        public IntPtr AllocationBase;

        public uint AllocationProtect;

        public uint RegionSize;

        public uint State;

        public uint Protect;

        public uint Type;
    }

    private enum AllocationProtectEnum : uint
    {
        PAGE_EXECUTE = 16u,
        PAGE_EXECUTE_READ = 32u,
        PAGE_EXECUTE_READWRITE = 64u,
        PAGE_EXECUTE_WRITECOPY = 128u,
        PAGE_NOACCESS = 1u,
        PAGE_READONLY = 2u,
        PAGE_READWRITE = 4u,
        PAGE_WRITECOPY = 8u,
        PAGE_GUARD = 256u,
        PAGE_NOCACHE = 512u,
        PAGE_WRITECOMBINE = 1024u
    }

    private enum StateEnum : uint
    {
        MEM_COMMIT = 4096u,
        MEM_FREE = 65536u,
        MEM_RESERVE = 8192u
    }

    private enum TypeEnum : uint
    {
        MEM_IMAGE = 16777216u,
        MEM_MAPPED = 262144u,
        MEM_PRIVATE = 131072u
    }

    private uint PROCESS_ALL_ACCESS = 127231u;

    public ulong InicioScan;

    public ulong FimScan = 4294967295uL;

    private bool StopTheFirst;

    private Process Attacked;

    private List<IntPtr> AddressList = new List<IntPtr>();

    private List<MEMORY_BASIC_INFORMATION> MappedMemory { get; set; }

    [DllImport("kernel32.dll")]
    public static extern uint GetLastError();

    [DllImport("kernel32.dll")]
    public static extern int OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    protected static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    protected static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

    public static string GetSystemMessage(uint errorCode)
    {
        return new Win32Exception((int)errorCode).Message;
    }

    protected void MemInfo(IntPtr pHandle)
    {
        IntPtr intPtr = default(IntPtr);
        intPtr = (IntPtr)(long)InicioScan;
        while ((ulong)(long)intPtr <= FimScan)
        {
            MEMORY_BASIC_INFORMATION lpBuffer = default(MEMORY_BASIC_INFORMATION);
            if (VirtualQueryEx(pHandle, intPtr, out lpBuffer, Marshal.SizeOf((object)lpBuffer)) != 0)
            {
                if ((lpBuffer.State & 0x1000u) != 0 && (lpBuffer.Protect & 0x100) != 256)
                {
                    MappedMemory.Add(lpBuffer);
                }

                intPtr = new IntPtr(lpBuffer.BaseAddress.ToInt32() + (int)lpBuffer.RegionSize);
                continue;
            }

            break;
        }
    }

    protected IntPtr ScanInBuff(IntPtr Address, byte[] Buff, string[] StrMask)
    {
        int num = Buff.Length;
        int num2 = StrMask.Length;
        int num3 = num2 - 1;
        byte[] array = new byte[num2];
        for (int i = 0; i < num2; i++)
        {
            if (StrMask[i] == "??")
            {
                array[i] = 0;
            }
            else
            {
                array[i] = Convert.ToByte(StrMask[i], 16);
            }
        }

        for (int j = 0; j <= num - num2 - 1; j++)
        {
            if (Buff[j] != array[0])
            {
                continue;
            }

            int num4 = num3;
            while (StrMask[num4] == "??" || Buff[j + num4] == array[num4])
            {
                if (num4 == 0)
                {
                    if (StopTheFirst)
                    {
                        return new IntPtr(j);
                    }

                    if ((ulong)(Address.ToInt32() + j) >= InicioScan && (ulong)(Address.ToInt32() + j) <= FimScan)
                    {
                        AddressList.Add((IntPtr)(Address.ToInt32() + j));
                    }

                    break;
                }

                num4--;
            }
        }

        return IntPtr.Zero;
    }

    public Process GetPID(string ProcessName)
    {
        try
        {
            return Process.GetProcessesByName(ProcessName)[0];
        }
        catch
        {
        }

        return null;
    }

    public IntPtr[] ScanArray(Process P, string ArrayString)
    {
        EnablePrivileges.GoDebugPriv();
        IntPtr[] result = new IntPtr[1];
        Logs.DeleteLog();
        if (P == null)
        {
            return new IntPtr[1];
        }

        Attacked = Process.GetProcessById(P.Id);
        string[] array = ArrayString.Split(" "[0]);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == "?")
            {
                array[i] = "??";
            }
        }

        MappedMemory = new List<MEMORY_BASIC_INFORMATION>();
        MemInfo(Attacked.Handle);
        for (int j = 0; j < MappedMemory.Count; j++)
        {
            byte[] array2 = new byte[MappedMemory[j].RegionSize];
            ReadProcessMemory(Attacked.Handle, MappedMemory[j].BaseAddress, array2, MappedMemory[j].RegionSize, 0);
            IntPtr intPtr = IntPtr.Zero;
            if (array2.Length != 0)
            {
                intPtr = ScanInBuff(MappedMemory[j].BaseAddress, array2, array);
            }

            if (StopTheFirst && intPtr != IntPtr.Zero)
            {
                result = new IntPtr[0];
                result[0] = (IntPtr)(MappedMemory[j].BaseAddress.ToInt32() + intPtr.ToInt32());
                return result;
            }
        }

        if (!StopTheFirst && AddressList.Count > 0)
        {
            result = new IntPtr[AddressList.Count];
            for (int k = 0; k < AddressList.Count; k++)
            {
                result[k] = AddressList[k];
            }

            AddressList.Clear();
            return result;
        }

        return result;
    }

    public bool WriteArray(IntPtr address, string ArrayString)
    {
        if (Attacked == null)
        {
            return false;
        }

        string[] array = ArrayString.Split(" "[0]);
        byte[] array2 = new byte[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == "?" || array[i] == "??")
            {
                array2[i] = 0;
            }
            else
            {
                array2[i] = Convert.ToByte(array[i], 8);
            }
        }

        return WriteProcessMemory((int)Attacked.Handle, address.ToInt32(), array2, array2.Length, 0);
    }

    public Process GetChrome()
    {
        Process[] processesByName = Process.GetProcessesByName("chrome");
        foreach (Process process in processesByName)
        {
            try
            {
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.FileName.Contains("pepflashplayer.dll"))
                    {
                        return process;
                    }
                }
            }
            catch
            {
            }
        }

        return null;
    }
}