using TIC.WebAPI.Models.Requests;

namespace TIC.WebAPI.Mappers;

public interface IAddInsuranceRequestMapper
{
    DomainModel.Insurance Map(AddInsuranceRequest request);
}