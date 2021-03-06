// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamScreenshots001VTable
	{
		public IntPtr WriteScreenshot0;
		public IntPtr AddScreenshotToLibrary1;
		public IntPtr TriggerScreenshot2;
		public IntPtr HookScreenshots3;
		public IntPtr SetLocation4;
		public IntPtr TagUser5;
		private IntPtr DTorISteamScreenshots0016;
	};
	
	[InteropHelp.InterfaceVersion("STEAMSCREENSHOTS_INTERFACE_VERSION001")]
	public class ISteamScreenshots001 : InteropHelp.NativeWrapper<ISteamScreenshots001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeWriteScreenshotBUII( IntPtr thisptr, Byte[] arg0, UInt32 arg1, Int32 arg2, Int32 arg3 );
		public UInt32 WriteScreenshot( Byte[] arg0, UInt32 arg1, Int32 arg2, Int32 arg3 ) 
		{
			return this.GetFunction<NativeWriteScreenshotBUII>( this.Functions.WriteScreenshot0 )( this.ObjectAddress, arg0, arg1, arg2, arg3 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddScreenshotToLibrarySSII( IntPtr thisptr, string arg0, string arg1, Int32 arg2, Int32 arg3 );
		public UInt32 AddScreenshotToLibrary( string arg0, string arg1, Int32 arg2, Int32 arg3 ) 
		{
			return this.GetFunction<NativeAddScreenshotToLibrarySSII>( this.Functions.AddScreenshotToLibrary1 )( this.ObjectAddress, arg0, arg1, arg2, arg3 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTriggerScreenshot( IntPtr thisptr );
		public void TriggerScreenshot(  ) 
		{
			this.GetFunction<NativeTriggerScreenshot>( this.Functions.TriggerScreenshot2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeHookScreenshotsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool arg0 );
		public void HookScreenshots( bool arg0 ) 
		{
			this.GetFunction<NativeHookScreenshotsB>( this.Functions.HookScreenshots3 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLocationUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLocation( UInt32 arg0, string arg1 ) 
		{
			return this.GetFunction<NativeSetLocationUS>( this.Functions.SetLocation4 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTagUserUC( IntPtr thisptr, UInt32 arg0, UInt64 steamIDUser );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool TagUser( UInt32 arg0, CSteamID steamIDUser ) 
		{
			return this.GetFunction<NativeTagUserUC>( this.Functions.TagUser5 )( this.ObjectAddress, arg0, steamIDUser.ConvertToUint64() ); 
		}
		
	};
}
