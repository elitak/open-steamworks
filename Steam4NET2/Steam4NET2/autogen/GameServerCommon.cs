// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EDenyReason : int
	{
		k_EDenyInvalidVersion = 1,
		k_EDenyGeneric = 2,
		k_EDenyNotLoggedOn = 3,
		k_EDenyNoLicense = 4,
		k_EDenyCheater = 5,
		k_EDenyLoggedInElseWhere = 6,
		k_EDenyUnknownText = 7,
		k_EDenyIncompatibleAnticheat = 8,
		k_EDenyMemoryCorruption = 9,
		k_EDenyIncompatibleSoftware = 10,
		k_EDenySteamConnectionLost = 11,
		k_EDenySteamConnectionError = 12,
		k_EDenySteamResponseTimedOut = 13,
		k_EDenySteamValidationStalled = 14,
		k_EDenySteamOwnerLeftGuestUser = 15,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientApprove_t
	{
		UInt64 m_SteamID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientDeny_t
	{
		UInt64 m_SteamID;
		EDenyReason m_eDenyReason;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		string m_pchOptionalText;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientKick_t
	{
		UInt64 m_SteamID;
		EDenyReason m_eDenyReason;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientSteam2Deny_t
	{
		UInt32 m_UserID;
		ESteamError m_eSteamError;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientSteam2Accept_t
	{
		UInt32 m_UserID;
		UInt64 m_SteamID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientAchievementStatus_t
	{
		UInt64 m_SteamID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		string m_pchAchievement;
		[MarshalAs(UnmanagedType.I1)]
		bool m_bUnlocked;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSGameplayStats_t
	{
		EResult m_eResult;
		Int32 m_nRank;
		UInt32 m_unTotalConnects;
		UInt32 m_unTotalMinutesPlayed;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSClientGroupStatus_t
	{
		UInt64 m_SteamIDUser;
		UInt64 m_SteamIDGroup;
		[MarshalAs(UnmanagedType.I1)]
		bool m_bMember;
		[MarshalAs(UnmanagedType.I1)]
		bool m_bOfficer;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSReputation_t
	{
		EResult m_eResult;
		UInt32 m_unReputationScore;
		[MarshalAs(UnmanagedType.I1)]
		bool m_bBanned;
		UInt32 m_unBannedIP;
		UInt16 m_usBannedPort;
		UInt64 m_ulBannedGameID;
		UInt32 m_unBanExpires;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct GSPolicyResponse_t
	{
		Byte m_bSecure;
	};
	
}
