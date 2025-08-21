using System.Runtime.InteropServices;
using System.Security.Principal;

namespace CReiss.Core
{

	public static class Security
	{
		public class AppUser
		{
			public string Username { get; set; } = String.Empty;
			public bool IsAdmin { get; set; } = false;
            public bool IsUser { get; set; } = false;
        }

		private const int ERROR_SUCCESS = 0;

		[DllImport("Netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern int NetLocalGroupGetMembers(
			string servername,
			string groupname,
			uint level,
			out IntPtr bufptr,
			uint prefmaxlen,
			out uint entriesread,
			out uint totalentries,
			IntPtr resume_handle
		);

		[DllImport("Netapi32.dll")]
		private static extern int NetApiBufferFree(IntPtr buffer);

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct LOCALGROUP_MEMBERS_INFO_1
		{
			public IntPtr sid;
			public SID_NAME_USE sidUsage;
			public IntPtr name;
		}

		private enum SID_NAME_USE
		{
			User = 1,
			Group,
			Domain,
			Alias,
			WellKnownGroup,
			DeletedAccount,
			Invalid,
			Unknown,
			Computer,
			Label
		}

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
		public static bool IsUserInLocalGroup(string username, string groupName)
		{
			IntPtr buffer = IntPtr.Zero;
			uint entriesRead = 0;
			uint totalEntries = 0;
			//
			string inputUser = username;
			int backslashIndex = username.LastIndexOf('\\');
			if (backslashIndex >= 0)
			{
				inputUser = username.Substring(backslashIndex + 1); // strip domain/machine prefix
			}
			string normalizedInput = inputUser.Trim().ToLowerInvariant();

			int result = NetLocalGroupGetMembers(
				null, groupName, 1,
				out buffer,
				0xFFFFFFFF,
				out entriesRead,
				out totalEntries,
				IntPtr.Zero
			);
			if (result != ERROR_SUCCESS || buffer == IntPtr.Zero || entriesRead == 0)
			{
				return false;
			}
			try
			{
				int structSize = Marshal.SizeOf(typeof(LOCALGROUP_MEMBERS_INFO_1));
				for (int i = 0; i < entriesRead; i++)
				{
					IntPtr itemPtr = IntPtr.Add(buffer, i * structSize);
					// Very defensive read
					LOCALGROUP_MEMBERS_INFO_1 member;
					try
					{
						member = Marshal.PtrToStructure<LOCALGROUP_MEMBERS_INFO_1>(itemPtr);
					}
					catch
					{
						continue; // skip any invalid entries
					}
					if (member.name == IntPtr.Zero)
					{
						continue;
					}
					string memberName = Marshal.PtrToStringUni(member.name);
					if (!string.IsNullOrEmpty(memberName))
					{
						string normalizedMember = memberName.Trim().ToLowerInvariant();
						if (normalizedMember == normalizedInput || normalizedMember.EndsWith("\\" + normalizedInput))
						{
							return true;
						}
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
