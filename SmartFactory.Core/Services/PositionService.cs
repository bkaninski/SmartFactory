using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
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
    public class PositionService : IPositionService
    {

        private readonly IRepository repo;

        public PositionService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<PositionModel>> AllPositions()
        {
            return await repo.AllReadonly<Position>()
                .OrderBy(p => p.Title)
                .Select(p => new PositionModel()
                {
                    Id = p.Id,
                    Title = p.Title
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllPositionsNames()
        {
            return await repo.AllReadonly<Position>()
                .Select(p => p.Title)
                .Distinct()
                .ToListAsync();
        }

        public async Task<int> Create(PositionQueryModel model)
        {
            
            var position = new Position()
            {
               Title=model.Title,
               Description = model.Description,
               PositionType = model.PositionType
            };


            await repo.AddAsync(position);
            await repo.SaveChangesAsync();

            return position.Id;
        }

        public async Task Edit(int positionId, PositionEditModel model)
        {
            var position = await repo.GetByIdAsync<Position>(positionId);

            position.Title = model.Title;
            position.Description = model.Description;
            position.PositionType = model.PositionType;

            await repo.SaveChangesAsync();
        }

        public async Task<PositionEditModel> PositionDetailsById(int id)
        {
            return await repo.AllReadonly<Position>()
                .Where(p => p.Id == id)
                .Select(p => new PositionEditModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    PositionType = p.PositionType
                    
                })
                .FirstAsync();
        }

        public async Task<bool> PositionExistsById(int positionId)
        {
            return await repo.AllReadonly<Position>()
                .AnyAsync(p => p.Id == positionId);
        }

        

        public async Task<bool> PositionExistsByTitle(string positionTitle)
        {
            return await repo.AllReadonly<Position>()
              .AnyAsync(p => p.Title == positionTitle);
        }
    }
}
