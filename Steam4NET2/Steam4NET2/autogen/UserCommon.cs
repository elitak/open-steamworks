// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EAuthSessionResponse : int
	{
		k_EAuthSessionResponseOK = 0,
		k_EAuthSessionResponseUserNotConnectedToSteam = 1,
		k_EAuthSessionResponseNoLicenseOrExpired = 2,
		k_EAuthSessionResponseVACBanned = 3,
		k_EAuthSessionResponseLoggedInElseWhere = 4,
		k_EAuthSessionResponseVACCheckTimedOut = 5,
		k_EAuthSessionResponseAuthTicketCanceled = 6,
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed = 7,
		k_EAuthSessionResponseAuthTicketInvalid = 8,
	};
	
	public enum EBeginAuthSessionResult : int
	{
		k_EBeginAuthSessionResultOK = 0,
		k_EBeginAuthSessionResultInvalidTicket = 1,
		k_EBeginAuthSessionResultDuplicateRequest = 2,
		k_EBeginAuthSessionResultInvalidVersion = 3,
		k_EBeginAuthSessionResultGameMismatch = 4,
		k_EBeginAuthSessionResultExpiredTicket = 5,
	};
	
	public enum EAppUsageEvent : int
	{
		k_EAppUsageEventGameLaunch = 1,
		k_EAppUsageEventGameLaunchTrial = 2,
		k_EAppUsageEventMedia = 3,
		k_EAppUsageEventPreloadStart = 4,
		k_EAppUsageEventPreloadFinish = 5,
		k_EAppUsageEventMarketingMessageView = 6,
		k_EAppUsageEventInGameAdViewed = 7,
		k_EAppUsageEventGameLaunchFreeWeekend = 8,
	};
	
	public enum ERegistrySubTree : int
	{
		k_ERegistrySubTreeNews = 0,
		k_ERegistrySubTreeApps = 1,
		k_ERegistrySubTreeSubscriptions = 2,
		k_ERegistrySubTreeGameServers = 3,
		k_ERegistrySubTreeFriends = 4,
		k_ERegistrySubTreeSystem = 5,
		k_ERegistrySubTreeAppOwnershipTickets = 6,
		k_ERegistrySubTreeLegacyCDKeys = 7,
	};
	
	public enum ELogonState : int
	{
		k_ELogonStateNotLoggedOn = 0,
		k_ELogonStateLoggingOn = 1,
		k_ELogonStateLoggingOff = 2,
		k_ELogonStateLoggedOn = 3,
	};
	
	public enum EVoiceResult : int
	{
		k_EVoiceResultOK = 0,
		k_EVoiceResultNotInitialized = 1,
		k_EVoiceResultNotRecording = 2,
		k_EVoiceResultNoData = 3,
		k_EVoiceResultBufferTooSmall = 4,
		k_EVoiceResultDataCorrupted = 5,
		k_EVoiceResultRestricted = 6,
		k_EVoiceResultUnsupportedCodec = 7,
	};
	
	public enum EVACBan : int
	{
		k_EVACBanGoldsrc = 0,
		k_EVACBanSource = 1,
		k_EVACBanDayOfDefeatSource = 2,
	};
	
	public enum EUserHasLicenseForAppResult : int
	{
		k_EUserHasLicenseResultHasLicense = 0,
		k_EUserHasLicenseResultDoesNotHaveLicense = 1,
		k_EUserHasLicenseResultNoAuth = 2,
	};
	
	public enum ENewsUpdateType : int
	{
		k_EAppNews = 0,
		k_ESteamAds = 1,
		k_ESteamNews = 2,
		k_ECDDBUpdate = 3,
		k_EClientUpdate = 4,
	};
	
	public enum ESteamUsageEvent : int
	{
		k_ESteamUsageEventMarketingMessageView = 1,
		k_ESteamUsageEventHardwareSurvey = 2,
		k_ESteamUsageEventDownloadStarted = 3,
		k_ESteamUsageEventLocalizedAudioChange = 4,
	};
	
	public enum EClientStat : int
	{
		k_EClientStatP2PConnectionsUDP = 0,
		k_EClientStatP2PConnectionsRelay = 1,
		k_EClientStatP2PGameConnections = 2,
		k_EClientStatP2PVoiceConnections = 3,
		k_EClientStatBytesDownloaded = 4,
		k_EClientStatMax = 5,
	};
	
	public enum ENatType : int
	{
		eNatTypeUntested = 0,
		eNatTypeTestFailed = 1,
		eNatTypeNoUDP = 2,
		eNatTypeOpenInternet = 3,
		eNatTypeFullCone = 4,
		eNatTypeRestrictedCone = 5,
		eNatTypePortRestrictedCone = 6,
		eNatTypeUnspecified = 7,
		eNatTypeSymmetric = 8,
		eNatTypeSymmetricFirewall = 9,
		eNatTypeCount = 10,
	};
	
	public enum EMarketingMessageFlags : int
	{
		k_EMarketingMessageFlagsNone = 0,
		k_EMarketingMessageFlagsHighPriority = 1,
		k_EMarketingMessageFlagsPlatformWindows = 2,
		k_EMarketingMessageFlagsPlatformMac = 4,
		k_EMarketingMessageFlagsPlatformRestrictions = 6,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct CNatTraversalStat
	{
		public EResult m_eResult;
		public ENatType m_eLocalNatType;
		public ENatType m_eRemoteNatType;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bMultiUserChat;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bRelay;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(101)]
	public struct LogonSuccess_t
	{
		public const int k_iCallback = 101;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(101)]
	public struct SteamServersConnected_t
	{
		public const int k_iCallback = 101;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(102)]
	public struct LogonFailure_t
	{
		public const int k_iCallback = 102;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(102)]
	public struct SteamServerConnectFailure_t
	{
		public const int k_iCallback = 102;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(103)]
	public struct LoggedOff_t
	{
		public const int k_iCallback = 103;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(103)]
	public struct SteamServersDisconnected_t
	{
		public const int k_iCallback = 103;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(903)]
	public struct ClientPrimaryChatDestinationSet_t
	{
		public const int k_iCallback = 903;
		public Byte m_bIsPrimary;
		public Byte m_bWasPrimary;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(104)]
	public struct BeginLogonRetry_t
	{
		public const int k_iCallback = 104;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(106)]
	public struct Steam2TicketChanged_t
	{
		public const int k_iCallback = 106;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(110)]
	public struct ClientAppNewsItemUpdate_t
	{
		public const int k_iCallback = 110;
		public ENewsUpdateType m_eNewsUpdateType;
		public UInt32 m_uNewsID;
		public UInt32 m_uAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(112)]
	public struct ClientSteamNewsItemUpdate_t
	{
		public const int k_iCallback = 112;
		public ENewsUpdateType m_eNewsUpdateType;
		public UInt32 m_uNewsID;
		public UInt32 m_uHaveSubID;
		public UInt32 m_uNotHaveSubID;
		public UInt32 m_uHaveAppID;
		public UInt32 m_uNotHaveAppID;
		public UInt32 m_uHaveAppIDInstalled;
		public UInt32 m_uHavePlayedAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(113)]
	public struct ClientGameServerDeny_t
	{
		public const int k_iCallback = 113;
		public UInt32 m_uAppID;
		public UInt32 m_unGameServerIP;
		public UInt16 m_usGameServerPort;
		public UInt16 m_bSecure;
		public UInt32 m_uReason;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(114)]
	public struct PrimaryChatDestinationSet_t
	{
		public const int k_iCallback = 114;
		public Byte m_bIsPrimary;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(115)]
	public struct UserPolicyResponse_t
	{
		public const int k_iCallback = 115;
		public Byte m_bSecure;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(116)]
	public struct ClientSteamNewsClientUpdate_t
	{
		public const int k_iCallback = 116;
		public Byte m_eNewsUpdateType;
		public Byte m_bReloadCDDB;
		public UInt32 m_unCurrentBootstrapperVersion;
		public UInt32 m_unCurrentClientVersion;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(117)]
	public struct CallbackPipeFailure_t
	{
		public const int k_iCallback = 117;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(117)]
	public struct IPCFailure_t
	{
		public const int k_iCallback = 117;
		public const int k_EFailureFlushedCallbackQueue = 0;
		public Byte m_eFailureType;
	};
	
	public enum EFailureType : int
	{
		k_EFailureFlushedCallbackQueue = 0,
		k_EFailurePipeFail = 1,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(118)]
	public struct LegacyCDKeyRegistered_t
	{
		public const int k_iCallback = 118;
		public EResult m_eResult;
		public UInt32 m_iAppID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchCDKey;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(119)]
	public struct AccountInformationUpdated_t
	{
		public const int k_iCallback = 119;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(120)]
	public struct GuestPassSent_t
	{
		public const int k_iCallback = 120;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(121)]
	public struct GuestPassAcked_t
	{
		public const int k_iCallback = 121;
		public EResult m_eResult;
		public UInt32 m_unPackageID;
		public UInt64 m_gidGuestPassID;
		public UInt64 m_ulGuestPassKey;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(122)]
	public struct GuestPassRedeemed_t
	{
		public const int k_iCallback = 122;
		public EResult m_eResult;
		public UInt32 m_unPackageID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(123)]
	public struct UpdateGuestPasses_t
	{
		public const int k_iCallback = 123;
		public EResult m_eResult;
		public UInt32 m_cGuestPassesToGive;
		public UInt32 m_cGuestPassesToRedeem;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(124)]
	public struct LogOnCredentialsChanged_t
	{
		public const int k_iCallback = 124;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(125)]
	public struct LicensesUpdated_t
	{
		public const int k_iCallback = 125;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(126)]
	public struct CheckPasswordResponse_t
	{
		public const int k_iCallback = 126;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(127)]
	public struct ResetPasswordResponse_t
	{
		public const int k_iCallback = 127;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(130)]
	public struct AppLifetimeNotice_t
	{
		public const int k_iCallback = 130;
		public UInt32 m_nAppID;
		public Int32 m_nInstanceID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bExiting;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(131)]
	public struct AppOwnershipTicketReceived_t
	{
		public const int k_iCallback = 131;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(132)]
	public struct PasswordChangeResponse_t
	{
		public const int k_iCallback = 132;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(133)]
	public struct EmailChangeResponse_t
	{
		public const int k_iCallback = 133;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(134)]
	public struct SecretQAChangeResponse_t
	{
		public const int k_iCallback = 134;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(135)]
	public struct CreateAccountResponse_t
	{
		public const int k_iCallback = 135;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(137)]
	public struct SendForgottonPasswordEmailResponse_t
	{
		public const int k_iCallback = 137;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(138)]
	public struct ResetForgottonPasswordResponse_t
	{
		public const int k_iCallback = 138;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(140)]
	public struct DownloadFromDFSResponse_t
	{
		public const int k_iCallback = 140;
		public EResult m_EResult;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchURL;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(141)]
	public struct DRMSDKFileTransferResult_t
	{
		public const int k_iCallback = 141;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(142)]
	public struct ClientMarketingMessageUpdate_t
	{
		public const int k_iCallback = 142;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(143)]
	public struct ValidateAuthTicketResponse_t
	{
		public const int k_iCallback = 143;
		public UInt64 m_SteamID;
		public EAuthSessionResponse m_eAuthSessionResponse;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(148)]
	public struct MsgWebAuthToken_t
	{
		public const int k_iCallback = 148;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bValid;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_Token;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(152)]
	public struct MicroTxnAuthorizationResponse_t
	{
		public const int k_iCallback = 152;
		public UInt32 m_unAppID;
		public UInt64 m_ulOrderID;
		public Byte m_bAuthorized;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(154)]
	public struct EncryptedAppTicketResponse_t
	{
		public const int k_iCallback = 154;
		public EResult m_eResult;
	};
	
}
