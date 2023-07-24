namespace TIC.WebAPI.Models
{
    public class CarInsurance : Insurance
    {
        public string LicensePlate { get; set; }

        public int WeightInKg { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}