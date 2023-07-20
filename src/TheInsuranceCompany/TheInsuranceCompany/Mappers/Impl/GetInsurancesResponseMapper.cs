using TIC.DomainModel;
using TIC.WebAPI.Models.Responses;

namespace TIC.WebAPI.Mappers.Impl;

public class GetInsurancesResponseMapper : IGetInsurancesResponseMapper
{
    public GetInsurancesResponse Map(IEnumerable<Insurance> insurances)
    {
        return new GetInsurancesResponse
        {
            Name = insurances.Select(i => i.Name)
        };
    }
}