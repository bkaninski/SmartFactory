using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Models.Shift;
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
    public class ShiftServiceTests
    {
          private IRepository repo;
          private IShiftService shiftService;
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
            public async Task TestAllShifts()
            {
                var repo = new Repository(applicationDbContext);
                shiftService = new ShiftService(repo);

                await repo.AddRangeAsync(new List<Shift>()
            {
                new Shift()
                {
                    Id=1,
                    Date=new DateTime(2022,11,11),
                    TypeOfShift = TypeOfShift.Early,
                    Electrician = new Employee(){ Address = "", FirstName = "", LastName = "", UserId = "" } , 
                    OperatorPackaging = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" }  ,
                    OperatorPreparation = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" } 
                },
                  new Shift()
                {
                    Id=2,
                    Date=new DateTime(2022,12,12),
                    TypeOfShift = TypeOfShift.Early,
                    Electrician = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPackaging = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPreparation = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" } 
                },
                    new Shift()
                {
                    Id=3,
                    Date=new DateTime(2023,01,01),
                    TypeOfShift = TypeOfShift.Early,
                    Electrician = new Employee(){ Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPackaging = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPreparation = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" }
                },
            });

            await repo.SaveChangesAsync();

            var result1 = await shiftService.AllShifts(null);
            var result2 = await shiftService.AllShifts(1);
            var result3 = await shiftService.AllShifts(-1);


                Assert.That(1, Is.EqualTo( result1.Count()));
                Assert.That(1, Is.EqualTo( result2.Count()));
                Assert.That(1, Is.EqualTo( result3.Count()));
                Assert.That(2, Is.EqualTo( result1.First().Id));
                
            }

        [Test]
        public async Task TestCreate()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await shiftService.Create(new ShiftAddModel()
            {
                Date = new DateTime(2022, 12, 22),
                TypeOfShift = TypeOfShift.Early,
                ElectricianId = 1,
                OperatorPackagingId = 2,
                OperatorPreparationId = 3,
            });

            Shift shift = await repo.GetByIdAsync<Shift>(1);

            Assert.That(1, Is.EqualTo(shift.ElectricianId));
            Assert.That("22.12.2022", Is.EqualTo(shift.Date.ToString("dd/MM/yyyy")));
            
        }

        [Test]
        public async Task TestEdit()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                new Shift()
                {
                    Id=1,
                    Date=new DateTime(2022,11,11) + new TimeSpan(6,0,0),
                    TypeOfShift = TypeOfShift.Early,
                    ElectricianId = 1 ,
                    OperatorPackagingId = 2 ,
                    OperatorPreparationId =3
                }
            });

            await repo.SaveChangesAsync();

            await shiftService.Edit(1, new ShiftEditModel()
            {
                ElectricianId = 7
            });

            Shift shift = await repo.GetByIdAsync<Shift>(1);

            Assert.That(7, Is.EqualTo(shift.ElectricianId));
        }


        [Test]
        public async Task TestExists()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                new Shift()
                {
                    Id=1,
                    Date=new DateTime(2022,11,11),
                    TypeOfShift = TypeOfShift.Early,
                    Electrician = new Employee(){ Address = "", FirstName = "", LastName = "", UserId = "" } ,
                    OperatorPackaging = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" }  ,
                    OperatorPreparation = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" }
                },
                  new Shift()
                {
                    Id=2,
                    Date=new DateTime(2022,12,12),
                    TypeOfShift = TypeOfShift.Early,
                    Electrician = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPackaging = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPreparation = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" }
                },
                    new Shift()
                {
                    Id=3,
                    Date=new DateTime(2023,01,01),
                    TypeOfShift = TypeOfShift.Early,
                    Electrician = new Employee(){ Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPackaging = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" },
                    OperatorPreparation = new Employee() { Address = "", FirstName = "", LastName = "", UserId = "" }
                },
            });

            await repo.SaveChangesAsync();

            Assert.That(await shiftService.Exists(1), Is.True);
            Assert.That(await shiftService.Exists(3), Is.True);
            Assert.That(await shiftService.Exists(4), Is.False);
        }

        [Test]
        public async Task TestInWorkToday()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                new Shift()
                {
                    Id=1,
                    Date=new DateTime(2022,11,11),
                    TypeOfShift = TypeOfShift.Early,
                    ElectricianId = 1 ,
                    OperatorPackagingId = 2  ,
                    OperatorPreparationId = 3
                }
            });

            await repo.SaveChangesAsync();



            Assert.That(await shiftService.InWorkToday(1, new DateTime(2022, 11, 11)), Is.True);
            Assert.That(await shiftService.InWorkToday(1, new DateTime(2022, 11, 12)), Is.False);
   
        }

        [Test]
        public async Task TestShiftDetailsById()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                    new Shift()
                {
                    Id=3,
                    Date=new DateTime(2023,01,01),
                    TypeOfShift = TypeOfShift.Early,
                    ElectricianId = 7 ,
                    OperatorPackagingId = 8  ,
                    OperatorPreparationId = 9
                },
            });

            await repo.SaveChangesAsync();

            var shift = await shiftService.ShiftDetailsById(3);

            Assert.That(7, Is.EqualTo(shift.ElectricianId));

        }

        [Test]
        public async Task TestShiftExistByDateAndType()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                    new Shift()
                {
                    Id=3,
                    Date=new DateTime(2023,01,01),
                    TypeOfShift = TypeOfShift.Early,
                    ElectricianId = 7 ,
                    OperatorPackagingId = 8  ,
                    OperatorPreparationId = 9
                },
            });

            await repo.SaveChangesAsync();

            Assert.That(await shiftService.ShiftExistByDateAndType(new DateTime(2023, 01, 01), "Early"), Is.True);
            Assert.That(await shiftService.ShiftExistByDateAndType(new DateTime(2023, 01, 01), "Late"), Is.False);

        }

        [Test]
        public async Task TestShiftInWorkId()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                    new Shift()
                {
                    Id=3,
                    Date=new DateTime(2023,01,01),
                    TypeOfShift = TypeOfShift.Early,
                    ElectricianId = 7 ,
                    OperatorPackagingId = 8  ,
                    OperatorPreparationId = 9
                },
                new Shift()
                {
                    Id=2,
                    Date= DateTime.Now,
                    TypeOfShift = TypeOfShift.Late,
                    ElectricianId = 7 ,
                    OperatorPackagingId = 8  ,
                    OperatorPreparationId = 9
                },
            });

            await repo.SaveChangesAsync();

            Assert.That(2,Is.EqualTo(await shiftService.ShiftInWorkId()));

        }

        [Test]
        public async Task TestShiftInWork()
        {
            var repo = new Repository(applicationDbContext);
            shiftService = new ShiftService(repo);

            await repo.AddRangeAsync(new List<Shift>()
            {
                new Shift()
                {
                    Id=2,
                    Date= DateTime.Now,
                    TypeOfShift = TypeOfShift.Late,
                    ElectricianId = 7 ,
                    OperatorPackagingId = 8  ,
                    OperatorPreparationId = 9
                },
            });

            await repo.SaveChangesAsync();

            var shift = await shiftService.ShiftInWork(2);

            Assert.That(9, Is.EqualTo(shift.OperatorPreparationId));

        }
    }
}
