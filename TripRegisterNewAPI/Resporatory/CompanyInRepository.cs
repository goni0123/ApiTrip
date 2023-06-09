using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class CompanyInRepository:CompanyInInterface
    {
        private readonly AppDBContext _context;
        public CompanyInRepository(AppDBContext context)
        {
            _context = context;
        }
        public bool CreateCompanyIn(LoadingCompanyIn loadingCompanyIn)
        {
            _context.Add(loadingCompanyIn);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
