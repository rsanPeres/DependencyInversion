using DependencyInversionPrinciple.DAL.Interfaces;
using DependencyInversionPrinciple.Repository;

namespace DependencyInversionPrinciple.DAL
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
