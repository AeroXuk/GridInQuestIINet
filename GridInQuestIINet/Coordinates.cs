using System;
using System.Runtime.InteropServices;

namespace GridInQuestIINet
{
    public static partial class GridInQuestII
    {
        /// <summary>Represents a set of Coordinates.</summary>
        public class Coordinates : IDisposable
        {
            internal IntPtr _Native = IntPtr.Zero;

            /// <summary>Initialises a new set of default coordinates (0,0,0).</summary>
            public Coordinates() : this(0, 0, 0) { }

            /// <summary>Initialises a new set of coordinates with default Z axis (X,Y,0).</summary>
            /// <param name="x">The X axis.</param>
            /// <param name="y">The Y axis.</param>
            public Coordinates(double x, double y) : this(x, y, 0) { }

            /// <summary>Initialises a new set of coordinates (X,Y,Z).</summary>
            /// <param name="x">The X axis.</param>
            /// <param name="y">The Y axis.</param>
            /// <param name="z">The Z axis.</param>
            public Coordinates(double x, double y, double z)
            {
                var native = new UnsafeNativeMethods.Coordinates(x, y, z);
                _Native = Marshal.AllocHGlobal(Marshal.SizeOf(native));
                Marshal.StructureToPtr(native, _Native, false);
            }

            /// <summary>X Coordinate</summary>
            public double X
            {
                get { unsafe { return ((UnsafeNativeMethods.Coordinates*)_Native)->X; } }
                set { unsafe { ((UnsafeNativeMethods.Coordinates*)_Native)->X = value; } }
            }

            /// <summary>Y Coordinate</summary>
            public double Y
            {
                get { unsafe { return ((UnsafeNativeMethods.Coordinates*)_Native)->Y; } }
                set { unsafe { ((UnsafeNativeMethods.Coordinates*)_Native)->Y = value; } }
            }

            /// <summary>Z Coordinate</summary>
            public double Z
            {
                get { unsafe { return ((UnsafeNativeMethods.Coordinates*)_Native)->Z; } }
                set { unsafe { ((UnsafeNativeMethods.Coordinates*)_Native)->Z = value; } }
            }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
            ~Coordinates() { Dispose(false); }

            protected virtual void Dispose(bool disposing)
            {
                if (_Native != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(_Native);
                    _Native = IntPtr.Zero;
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            public override string ToString()
            {
                return string.Format("[{0},{1},{2}]", X, Y, Z);
            }

            public override bool Equals(object obj)
            {
                return obj is Coordinates coordinates &&
                       X == coordinates.X &&
                       Y == coordinates.Y &&
                       Z == coordinates.Z;
            }

            public override int GetHashCode()
            {
                var hashCode = -307843816;
                hashCode = hashCode * -1521134295 + X.GetHashCode();
                hashCode = hashCode * -1521134295 + Y.GetHashCode();
                hashCode = hashCode * -1521134295 + Z.GetHashCode();
                return hashCode;
            }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        }
    }
}
