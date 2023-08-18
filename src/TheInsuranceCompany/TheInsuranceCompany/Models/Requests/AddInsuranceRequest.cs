using System.Text.Json.Serialization;
using TIC.DomainModel;

namespace TIC.WebAPI.Models.Requests
{
    [Serializable]
    public class AddInsuranceRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal InsurancePremium { get; set; }
        public decimal InsuredAmount { get; set; }
        public string LicensePlate { get; set; }
        public int WeightInKg { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
