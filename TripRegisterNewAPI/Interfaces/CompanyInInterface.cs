using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface CompanyInInterface
    {
        bool CreateCompanyIn(LoadingCompanyIn loadingCompanyIn);
        bool Save();
    }
}
