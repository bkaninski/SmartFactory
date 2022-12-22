using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
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
    public class PositionServiceTests
    {
          private IRepository repo;
          private IPositionService positionService;
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
            public async Task TestAllPositions()
            {
                var repo = new Repository(applicationDbContext);
                positionService = new PositionService(repo);

                await repo.AddRangeAsync(new List<Position>()
            {
                new Position(){Id=1,Title = "Title1",Description="Description1"},
                new Position(){Id=2,Title = "Title2",Description="Description2"},
                new Position(){Id=21,Title = "Title21",Description="Description21"},
               
            });

                await repo.SaveChangesAsync();
                var positionColection = await positionService.AllPositions();

                Assert.That(3, Is.EqualTo(positionColection.Count()));
                Assert.That(positionColection.Any(h => h.Id == 4), Is.False);
                Assert.That("Title21", Is.EqualTo(positionColection.First(h => h.Id == 21).Title));
            }

        [Test]
        public async Task TestAllPositionsNames()
        {
            var repo = new Repository(applicationDbContext);
            positionService = new PositionService(repo);

            await repo.AddRangeAsync(new List<Position>()
            {
                new Position(){Id=1,Title = "Title1",Description="Description1"},
                new Position(){Id=2,Title = "Title2",Description="Description2"},
                new Position(){Id=21,Title = "Title21",Description="Description21"},

            });

            await repo.SaveChangesAsync();
            var positionColection = await positionService.AllPositionsNames();

            Assert.That(3, Is.EqualTo(positionColection.Count()));
            Assert.That(positionColection.Any(h => h == "Title2"),Is.True);
        }

        [Test]
        public async Task TestCreate()
        {
            var repo = new Repository(applicationDbContext);
            positionService = new PositionService(repo);

            var positionId = await positionService.Create(new Core.Models.Position.PositionQueryModel()
            {
                Title= "Title position",
                Description = "Description position"
            });

            Assert.That(1, Is.EqualTo(positionId));
        }


        [Test]
        public async Task TestEdit()
        {
            var repo = new Repository(applicationDbContext);
            positionService = new PositionService(repo);

            await repo.AddAsync(new Position()
            {
                Id = 1,
                Title="Title position",
                Description = "Description position"
            });

            await repo.SaveChangesAsync();

            await positionService.Edit(1, new PositionEditModel()
            {
                
                Title = "Edit position",
                Description = "Description position"
            });

            var position = await repo.GetByIdAsync<Position>(1);

            Assert.That(position.Title, Is.EqualTo("Edit position"));
        }

        [Test]
        public async Task TestPositionDetailsById()
        {
            var repo = new Repository(applicationDbContext);
            positionService = new PositionService(repo);

            await repo.AddRangeAsync(new List<Position>()
            {
                new Position(){Id=1,Title = "Title1",Description="Description1"},
                new Position(){Id=2,Title = "Title2",Description="Description2"},
                new Position(){Id=21,Title = "Title21",Description="Description21"},

            });

            await repo.SaveChangesAsync();
            var position = await positionService.PositionDetailsById(2);

            Assert.That("Description2", Is.EqualTo(position.Description));
            Assert.That(2, Is.EqualTo(position.Id));
        }

        [Test]
        public async Task TestPositionExistsById()
        {
            var repo = new Repository(applicationDbContext);
            positionService = new PositionService(repo);

            await repo.AddRangeAsync(new List<Position>()
            {
                new Position(){Id=1,Title = "Title1",Description="Description1"},
                new Position(){Id=2,Title = "Title2",Description="Description2"},
                new Position(){Id=21,Title = "Title21",Description="Description21"},

            });

            await repo.SaveChangesAsync();
            

            Assert.That(await positionService.PositionExistsById(2), Is.True);
            Assert.That(await positionService.PositionExistsById(6), Is.False);
        }

        [Test]
        public async Task TestPositionExistsByTitle()
        {
            var repo = new Repository(applicationDbContext);
            positionService = new PositionService(repo);

            await repo.AddRangeAsync(new List<Position>()
            {
                new Position(){Id=1,Title = "Title1",Description="Description1"},
                new Position(){Id=2,Title = "Title2",Description="Description2"},
                new Position(){Id=21,Title = "Title21",Description="Description21"},

            });

            await repo.SaveChangesAsync();
            

            Assert.That(await positionService.PositionExistsByTitle("Title1"), Is.True);
            Assert.That(await positionService.PositionExistsByTitle("Title2 1"), Is.False);
        }

    }
}
