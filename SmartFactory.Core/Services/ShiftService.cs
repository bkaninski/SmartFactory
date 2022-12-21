using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Models.Shift;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Services
{
    public class ShiftService : IShiftService
    {
        private readonly IRepository repo;

        public ShiftService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<ShiftQueryModel>> AllShifts(int? month)
        {

            var monthCompare = DateTime.UtcNow;
            
            if (month == 1)
            {
                 monthCompare = DateTime.UtcNow.AddMonths(1);
                
            }
            else if (month == -1)
            {
                 monthCompare = DateTime.UtcNow.AddMonths(-1);
                
         }

            var shifts = await repo.AllReadonly<Shift>()
           .Where(s => s.Date.Month == monthCompare.Month)
          .Select(s => new ShiftQueryModel()
          {
              Id = s.Id,
              Date=s.Date,
              Electrician = string.Concat(s.Electrician.FirstName, " ", s.Electrician.LastName),
              OperatorPreparation = string.Concat(s.OperatorPreparation.FirstName, " ", s.OperatorPreparation.LastName),
              OperatorPackaging = string.Concat(s.OperatorPackaging.FirstName, " ", s.OperatorPackaging.LastName),
              TypeOfShift = s.TypeOfShift.ToString(),

          })
          .ToListAsync();


            return shifts;
        }

        public async Task Create(ShiftAddModel model)
        {
           
            if (model.TypeOfShift.ToString() == "Early")
            {
                TimeSpan time = new TimeSpan(6, 0, 0);
                DateTime date = model.Date;
                date = date + time;
                model.Date=date;
            }
            else
            {
                TimeSpan time = new TimeSpan(14, 0, 0);
                DateTime date = model.Date;
                date = date + time;
                model.Date = date;
            }

            var shift = new Shift()
            {

                Date = model.Date,
                TypeOfShift = model.TypeOfShift,
                ElectricianId = model.ElectricianId,
                OperatorPreparationId = model.OperatorPreparationId,
                OperatorPackagingId = model.OperatorPackagingId,

            };

            await repo.AddAsync(shift);
            await repo.SaveChangesAsync();

            
        }

        public async Task Edit(int shiftId, ShiftEditModel model)
        {
            var shift = await repo.GetByIdAsync<Shift>(shiftId);

            shift.TypeOfShift = model.TypeOfShift;
            shift.ElectricianId = model.ElectricianId;
            shift.OperatorPackagingId = model.OperatorPackagingId;
            shift.OperatorPreparationId = model.OperatorPreparationId;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Shift>()
                .AnyAsync(e => e.Id == id);
        }

        public async Task<bool> InWorkToday(int employeeId, DateTime date)
        {
            var shiftToday = await repo.AllReadonly<Shift>()
                .Where(s => s.Date.Year == date.Year)
                .Where(s=>s.Date.Month==date.Month)
                .Where(s=>s.Date.Day==date.Day)
                .Select(s=> new Shift()
                {
                    Date= s.Date,
                    ElectricianId =s.ElectricianId,
                    OperatorPackagingId = s.OperatorPackagingId,
                    OperatorPreparationId = s.OperatorPreparationId
                })
                .ToListAsync();

            return shiftToday.Any(e => e.ElectricianId == employeeId || e.OperatorPackagingId == employeeId || e.OperatorPreparationId == employeeId);
        }

        public async Task<ShiftEditModel> ShiftDetailsById(int id)
        {
            return await repo.AllReadonly<Shift>()
                 .Where(e => e.Id == id)
                 .Select(e => new ShiftEditModel()
                 {
                     Id = e.Id,
                     Date = e.Date,
                     TypeOfShift= e.TypeOfShift,
                     ElectricianId=e.ElectricianId,
                     OperatorPackagingId=e.OperatorPackagingId,
                     OperatorPreparationId = e.OperatorPreparationId

                 })
                 .FirstAsync();
        }

        public async Task<bool> ShiftExistByDateAndType(DateTime date, string type)
        {
            var shiftToday = await repo.AllReadonly<Shift>()
               .Where(s => s.Date.Year == date.Year)
               .Where(s => s.Date.Month == date.Month)
               .Where(s => s.Date.Day == date.Day)
               .Select(s => new Shift()
               {
                   Date = s.Date,
                   TypeOfShift = s.TypeOfShift
                   
               })
               .ToListAsync();

            return shiftToday.Any(e => e.TypeOfShift.ToString() == type);
        }

        public async Task<int?> ShiftInWorkId()
        {
            var hour = DateTime.Now.Hour;
            if (hour>=6 && hour<14)
            {
                return await repo.AllReadonly<Shift>()
               .Where(s => s.Date.Date == DateTime.Now.Date)
               .Where(s => s.TypeOfShift==TypeOfShift.Early)
               .Select(s => s.Id)
                .FirstOrDefaultAsync();
            }
            else if (hour>=14 && hour<22)
            {
                return await repo.AllReadonly<Shift>()
               .Where(s => s.Date.Date == DateTime.Now.Date)
               .Where(s => s.TypeOfShift == TypeOfShift.Late)
               .Select(s => s.Id)
                .FirstOrDefaultAsync();

            }
            else
            {
                return null;
            }



          
        }

        public async Task<Shift> ShiftInWork(int shiftId)
        {
            return await repo.AllReadonly<Shift>()
                .Where(s => s.Id == shiftId)
                .Select(s => new Shift()
                {
                    Id=s.Id,
                    Date=s.Date,
                    TypeOfShift=s.TypeOfShift,
                    ElectricianId=s.ElectricianId,
                    OperatorPackagingId=s.OperatorPackagingId,
                    OperatorPreparationId=s.OperatorPreparationId
                })
                .FirstAsync();
        }
    }
}
