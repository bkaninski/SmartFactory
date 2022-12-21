using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Models.Production;
using SmartFactory.Core.Models.Shift;
using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Contracts
{
    public interface IShiftService

    {
        Task<IEnumerable<ShiftQueryModel>> AllShifts(int? month);

        Task Create(ShiftAddModel model);

        Task Edit(int shiftId, ShiftEditModel model);

        Task<bool> Exists(int id);
        Task<ShiftEditModel> ShiftDetailsById(int id);

        Task<int?> ShiftInWorkId();
        Task<Shift> ShiftInWork(int shiftId);

        Task<bool> InWorkToday(int employeeId,DateTime date);

        Task<bool> ShiftExistByDateAndType(DateTime date, string type);

    }
}
