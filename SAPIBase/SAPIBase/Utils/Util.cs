﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SAPIBase
{
    public static class Util
    {
        public const float Size_KB = 1024.0f;
        public const float Size_MB = Size_KB * Size_KB;

        public static string MsgTitle { get; set; } 

        public enum SizeType
        {
            Bytes,
            KB,
            MB,
        }

        static Util()
        {
            MsgTitle = "SAPI Base";
        }

        public static float BytesToKB( int bytes )
        {
            return (float)Math.Round( bytes / Size_KB, 2 );
        }

        public static int KBToBytes( float kb )
        {
            return ( int )Math.Round( kb * Size_KB, 2 );
        }

        public static float BytesToLargest( int bytes, out SizeType type )
        {
            if ( ( bytes / Size_MB ) > 1 )
            {
                type = SizeType.MB;
                return (float)Math.Round( bytes / Size_MB, 2 );
            }
            
            if ( ( bytes / Size_KB ) > 1 )
            {
                type = SizeType.KB;
                return (float)Math.Round( bytes / Size_KB, 2 );
            }

            type = SizeType.Bytes;
            return ( float )Math.Round( ( double )bytes, 2 );
        }

        public static void MsgBox( IWin32Window owner, string text )
        {
            MessageBox.Show( owner, text, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
        public static DialogResult YesNoCancel( IWin32Window owner, string text )
        {
            return MessageBox.Show( owner, text, MsgTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
        }

        public static bool StartProcess( string fileName, string args )
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = fileName,
                Arguments = args,

                UseShellExecute = false,
            };

            try
            {
                Process.Start( psi );

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
