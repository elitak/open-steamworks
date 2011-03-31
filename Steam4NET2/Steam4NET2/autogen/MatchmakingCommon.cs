// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum ELobbyComparison : int
	{
		k_ELobbyComparisonEqualToOrLessThan = -2,
		k_ELobbyComparisonLessThan = -1,
		k_ELobbyComparisonEqual = 0,
		k_ELobbyComparisonGreaterThan = 1,
		k_ELobbyComparisonEqualToOrGreaterThan = 2,
		k_ELobbyComparisonNotEqual = 3,
	};
	
	public enum ELobbyDistanceFilter : int
	{
		k_ELobbyDistanceFilterClose = 0,
		k_ELobbyDistanceFilterDefault = 1,
		k_ELobbyDistanceFilterFar = 2,
		k_ELobbyDistanceFilterWorldwide = 3,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct FavoritesListChanged_t
	{
		UInt32 m_nIP;
		UInt32 m_nQueryPort;
		UInt32 m_nConnPort;
		UInt32 m_nAppID;
		UInt32 m_nFlags;
		[MarshalAs(UnmanagedType.I1)]
		bool m_bAdd;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyInvite_t
	{
		UInt64 m_ulSteamIDUser;
		UInt64 m_ulSteamIDLobby;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyEnter_t
	{
		UInt64 m_ulSteamIDLobby;
		EChatPermission m_rgfChatPermissions;
		[MarshalAs(UnmanagedType.I1)]
		bool m_bLocked;
		EChatRoomEnterResponse m_EChatRoomEnterResponse;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyDataUpdate_t
	{
		UInt64 m_ulSteamIDLobby;
		UInt64 m_ulSteamIDMember;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyChatUpdate_t
	{
		UInt64 m_ulSteamIDLobby;
		UInt64 m_ulSteamIDUserChanged;
		UInt64 m_ulSteamIDMakingChange;
		EChatMemberStateChange m_rgfChatMemberStateChange;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyChatMsg_t
	{
		UInt64 m_ulSteamIDLobby;
		UInt64 m_ulSteamIDUser;
		Byte m_eChatEntryType;
		UInt32 m_iChatID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyAdminChange_t
	{
		UInt64 m_ulSteamIDLobby;
		UInt64 m_ulSteamIDNewAdmin;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyGameCreated_t
	{
		UInt64 m_ulSteamIDLobby;
		UInt64 m_ulSteamIDGameServer;
		UInt32 m_unIP;
		UInt16 m_usPort;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyMatchList_t
	{
		UInt32 m_nLobbiesMatching;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyClosing_t
	{
		UInt64 m_ulSteamIDLobby;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyKicked_t
	{
		UInt64 m_ulSteamIDLobby;
		UInt64 m_ulSteamIDAdmin;
		Byte m_bKickedDueToDisconnect;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct LobbyCreated_t
	{
		EResult m_eResult;
		UInt64 m_ulSteamIDLobby;
	};
	
}
