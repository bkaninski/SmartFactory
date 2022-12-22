using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Models.Production;
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
    public class ProductionServiceTests
    {
          private IRepository repo;
          private IProductionService productionService;
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
            public async Task TestAddProduction()
            {
                var repo = new Repository(applicationDbContext);
                productionService = new ProductionService(repo);

                await repo.AddRangeAsync(new List<Production>()
            {
                new Production()
                {
                    Id=1,
                    Date=new DateTime(2022,11,11),
                    TypeOfShift = TypeOfShift.Early,
                    ShiftId = 2,
                    ProductionPreparation = 7,
                    ProcuctionPackaging = 3,
                    StockBeforePacking = 2,
                    AfterShiftBufer = 6
                  
                },
                  
            });

            await repo.SaveChangesAsync();

            var model = new ProductionViewModel()
            {
                Date = new DateTime(2022, 11, 12),
                TypeOfShift = TypeOfShift.Late,
                ShiftId = 5,
                ProductionPreparation = 4,
                ProcuctionPackaging = 3,
                StockBeforePacking = 2,
                AfterShiftBufer = 3
            };

            var model1 = new ProductionViewModel()
            {
                
                Date = new DateTime(2022, 11, 11),
                TypeOfShift = TypeOfShift.Early,
                ShiftId = 2,
                ProductionPreparation = 7,
                ProcuctionPackaging = 7,
                StockBeforePacking = 2,
                AfterShiftBufer = 2
            };

            await productionService.AddProduction(model);
            await productionService.AddProduction(model1);

            var result = await repo.GetByIdAsync<Production>(2);
            var result1 = await repo.GetByIdAsync<Production>(1);
            
            Assert.That(4, Is.EqualTo(result.ProductionPreparation));
            Assert.That(2, Is.EqualTo(result1.AfterShiftBufer));
                
                
            }


        [Test]
        public async Task TestCreate()
        {
            var repo = new Repository(applicationDbContext);
            productionService = new ProductionService(repo);


            var model = new ProductionViewModel()
            {
                Date = new DateTime(2022, 11, 12),
                TypeOfShift = TypeOfShift.Late,
                ShiftId = 5,
                ProductionPreparation = 4,
                ProcuctionPackaging = 3,
                StockBeforePacking = 2,
                AfterShiftBufer = 3
            };

          

            await productionService.Create(model);

            var result = await repo.GetByIdAsync<Production>(1);

            Assert.That(4, Is.EqualTo(result.ProductionPreparation));


        }
        [Test]
        public async Task TestLastWeekProduction()
        {
            var repo = new Repository(applicationDbContext);
            productionService = new ProductionService(repo);

            await repo.AddRangeAsync(new List<Production>()
            {
                new Production()
                {
                    Id=1,
                    Date=new DateTime(2022,12,21),
                    TypeOfShift = TypeOfShift.Early,
                    ShiftId = 1,
                    ProductionPreparation = 1,
                    ProcuctionPackaging = 2,
                    StockBeforePacking = 3,
                    AfterShiftBufer = 4

                },
                new Production()
                {
                    Id=2,
                    Date=new DateTime(2022,12,20),
                    TypeOfShift = TypeOfShift.Early,
                    ShiftId = 2,
                    ProductionPreparation = 5,
                    ProcuctionPackaging = 6,
                    StockBeforePacking = 7,
                    AfterShiftBufer = 8,
                    HasBeenReported =true

                },
                new Production()
                {
                    Id=3,
                    Date=new DateTime(2022,12,19),
                    TypeOfShift = TypeOfShift.Early,
                    ShiftId = 3,
                    ProductionPreparation = 9,
                    ProcuctionPackaging = 10,
                    StockBeforePacking = 11,
                    AfterShiftBufer = 12,
                    HasBeenReported =true
                },

            });

            await repo.SaveChangesAsync();

            var lastWeek =  await productionService.LastWeekProduction();


            Assert.That(2, Is.EqualTo(lastWeek.Count()));
            Assert.That(10, Is.EqualTo(lastWeek.First(l=>l.Id==3).ProductionPackaging));


        }

       
    }
}
