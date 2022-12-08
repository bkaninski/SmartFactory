using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
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

        public async Task<IEnumerable<LastWeekProductionQueryModel>> LastWeekProduction()
        {
            return await repo.AllReadonly<Production>()
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
                })
                
                .ToListAsync();
        }
    }
}
