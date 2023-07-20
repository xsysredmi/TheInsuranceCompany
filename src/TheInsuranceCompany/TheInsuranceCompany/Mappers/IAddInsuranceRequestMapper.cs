using TIC.DomainModel;
using TIC.WebAPI.Models.Requests;

namespace TIC.WebAPI.Mappers;

public interface IAddInsuranceRequestMapper
{
    Insurance Map(AddInsuranceRequest request);
}