// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserItems002VTable
	{
		public IntPtr LoadItems0;
		public IntPtr GetItemCount1;
		public IntPtr GetItemIterative2;
		public IntPtr GetItemByID3;
		public IntPtr GetItemAttribute4;
		public IntPtr UpdateInventoryPos5;
		public IntPtr DropItem6;
		public IntPtr GetItemBlob7;
		public IntPtr SetItemBlob8;
		private IntPtr DTorISteamUserItems0029;
	};
	
	public class ISteamUserItems002 : InteropHelp.NativeWrapper<ISteamUserItems002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeLoadItems( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 LoadItems(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeLoadItems>( this.Functions.LoadItems0 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetItemCount( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 GetItemCount(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetItemCount>( this.Functions.GetItemCount1 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemIterativeUUUUEUUU( IntPtr thisptr, UInt32 i, ref UInt64 UniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetItemIterative( UInt32 i, ref UInt64 UniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute ) 
		{
			return this.GetFunction<NativeGetItemIterativeUUUUEUUU>( this.Functions.GetItemIterative2 )( this.ObjectAddress, i, ref UniqueID, ref ItemType, ref ItemLevel, ref Quality, ref Flags, ref Quantity, ref NbOfAttribute ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemByIDUUUEUUU( IntPtr thisptr, UInt64 uniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetItemByID( UInt64 uniqueID, ref UInt32 ItemType, ref UInt32 ItemLevel, ref EItemQuality Quality, ref UInt32 Flags, ref UInt32 Quantity, ref UInt32 NbOfAttribute ) 
		{
			return this.GetFunction<NativeGetItemByIDUUUEUUU>( this.Functions.GetItemByID3 )( this.ObjectAddress, uniqueID, ref ItemType, ref ItemLevel, ref Quality, ref Flags, ref Quantity, ref NbOfAttribute ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetItemAttributeUUUF( IntPtr thisptr, UInt64 uniqueID, UInt32 b, ref UInt32 c, ref float d );
		public void GetItemAttribute( UInt64 uniqueID, UInt32 b, ref UInt32 c, ref float d ) 
		{
			this.GetFunction<NativeGetItemAttributeUUUF>( this.Functions.GetItemAttribute4 )( this.ObjectAddress, uniqueID, b, ref c, ref d ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateInventoryPosUU( IntPtr thisptr, UInt64 uniqueID, UInt32 b );
		public void UpdateInventoryPos( UInt64 uniqueID, UInt32 b ) 
		{
			this.GetFunction<NativeUpdateInventoryPosUU>( this.Functions.UpdateInventoryPos5 )( this.ObjectAddress, uniqueID, b ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeDropItemU( IntPtr thisptr, UInt64 itemId );
		public void DropItem( UInt64 itemId ) 
		{
			this.GetFunction<NativeDropItemU>( this.Functions.DropItem6 )( this.ObjectAddress, itemId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetItemBlobU( IntPtr thisptr, ref UInt64 retarg, UInt64 itemId );
		public UInt64 GetItemBlob( UInt64 itemId ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetItemBlobU>( this.Functions.GetItemBlob7 )( this.ObjectAddress, ref ret, itemId ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSetItemBlobUBU( IntPtr thisptr, ref UInt64 retarg, UInt64 itemID, Byte[] blob, UInt32 size );
		public UInt64 SetItemBlob( UInt64 itemID, Byte[] blob, UInt32 size ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeSetItemBlobUBU>( this.Functions.SetItemBlob8 )( this.ObjectAddress, ref ret, itemID, blob, size ); return (UInt64)ret;
		}
		
	};
}
