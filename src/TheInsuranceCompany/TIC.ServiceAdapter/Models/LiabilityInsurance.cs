namespace TIC.ServiceAdapter.Models
{
    public class LiabilityInsurance : Insurance
    {
        public decimal InsuredAmount { get; set; }
        public bool Excess { get; set; }
        public decimal ExcessAmount { get; set; }
    }
}