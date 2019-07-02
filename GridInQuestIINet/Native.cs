using System;
using System.Runtime.InteropServices;

namespace GridInQuestIINet
{
    public static partial class GridInQuestII
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected internal struct UnsafeNativeMethods
        {
            [DllImport("GIQ", CallingConvention = CallingConvention.Cdecl,
               EntryPoint = "ConvertCoordinates")]
            [return: MarshalAs(UnmanagedType.I1)]
            //extern int ConvertCoordinates(int SRIDSource, int SRIDTarget, int RevisionSource, int RevisionTarget, coordinates *SourceCoordinates, coordinates *TargetCoordinates, int *DatumCode);
            internal static extern bool ConvertCoordinates(int SRIDSource, int SRIDTarget, int RevisionSource, int RevisionTarget, IntPtr SourceCoordinates, IntPtr TargetCoordinates, IntPtr DatumCode);

            [StructLayout(LayoutKind.Explicit, Size = 24)]
            internal struct Coordinates
            {
                [FieldOffset(0)]
                internal double X;

                [FieldOffset(8)]
                internal double Y;

                [FieldOffset(16)]
                internal double Z;

                internal Coordinates(double x, double y, double z)
                {
                    X = x;
                    Y = y;
                    Z = z;
                }
            }
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
