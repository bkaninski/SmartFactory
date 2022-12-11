using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Models.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Contracts
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionModel>> AllPositions();

        Task<bool> PositionExists(int positionId);

        Task<IEnumerable<string>> AllPositionsNames();

        Task<int> Create(PositionAddModel model);

    }
}
