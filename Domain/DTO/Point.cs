namespace devboost.dronedelivery.felipe.DTO
{
    public class Point
    {
        private const double LATITUDE_BASE = -23.9557228;
        private const double LONGITUDE_BASE = -46.3486396;

        public Point(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
              
        }

        public Point()
        {
            Latitude = LATITUDE_BASE;
            Longitude = LONGITUDE_BASE;
        }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
