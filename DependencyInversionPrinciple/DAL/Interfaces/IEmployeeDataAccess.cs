using DependencyInversionPrinciple.DAL.Entities;

namespace DependencyInversionPrinciple.DAL.Interfaces
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
