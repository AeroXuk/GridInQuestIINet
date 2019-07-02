namespace GridInQuestIINet
{
    public static partial class GridInQuestII
    {
        /// <summary>Spatial Reference Identification</summary>
        public enum SRID : int
        {
            /// <summary>Irish Transverse Mercator Coordinates
            /// A new system, intended to supersede the Irish Grid as it's definition was directly based upon GPS compatibility.
            /// This makes it simpler to integrate with modern systems, whilst at the same time preserving many of the characteristics of Irish Grid that make it ideally suited for use within the island of Ireland.
            /// To avoid confusion with the older system, the false origin has been moved further into the Atlantic so as to create substantially different coordinates for any given location.
            /// As with Irish Grid, the vertical datum in Northern Ireland is fixed to Belfast Lough and Malin Head within the Republic.
            /// It also employs the OSGM15 geoid model to determine height values.
            /// </summary>
            IrishTransverseMercator = 2157,

            /// <summary>ETRS89 Cartesian Coordinates
            /// 3D Cartesian coordinates, where the individual axis values are expressed in metres from the origin, which is located at the Earth's centre of gravity.
            /// The Z axis is defined as passing through the Earth's rotational North pole.
            /// The X axis passes through the equator on the Greenwich Meridian and the Y axis is orthogonal to these.
            /// </summary>
            ETRS89_Cartesian = 4936,

            /// <summary>ETRS89 Geodetic Coordinates
            /// Geodetic coordinates, where the latitude and longitude are given in degrees (radians) and the height given above the GRS1980 ellipsoid in metres.
            /// </summary>
            ETRS89_Geodetic = 4937,

            /// <summary>ETRS89 UTM Coordinates Zone 29N
            /// Only available for Northern Ireland and the Republic of Ireland.
            /// Heights are ellipsoidal and refer to height above the GRS1980 ellipsoid.
            /// </summary>
            ETRS89_UTM_Zone_29N = 25829,

            /// <summary>
            /// Zone 30N overlaps the east of Ireland and west and central Britain.
            /// Heights are ellipsoidal and refer to height above the GRS1980 ellipsoid.
            /// </summary>
            ETRS89_UTM_Zone_30N = 25830,

            /// <summary>ETRS89 UTM Coordinates Zone 31N
            /// Only available for Great Britain.
            /// Heights are ellipsoidal and refer to height above the GRS1980 ellipsoid.
            /// </summary>
            ETRS89_UTM_Zone_31N = 25831,

            /// <summary>OSGB36 / British National Grid Coordinates
            /// The British National Grid was originally defined through classical survey techniques.
            /// In 2002 a new definition was introduced that employed direct transformation from ETRS89 to OSGB36 coordinates called the National Transformation OSTN02.
            /// In 2015 this method was updated to improve the accuracy, and the newer version OSTN15 now replaces OSTN02 as the definitive horizontal transformation for British National Grid.
            /// A similar method for determining height values relative to local sea level was also developed.
            /// This was known as the Ordnance Survey Geoid Model OSGM02.
            /// This has similarly been replaced by a newer version in 2015 and this is known as the OSGM15.
            /// </summary>
            OSGB36 = 27700,

            /// <summary>Irish Grid Coordinates
            /// Transverse Mercator projection, but one using the Airy Modified ellipsoid which gives a closer fit to the actual figure of Earth for Ireland than that used for the ETRS89 UTM systems.
            /// It also has a central meridian positioned along the middle of the Irish landmass to minimize distortion.
            /// Heights are expressed with respect to the Malin Head datum for the Republic of Ireland and Belfast Lough for use within Northern Ireland.
            /// These orthometric heights are now determined by an extension of the OSGM15 geoid model to cover the island of Ireland.
            /// </summary>
            IrishGrid = 29903
        }
    }
}
