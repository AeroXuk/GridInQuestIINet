using System;

namespace GridInQuestIINet
{
    public static partial class GridInQuestII
    {
        /// <summary>Converts from Radians to Degrees.</summary>
        /// <param name="radians">Angle in Radians.</param>
        /// <returns>The Angle in Degrees.</returns>
        public static double RadiansToDegrees(double radians)
        {
            return radians * 180d / Math.PI;
        }

        /// <summary>Converts from Degrees to Radians.</summary>
        /// <param name="degrees">Angle in Degrees.</param>
        /// <returns>The Angle in Radians.</returns>
        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180d;
        }
    }
}
