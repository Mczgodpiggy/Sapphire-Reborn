using ns1;
using System;
using System.Runtime.InteropServices;

namespace ns0
{
	internal sealed class Class2
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr intptr_0, int int_0);

		[DllImport("user32.dll")]
		public static extern ushort GetAsyncKeyState(int int_0);

		[DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
		public static extern short GetAsyncKeyState_1(ushort ushort_0);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string string_0, string string_1);

		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(int int_0, long long_0, byte[] byte_0, int int_1, ref int int_2);

		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern GEnum0 NtReadVirtualMemory(IntPtr intptr_0, long long_0, byte[] byte_0, uint uint_0, uint uint_1);

		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern GEnum0 NtWriteVirtualMemory(IntPtr intptr_0, long long_0, byte[] byte_0, uint uint_0, uint uint_1);

		[DllImport("kernel32.dll")]
		public static extern bool VirtualQueryEx(IntPtr intptr_0, long long_0, out GStruct1 gstruct1_0, uint uint_0);

		[DllImport("user32.dll")]
		public static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);
	}
}
