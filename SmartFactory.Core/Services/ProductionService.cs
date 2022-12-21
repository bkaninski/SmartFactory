using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Production;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Services
{
    public class ProductionService : IProductionService
    {
        private readonly IRepository repo;

        public ProductionService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddProduction(ProductionViewModel model)
        {
            int productionId = await repo.AllReadonly<Production>()
                .Where(p => p.ShiftId == model.ShiftId)
                .Select(p => p.Id)
                .FirstOrDefaultAsync();

            

            if (productionId == null)
            {
                var production = new Production()
                {
                    Date = model.Date,
                    ShiftId = model.ShiftId,
                    TypeOfShift = model.TypeOfShift,
                    ProductionPreparation = model.ProductionPreparation,
                    ProcuctionPackaging = model.ProcuctionPackaging,
                    Coment = model.ComentDetails?.Substring(0, 10),
                    ComentDetails = model.ComentDetails,
                    HasBeenReported = false,
                    AfterShiftBufer = model.AfterShiftBufer
                };

                if (model.TypeOfShift.ToString() == "Early")
                {
                    TimeSpan time = new TimeSpan(6, 0, 0);
                    DateTime date = model.Date;
                    date = date + time;
                    production.Date = date;
                }
                else
                {
                    TimeSpan time = new TimeSpan(14, 0, 0);
                    DateTime date = model.Date;
                    date = date + time;
                    production.Date = date;
                }
                await repo.AddAsync(production);
                await repo.SaveChangesAsync();
            }
            var existShiftProduction = await repo.GetByIdAsync<Production>(productionId);
            existShiftProduction.ProductionPreparation = model.ProductionPreparation;
            existShiftProduction.ProcuctionPackaging = model.ProcuctionPackaging;
            existShiftProduction.AfterShiftBufer = model.AfterShiftBufer;

           await repo.SaveChangesAsync();

        }

      

        public async Task Create(ProductionViewModel model)
        {
            var production = new Production()
            {
               Date = model.Date,
               ShiftId=model.ShiftId,
               TypeOfShift=model.TypeOfShift,               
               ProductionPreparation=model.ProductionPreparation,
               ProcuctionPackaging = model.ProcuctionPackaging,
               Coment = model.ComentDetails?.Substring(0,10),
               ComentDetails = model.ComentDetails,
               HasBeenReported = true,
               AfterShiftBufer=model.AfterShiftBufer
            };
            if (model.TypeOfShift.ToString() == "Early")
            {
                TimeSpan time = new TimeSpan(6, 0, 0);
                DateTime date = model.Date;
                date = date + time;
                production.Date = date;
            }
            else
            {
                TimeSpan time = new TimeSpan(14, 0, 0);
                DateTime date = model.Date;
                date = date + time;
                production.Date = date;
            }


            await repo.AddAsync(production);
            await repo.SaveChangesAsync();

        }

        public async Task<IEnumerable<LastWeekProductionQueryModel>> LastWeekProduction()
        {
            var dateWeekAgo = DateTime.UtcNow.Date.AddDays(-7);

            return await repo.AllReadonly<Production>()
                .Where(p=>p.Date>dateWeekAgo)
                .Where(p=>p.HasBeenReported==true)
                .OrderByDescending(p=>p.Id)
                .Take(14)
                .Select(p=> new LastWeekProductionQueryModel() 
                {
                    Id = p.Id,
                    Date=p.Date.ToShortDateString(),
                    TypeOfShift=p.TypeOfShift,
                    ProductionPreparation= p.ProductionPreparation,
                    StockBeforePacking = p.StockBeforePacking,
                    ProductionPackaging= p.ProcuctionPackaging,
                    Coment=p.Coment==null?"Няма коментар за смяната":p.Coment,
                    StockBeforePackingAfter = p.AfterShiftBufer
                })
                
                .ToListAsync();
        }

        public async Task<int> StockBeforePack()
        {
            return await repo.AllReadonly<Production>()
                .OrderByDescending(p => p.Id)
                .Take(1)
                .Select(p => p.AfterShiftBufer)
                .FirstAsync();


                
        }

        public async Task<ProductionViewModel> View(int shiftId)
        {
            var model= await repo.AllReadonly<Shift>()
                .Where(s => s.Id == shiftId)
                .Include(e=>e.Electrician)
                .Include(e => e.OperatorPackaging)
                .Include(e => e.OperatorPreparation)
                .Select(s => new ProductionViewModel()
                {
                    Date=s.Date,
                    ShiftId=s.Id,
                    TypeOfShift = s.TypeOfShift,
                    Electrical = String.Concat(s.Electrician.FirstName, " ", s.Electrician.LastName),
                    OperatorPackaging = String.Concat(s.OperatorPackaging.FirstName, " ", s.OperatorPackaging.LastName),
                    OperatorPreparation = String.Concat(s.OperatorPreparation.FirstName, " ", s.OperatorPreparation.LastName),
                })
                .FirstAsync();

            var productionShift = await repo.AllReadonly<Production>()
                .Where(p=>p.Date.Year==DateTime.Now.Year)
                .Where(p=>p.Date.Month==DateTime.Now.Month)
                .Where(p=>p.Date.Day==DateTime.Now.Day)
                .Where(p=>p.TypeOfShift==model.TypeOfShift)
                .Select(s => new ProductionViewModel()
                {
                    ProcuctionPackaging=s.ProcuctionPackaging,
                    ProductionPreparation=s.ProductionPreparation,
                    ComentDetails=s.ComentDetails,
                    AfterShiftBufer=s.AfterShiftBufer
                })
                .FirstOrDefaultAsync();

            if (productionShift!=null)
            {
                model.ProductionPreparation = productionShift.ProductionPreparation;
                model.ProcuctionPackaging = productionShift.ProcuctionPackaging;
                model.ComentDetails = productionShift.ComentDetails;
                model.AfterShiftBufer = productionShift.AfterShiftBufer;
            }

            return model;
        }


    }
}
