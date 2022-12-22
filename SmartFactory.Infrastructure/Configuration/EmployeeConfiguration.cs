using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Data.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
           // builder.HasData(CreateEmployees());
        }

        private List<Employee> CreateEmployees()
        {
            var employees = new List<Employee>();

            var employee = new Employee()
            {
                Id=1,
                UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                FirstName= "Петър",
                LastName="Петров",
                Age = 51,
                Address = "ул. Гео Милев 13, София, България",
                PositionId=1,
                Salary=10000.0m
            };

            employees.Add(employee);

             employee = new Employee()
            {
                Id = 2,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                FirstName = "Ангел",
                LastName = "Ангелов",
                Age = 42,
                Address = "кв. Дружба 1 бл. 12 , вх. А, ап. 13, Плевен, България",
                PositionId = 2,
                Salary = 4762.20m
            };

            employees.Add(employee);

            employee = new Employee()
            {
                Id = 3,
                UserId = "25cb202d-9873-432c-b049-f9184c3ce525",
                FirstName = "Иван",
                LastName = "Иванов",
                Age = 48,
                Address = "кв. Дружба 3 бл. 22 , вх. Б, ап. 7, Плевен, България",
                PositionId = 3,
                Salary = 2357.80m
            };

            employees.Add(employee);


            employee = new Employee()
            {
                Id = 4,
                UserId = "58434ec1-2216-4b26-869e-94db0c1f7d09",
                FirstName = "Димитър",
                LastName = "Димитров",
                Age = 34,
                Address = "ул. Търговска 11, Червен бряг, България",
                PositionId = 3,
                Salary = 2027.34m
            };

            employees.Add(employee);

            employee = new Employee()
            {
                Id = 5,
                UserId = "64a268d0-e995-41a0-a640-f9defb7f6f85",
                FirstName = "Валери",
                LastName = "Атанасов",
                Age = 37,
                Address = "ул. Божурица 4, Плевен, България",
                PositionId = 4,
                Salary = 1628.54m
            };

            employees.Add(employee);


            employee = new Employee()
            {
                Id = 6,
                UserId = "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                FirstName = "Христо",
                LastName = "Христов",
                Age = 23,
                Address = "ул. Янко Сакъзов 24, Плевен, България",
                PositionId = 4,
                Salary = 1243.00m
            };

            employees.Add(employee);


            employee = new Employee()
            {
                Id = 7,
                UserId = "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                FirstName = "Цветомир",
                LastName = "Цветанов",
                Age = 35,
                Address = "ул. Шипка 14, Плевен, България",
                PositionId = 5,
                Salary = 1480.00m
            };

            employees.Add(employee);


            employee = new Employee()
            {
                Id = 8,
                UserId = "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                FirstName = "Антон",
                LastName = "Антонов",
                Age = 26,
                Address = "ул. Осогово 2, Плевен, България",
                PositionId = 5,
                Salary = 1343.00m
            };

            employees.Add(employee);

            employee = new Employee()
            {
                Id = 9,
                UserId = "67905730-9c1f-43fb-bf6b-e8dfd5abfd83",
                FirstName = "Надежда",
                LastName = "Георгиева",
                Age = 63,
                Address = "ул. Шипка 2, Плевен, България",
                PositionId = 5,
                Salary = 2362.93m
            };

            employees.Add(employee);
            return employees;
        }
    }
}
