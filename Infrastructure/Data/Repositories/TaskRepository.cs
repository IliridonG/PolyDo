using Domain.Entities.Tasks.ValueObjects;
using Domain.Interfaces.TaskRepository;
using Microsoft.EntityFrameworkCore;
using TaskEntity = Domain.Entities.Tasks.Task;

namespace Infrastructure.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly PolyDoContext _context;

        public TaskRepository(PolyDoContext context)
        {
            _context = context; 
        }

        public async Task AddAsync(TaskEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TaskId id)
        {
            var task = await _context.Tasks.Where(c => c.Id == id).FirstOrDefaultAsync();
            _context.Remove(task);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TaskEntity>> GetAllAsync()
        {
            return await _context.Tasks.AsNoTracking().ToListAsync();
        }

        public async Task<TaskEntity> GetByIdAsync(TaskId id)
        {
            return await _context.Tasks.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(TaskEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
