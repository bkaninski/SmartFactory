using SmartFactory.Core.Models.Production;
using SmartFactory.Core.Models.Shift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Contracts
{
    public interface IProductionService
    {
        Task <IEnumerable<LastWeekProductionQueryModel>> LastWeekProduction();

        Task<ProductionViewModel> View(int shiftId);
        Task Create(ProductionViewModel model);

        Task<int> StockBeforePack();

        Task AddProduction(ProductionViewModel model);
    }
}
