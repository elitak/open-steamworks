// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EP2PSend : int
	{
		k_EP2PSendUnreliable = 0,
		k_EP2PSendUnreliableNoDelay = 1,
		k_EP2PSendReliable = 2,
		k_EP2PSendReliableWithBuffering = 3,
	};
	
	public enum EP2PSessionError : int
	{
		k_EP2PSessionErrorNone = 0,
		k_EP2PSessionErrorNotRunningApp = 1,
		k_EP2PSessionErrorNoRightsToApp = 2,
		k_EP2PSessionErrorDestinationNotLoggedIn = 3,
		k_EP2PSessionErrorTimeout = 4,
	};
	
	public enum ESNetSocketConnectionType : int
	{
		k_ESNetSocketConnectionTypeNotConnected = 0,
		k_ESNetSocketConnectionTypeUDP = 1,
		k_ESNetSocketConnectionTypeUDPRelay = 2,
	};
	
	public enum ESNetSocketState : int
	{
		k_ESNetSocketStateInvalid = 0,
		k_ESNetSocketStateConnected = 1,
		k_ESNetSocketStateInitiated = 10,
		k_ESNetSocketStateLocalCandidatesFound = 11,
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		k_ESNetSocketStateChallengeHandshake = 15,
		k_ESNetSocketStateDisconnecting = 21,
		k_ESNetSocketStateLocalDisconnect = 22,
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		k_ESNetSocketStateConnectionBroken = 25,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct P2PSessionState_t
	{
		Byte m_bConnectionActive;
		Byte m_bConnecting;
		Byte m_eP2PSessionError;
		Byte m_bUsingRelay;
		Int32 m_nBytesQueuedForSend;
		Int32 m_nPacketsQueuedForSend;
		UInt32 m_nRemoteIP;
		UInt16 m_nRemotePort;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct SocketStatusCallback_t
	{
		UInt32 m_hSocket;
		UInt32 m_hListenSocket;
		UInt64 m_steamIDRemote;
		Int32 m_eSNetSocketState;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct P2PSessionRequest_t
	{
		UInt64 m_steamIDRemote;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct P2PSessionConnectFail_t
	{
		UInt64 m_steamIDRemote;
		Byte m_eP2PSessionError;
	};
	
}