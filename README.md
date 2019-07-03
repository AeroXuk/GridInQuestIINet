# GridInQuestIINet: A .Net wrapper for [GridInQuestII](https://bitbucket.org/PaulFMichell/GridInQuestII/), written in C#.

Usage
-----

```c#
using System;
using GridInQuestIINet;

namespace GridInQuestIINet.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			GridInQuestII.SRID
				sourceSRID = GridInQuestII.SRID.OSGB36,
				targetSRID = GridInQuestII.SRID.ETRS89_Geodetic;

			GridInQuestII.Coordinates
				sourceCoordinates = new GridInQuestII.Coordinates(529022, 179665),
				targetCoordinates = new GridInQuestII.Coordinates();

			Console.WriteLine("From: E {0:000000}, N {1:0000000}", sourceCoordinates.X, sourceCoordinates.Y);

			bool success = GridInQuestII.ConvertCoordinates(sourceSRID, targetSRID, sourceCoordinates, targetCoordinates);

			if(success)
			{
				Console.WriteLine("To: Long {0:+00.0000;-00.0000}, Lat {1:+00.0000;-00.0000}",
					GridInQuestII.RadianToDegree(targetCoordinates.X),
					GridInQuestII.RadianToDegree(targetCoordinates.Y)
					);
			}
			else
			{
				Console.WriteLine("Error while converting Coordinates.");
			}
		}
	}
}
```

License
-------

GridInQuestIINet is available as open source under the terms of the [GNU LGPL v2.1 License](https://opensource.org/licenses/LGPL-2.1).

GridInQuest II Coordinate Transformation Utility Software is Copyright (C) 2015 Paul Michell, Michell Computing.  
It was developed for the Northern Ireland Land and Property Services and the Ordnance Surveys of Britain and Ireland.

There library is free software and can redistributed and/or modify under the terms of the [GNU Lesser General Public License version 2.1](https://opensource.org/licenses/LGPL-2.1) as published by the Free Software Foundation; or any later version.
