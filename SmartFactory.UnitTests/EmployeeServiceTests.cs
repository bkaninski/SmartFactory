using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Services;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.UnitTests
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        private IRepository repo;
        private UserManager<IdentityUser> userManager;
        private IEmployeeService employeeService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("SmartFactory")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestAllElectricalInMemory()
        {
            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo, userManager);

            await repo.AddRangeAsync(new List<Employee>()
            {
                new Employee(){Id=1,PositionId=3,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=2,PositionId=3,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=3,PositionId=3,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=4,PositionId=2,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m}
            });

            await repo.SaveChangesAsync();
            var employeeColection = await employeeService.AllElectrical();

            Assert.That(3, Is.EqualTo(employeeColection.Count()));
            Assert.That(employeeColection.Any(h => h.Id == 4), Is.False);
        }

        [Test]
        public async Task TestAllOperatorPackInMemory()
        {
            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo, userManager);

            await repo.AddRangeAsync(new List<Employee>()
            {
                new Employee(){Id=1,PositionId=5,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=2,PositionId=5,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=3,PositionId=3,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
            });

            await repo.SaveChangesAsync();
            var employeeColection = await employeeService.AllOperatorPack();

            Assert.That(2, Is.EqualTo(employeeColection.Count()));
            Assert.That(employeeColection.Any(h => h.Id == 3), Is.False);
        }

        [Test]
        public async Task TestAllOperatorPreInMemory()
        {
            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo, userManager);

            await repo.AddRangeAsync(new List<Employee>()
            {
                new Employee(){Id=1,PositionId=4,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=2,PositionId=5,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
                new Employee(){Id=3,PositionId=3,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m},
            });

            await repo.SaveChangesAsync();
            var employeeColection = await employeeService.AllOperatorPre();

            Assert.That(1, Is.EqualTo(employeeColection.Count()));
            Assert.That(employeeColection.Any(h => h.Id == 2), Is.False);
        }

        [Test]
        public async Task TestExists()
        {
            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo, userManager);

            await repo.AddRangeAsync(new List<Employee>()
            {
                new Employee(){Id=1,PositionId=4,UserId="",Address="",Age=3,FirstName="",LastName="",Salary=100.0m}
            });

            await repo.SaveChangesAsync();
            
            Assert.That(await employeeService.Exists(3), Is.False);
            Assert.That(await employeeService.Exists(1), Is.True);
        }

        [Test]
        public async Task TestGetEmployeeId()
        {
            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo, userManager);

            await repo.AddRangeAsync(new List<Employee>()
            {
                new Employee(){Id=1,PositionId=4,UserId="dac252c4-361a-4054-b8aa-68c2871f68b8",Address="",Age=3,FirstName="Ivan",LastName="",Salary=100.0m},
                new Employee(){Id=111,PositionId=4,UserId="ce24e8e9-d19c-4234-ac27-b2372f56441c",Address="",Age=3,FirstName="Atanas",LastName="",Salary=100.0m}
            });

            await repo.SaveChangesAsync();
            var result = await employeeService.GetEmployeeId("dac252c4-361a-4054-b8aa-68c2871f68b8");
            

            Assert.That(result==111, Is.False);
            Assert.That(result == 1, Is.True);
        }

        [Test]
        public async Task GetEmployeePositionId()
        {
            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo, userManager);

            await repo.AddRangeAsync(new List<Employee>()
            {
                
                new Employee(){Id=1,PositionId=4,UserId="",Address="",Age=3,FirstName="Atanas",LastName="",Salary=100.0m}
            });

            await repo.SaveChangesAsync();
            var result = await employeeService.GetEmployeePositionId(1);
            


            Assert.That(result == 2, Is.False);
            Assert.That(result == 4, Is.True);
        }

       


        [TearDown]
        public void TearDown()
        {

        }
    }
}
