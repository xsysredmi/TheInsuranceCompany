namespace TIC.DomainModel
{
    public class LiabilityInsurance : Insurance
    {
        public decimal InsuredAmount { get; set; }
        public bool Excess { get; set; }
        public decimal ExcessAmount { get; set; }
    }
}