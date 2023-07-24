using TIC.WebAPI.Models.Responses;

namespace TIC.WebAPI.Mappers;

public interface IGetInsurancesResponseMapper
{
    GetInsurancesResponse Map(IEnumerable<DomainModel.Insurance> insurances);
}