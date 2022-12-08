using SmartFactory.Core.Models.Production;
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
    }
}
