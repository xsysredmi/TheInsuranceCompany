namespace TIC.WebAPI.Models.Responses
{
    public class GetDutchTravelInsurancesResponse
    {
        public IEnumerable<string>? Name { get; set; }
        public IEnumerable<string>? Description { get; set; }
        public IEnumerable<string>? InsurancePremium { get; set; }
        public IEnumerable<string>? InsuredAmount { get; set; }

    }
}