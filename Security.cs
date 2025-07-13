using System.Runtime.InteropServices;
using System.Security.Principal;

	using System;
using System.Runtime.InteropServices;

namespace CReiss.Core
{

	public static class Security
	{

		public static string CurrentUser()
		{
			string fullName = WindowsIdentity.GetCurrent().Name;
			if (fullName.Contains("\\"))
			{
				string[] parts = fullName.Split('\\');
				string parsedDomain = parts[0];
				string parsedUser = parts[1];
				fullName = parts[1];
			}
			return fullName;
		}
		public static bool IsUserInGroup(string groupName)
		{
			WindowsIdentity identity = WindowsIdentity.GetCurrent();
			WindowsPrincipal principal = new WindowsPrincipal(identity);
			return principal.IsInRole(groupName);
		}

	}



public class LocalGroupChecker
	{
		private const uint LG_INCLUDE_INDIRECT = 0x0001;
		private const uint ERROR_SUCCESS = 0;

		[DllImport("Netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern int NetUserGetLocalGroups(
			string servername,
			string username,
			uint level,
			uint flags,
			out IntPtr bufptr,
			out uint entriesread,
			out uint totalentries
		);

		[DllImport("Netapi32.dll", SetLastError = true)]
		private static extern int NetApiBufferFree(IntPtr buffer);

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct LOCALGROUP_USERS_INFO_0
		{
			public IntPtr name;
		}

		public static bool IsUserInLocalGroup(string username, string groupName)
		{
			IntPtr buffer = IntPtr.Zero;
			uint entriesRead = 0;
			uint totalEntries = 0;

			try
			{
				int result = NetUserGetLocalGroups(
					null, // local machine
					username,
					0, // level 0
					LG_INCLUDE_INDIRECT,
					out buffer,
					out entriesRead,
					out totalEntries
				);

				if (result != ERROR_SUCCESS || buffer == IntPtr.Zero)
				{
					return false;
				}

				int structSize = Marshal.SizeOf(typeof(LOCALGROUP_USERS_INFO_0));
				for (int i = 0; i < entriesRead; i++)
				{
					IntPtr itemPtr = new IntPtr(buffer.ToInt64() + i * structSize);
					LOCALGROUP_USERS_INFO_0 groupInfo = (LOCALGROUP_USERS_INFO_0)Marshal.PtrToStructure(itemPtr, typeof(LOCALGROUP_USERS_INFO_0));
					string group = Marshal.PtrToStringUni(groupInfo.name);

					if (string.Equals(group, groupName, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}

				return false;
			}
			finally
			{
				if (buffer != IntPtr.Zero)
				{
					NetApiBufferFree(buffer);
				}
			}
		}
	}


}
