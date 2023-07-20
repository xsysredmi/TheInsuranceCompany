using TIC.WebAPI.Models.Requests;

namespace TIC.WebAPI.Mappers.Impl
{
    public class GetInsurancesRequestMapper : IGetInsurancesRequestMapper
    {
        public DomainModel.Request.GetInsurancesRequest Map(GetInsurancesRequest request)
        {
            return new DomainModel.Request.GetInsurancesRequest();
        }
    }
}
