namespace Test.Business.Models
{
    public class DestinationDto
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public int UserId { get; set; }
    }
}
