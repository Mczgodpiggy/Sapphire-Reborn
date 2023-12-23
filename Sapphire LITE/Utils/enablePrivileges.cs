using System;
using System.Runtime.InteropServices;

public class EnablePrivileges
{
    public struct LUID
    {
        public uint LowPart;

        public int HighPart;
    }

    public struct TOKEN_PRIVILEGES
    {
        public uint PrivilegeCount;

        public LUID Luid;

        public uint Attributes;
    }

    public struct LUID_AND_ATTRIBUTES
    {
        public LUID Luid;

        public uint Attributes;
    }

    private static uint STANDARD_RIGHTS_REQUIRED = 983040u;

    private static uint STANDARD_RIGHTS_READ = 131072u;

    private static uint TOKEN_ASSIGN_PRIMARY = 1u;

    private static uint TOKEN_DUPLICATE = 2u;

    private static uint TOKEN_IMPERSONATE = 4u;

    private static uint TOKEN_QUERY = 8u;

    private static uint TOKEN_QUERY_SOURCE = 16u;

    private static uint TOKEN_ADJUST_PRIVILEGES = 32u;

    private static uint TOKEN_ADJUST_GROUPS = 64u;

    private static uint TOKEN_ADJUST_DEFAULT = 128u;

    private static uint TOKEN_ADJUST_SESSIONID = 256u;

    private static uint TOKEN_READ = STANDARD_RIGHTS_READ | TOKEN_QUERY;

    private static uint TOKEN_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | TOKEN_ASSIGN_PRIMARY | TOKEN_DUPLICATE | TOKEN_IMPERSONATE | TOKEN_QUERY | TOKEN_QUERY_SOURCE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT | TOKEN_ADJUST_SESSIONID;

    public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

    public const string SE_AUDIT_NAME = "SeAuditPrivilege";

    public const string SE_BACKUP_NAME = "SeBackupPrivilege";

    public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

    public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

    public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

    public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

    public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

    public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

    public const string SE_DEBUG_NAME = "SeDebugPrivilege";

    public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

    public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

    public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

    public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

    public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

    public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

    public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

    public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

    public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

    public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

    public const string SE_RELABEL_NAME = "SeRelabelPrivilege";

    public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

    public const string SE_RESTORE_NAME = "SeRestorePrivilege";

    public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

    public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

    public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

    public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

    public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

    public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

    public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

    public const string SE_TCB_NAME = "SeTcbPrivilege";

    public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

    public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

    public const string SE_UNDOCK_NAME = "SeUndockPrivilege";

    public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

    public const uint SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1u;

    public const uint SE_PRIVILEGE_ENABLED = 2u;

    public const uint SE_PRIVILEGE_REMOVED = 4u;

    public const uint SE_PRIVILEGE_USED_FOR_ACCESS = 2147483648u;

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetCurrentProcess();

    [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, out LUID lpLuid);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hHandle);

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, uint Zero, IntPtr Null1, IntPtr Null2);

    public static void GoDebugPriv()
    {
        if (OpenProcessToken(GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out var TokenHandle))
        {
            if (!LookupPrivilegeValue(null, "SeDebugPrivilege", out var lpLuid))
            {
                CloseHandle(TokenHandle);
                return;
            }

            TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
            NewState.PrivilegeCount = 1u;
            NewState.Luid = lpLuid;
            NewState.Attributes = 2u;
            AdjustTokenPrivileges(TokenHandle, DisableAllPrivileges: false, ref NewState, 0u, IntPtr.Zero, IntPtr.Zero);
            CloseHandle(TokenHandle);
        }
    }
}