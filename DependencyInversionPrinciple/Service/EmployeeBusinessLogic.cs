using DependencyInversionPrinciple.DAL;
using DependencyInversionPrinciple.DAL.Entities;
using DependencyInversionPrinciple.DAL.Interfaces;

namespace DependencyInversionPrinciple.Service
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
