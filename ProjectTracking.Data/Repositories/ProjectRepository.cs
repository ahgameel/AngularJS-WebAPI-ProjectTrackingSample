using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using ProjectTracking.Model;
using ProjectTracking.Data.Infrastructure;

namespace ProjectTracking.Data.Repositories
{
    public class ProjectRepository:IProjectRepository
    {
        ProjectTrackingContext _context = new ProjectTrackingContext();
        public IEnumerable<Project> GetAll
        {
            get { return _context.Projects; }
        }

        public IEnumerable<Project> AllIncluding(params System.Linq.Expressions.Expression<Func<Project, object>>[] includeProperties)
        {
            return includeProperties.Aggregate<Expression<Func<Project, object>>, IQueryable<Project>>(_context.Projects, (current, includeProperty) => current.Include(includeProperty));
        }

        public Project Find(int id)
        {
            return _context.Projects.Find(id);
        }

        public void InsertOrUpdate(Project entity)
        {
            if (entity.ProjectID == default(int))
            {
                // New entity
                _context.Projects.Add(entity);
            }
            else
            {
                // Existing entity
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var project = _context.Projects.Find(id);
            _context.Projects.Remove(project);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
