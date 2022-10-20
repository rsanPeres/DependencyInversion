﻿using DependencyInversionPrinciple.DAL.Entities;
using DependencyInversionPrinciple.DAL.Interfaces;

namespace DependencyInversionPrinciple.Repository
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
