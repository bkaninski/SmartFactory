using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Position;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Services
{
    public class CareerService : ICareerService
    {
        private readonly IRepository repo;

        public CareerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<CareerAllModel>> AllCareer()
        {
            return await repo.AllReadonly<Career>()
               .OrderBy(c => c.Id)
               .Select(c => new CareerAllModel()
               {
                   Id = c.Id,
                   DateOpen = c.DataOpen.ToShortDateString(),
                   DateClose = c.DataOpen.AddDays(c.DaysActive).ToShortDateString(),
                   Position = c.Position.Title,
                   
               })
               .ToListAsync();
        }
    }
}
