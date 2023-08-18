using TIC.DomainModel;
using TIC.WebAPI.Models.Requests;

namespace TIC.WebAPI.Mappers.Impl
{
    public class AddInsuranceRequestMapper : IAddInsuranceRequestMapper
    {
        public Insurance Map(AddInsuranceRequest request)
        {
            CarInsurance carInsurance = new() 
            {
                Name = request.Name,
                Description = request.Description,
                InsurancePremium = request.InsurancePremium,
                InsuredAmount = request.InsuredAmount,
                LicensePlate = request.LicensePlate,
                WeightInKg = request.WeightInKg,
                DateOfBirth = request.DateOfBirth,
            };
            return carInsurance;
        }
    }
}
