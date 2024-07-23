using TIC.DomainModel;
using TIC.DomainModel.Request;
using TIC.ServiceAdapter;

namespace TIC.DomainAPI.Impl
{
    public class InsuranceDomain : IInsuranceDomain
    {
        private readonly IInsuranceProvider _insuranceProvider;

        public InsuranceDomain(IInsuranceProvider insuranceProvider)
        {
            _insuranceProvider = insuranceProvider;
        }

        public IEnumerable<Insurance> GetInsurances(GetInsurancesRequest getInsurancesRequest)
        {
            return _insuranceProvider.GetInsurances();
        }

        public void AddInsurance(Insurance insurance)
        {
            _insuranceProvider.AddInsurance(insurance);
        }

        IEnumerable<Insurance> IInsuranceDomain.GetInsurances(GetInsurancesRequest getInsurancesRequest)
        {
            throw new NotImplementedException();
        }

        void IInsuranceDomain.AddInsurance(Insurance insurance)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TravelInsurance> IInsuranceDomain.GetDutchTravelInsurances()
        {
            throw new NotImplementedException();
        }
    }
}