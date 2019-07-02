using System;
using System.Runtime.InteropServices;

namespace GridInQuestIINet
{
    /// <summary>Grid in Quest II Wrapper</summary>
    public static partial class GridInQuestII
    {
        /// <summary>Convert Coordinates from one Spatial Reference Identification system to another.</summary>
        /// <param name="SRIDSource">The SRID for the source input coordinates.</param>
        /// <param name="SRIDTarget">The SRID for the target output coordinates.</param>
        /// <param name="SourceCoordinates">Input parameter containing the source coordinates.</param>
        /// <param name="TargetCoordinates">Output parameter containing the target coordinates.</param>
        /// <returns>Whether the conversion was a Success.</returns>
        public static bool ConvertCoordinates(SRID SRIDSource, SRID SRIDTarget, Coordinates SourceCoordinates, Coordinates TargetCoordinates)
            => ConvertCoordinates(SRIDSource, SRIDTarget, 0, 0, SourceCoordinates, TargetCoordinates, IrishDatum.None);

        /// <summary>Convert Coordinates from one Spatial Reference Identification system to another.</summary>
        /// <param name="SRIDSource">The SRID for the source input coordinates.</param>
        /// <param name="SRIDTarget">The SRID for the target output coordinates.</param>
        /// <param name="SourceCoordinates">Input parameter containing the source coordinates.</param>
        /// <param name="TargetCoordinates">Output parameter containing the target coordinates.</param>
        /// <param name="DatumCode">Irish vertical datum code.</param>
        /// <returns>Whether the conversion was a Success.</returns>
        public static bool ConvertCoordinates(SRID SRIDSource, SRID SRIDTarget, Coordinates SourceCoordinates, Coordinates TargetCoordinates, IrishDatum DatumCode)
            => ConvertCoordinates(SRIDSource, SRIDTarget, 0, 0, SourceCoordinates, TargetCoordinates, DatumCode);

        /// <summary>Convert Coordinates from one Spatial Reference Identification system to another.</summary>
        /// <param name="SRIDSource">The SRID for the source input coordinates.</param>
        /// <param name="SRIDTarget">The SRID for the target output coordinates.</param>
        /// <param name="RevisionSource">The revision year for the source coordinate system.</param>
        /// <param name="RevisionTarget">The revision year for the target coordinate system.</param>
        /// <param name="SourceCoordinates">Input parameter containing the source coordinates.</param>
        /// <param name="TargetCoordinates">Output parameter containing the target coordinates.</param>
        /// <returns>Whether the conversion was a Success.</returns>
        public static bool ConvertCoordinates(SRID SRIDSource, SRID SRIDTarget, int RevisionSource, int RevisionTarget, Coordinates SourceCoordinates, Coordinates TargetCoordinates)
            => ConvertCoordinates(SRIDSource, SRIDTarget, RevisionSource, RevisionTarget, SourceCoordinates, TargetCoordinates, IrishDatum.None);

        /// <summary>Convert Coordinates from one Spatial Reference Identification system to another.</summary>
        /// <param name="SRIDSource">The SRID for the source input coordinates.</param>
        /// <param name="SRIDTarget">The SRID for the target output coordinates.</param>
        /// <param name="RevisionSource">The revision year for the source coordinate system.</param>
        /// <param name="RevisionTarget">The revision year for the target coordinate system.</param>
        /// <param name="SourceCoordinates">Input parameter containing the source coordinates.</param>
        /// <param name="TargetCoordinates">Output parameter containing the target coordinates.</param>
        /// <param name="DatumCode">Irish vertical datum code.</param>
        /// <returns>Whether the conversion was a Success.</returns>
        public static bool ConvertCoordinates(SRID SRIDSource, SRID SRIDTarget, int RevisionSource, int RevisionTarget, Coordinates SourceCoordinates, Coordinates TargetCoordinates, IrishDatum DatumCode)
        {
            bool ok = false;
            IntPtr pDatum = IntPtr.Zero;
            try
            {
                pDatum = Marshal.AllocHGlobal(Marshal.SizeOf((int)DatumCode));
                Marshal.WriteInt32(pDatum, (int)DatumCode);
                ok = UnsafeNativeMethods.ConvertCoordinates((int)SRIDSource, (int)SRIDTarget, RevisionSource, RevisionTarget, SourceCoordinates._Native, TargetCoordinates._Native, pDatum);
                DatumCode = (IrishDatum)Marshal.ReadInt32(pDatum);
            }
            finally
            {
                if (pDatum != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pDatum);
                }
            }
            return ok;
        }
    }
}
