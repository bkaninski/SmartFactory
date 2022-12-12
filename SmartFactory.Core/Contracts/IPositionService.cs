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

        Task<bool> PositionExistsById(int positionId);

        Task<bool> PositionExistsByTitle(string positionTitle);

        Task<IEnumerable<string>> AllPositionsNames();

        Task<int> Create(PositionQueryModel model);

        Task Edit(int positionId, PositionEditModel model);
        Task<PositionEditModel> PositionDetailsById(int id);


    }
}
