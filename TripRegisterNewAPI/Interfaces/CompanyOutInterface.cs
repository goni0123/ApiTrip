using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface CompanyOutInterface
    {
        bool CreateCompanyIn(LoadingCompanyIn loadingCompanyIn);
        bool Save();
    }
}
