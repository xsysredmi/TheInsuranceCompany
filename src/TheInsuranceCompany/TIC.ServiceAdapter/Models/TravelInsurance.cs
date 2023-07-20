namespace TIC.ServiceAdapter.Models
{
    public class TravelInsurance : Insurance
    {
        public IEnumerable<Country>? Coverage { get; set; }
        public decimal InsuredAmount { get; set; }
    }
}