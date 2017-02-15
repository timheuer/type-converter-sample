using System;

namespace CustomControlWithType
{
    [Windows.Foundation.Metadata.CreateFromString(MethodName = "CustomControlWithType.Location.ConvertToLatLong")]
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }

        public static Location ConvertToLatLong(string rawString)
        {
            string[] coords = rawString.Split(',');
            
            var position = new Location();
            position.Latitude = Convert.ToDouble(coords[0]);
            position.Longitude = Convert.ToDouble(coords[1]);

            if (coords.Length > 2)
            {
                position.Altitude = Convert.ToDouble(coords[2]);
            }

            return position;
        }
    }
}