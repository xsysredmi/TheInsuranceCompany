using TIC.DomainModel;
using TIC.WebAPI.Models.Responses;

namespace TIC.WebAPI.Mappers.Impl;

public class GetInsurancesResponseMapper : IGetInsurancesResponseMapper
{
    public GetInsurancesResponse Map(IEnumerable<Insurance> insurances)
    {
        return new GetInsurancesResponse
        {
            Name = insurances.Select(i => i.Name),
            Description = insurances.Select(i => i.Description),
            InsurancePremium = insurances.Select(i => i.InsurancePremium.ToString()),
            InsuredAmount = insurances.Select(i => i.InsuredAmount.ToString())
        };
    }
}