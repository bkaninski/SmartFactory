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

        public async Task<int> Create(PositionAddModel model)
        {
            var position = new Position()
            {
               Title=model.Title,
               Description = model.Description
            };


            await repo.AddAsync(position);
            await repo.SaveChangesAsync();

            return position.Id;
        }

        public async Task<bool> PositionExists(int positionId)
        {
            return await repo.AllReadonly<Position>()
                .AnyAsync(p => p.Id == positionId);
        }
    }
}
