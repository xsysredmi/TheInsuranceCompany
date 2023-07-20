using TIC.DomainModel;
using TIC.WebAPI.Models.Requests;

namespace TIC.WebAPI.Mappers.Impl
{
    public class AddInsuranceRequestMapper : IAddInsuranceRequestMapper
    {
        public Insurance Map(AddInsuranceRequest request)
        {
            return new CarInsurance();
        }
    }
}
