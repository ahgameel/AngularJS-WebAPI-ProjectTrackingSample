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
    public class MemberRepository:IMemberRepository
    {
        ProjectTrackingContext _context = new ProjectTrackingContext();
        public IEnumerable<Member> GetAll
        {
            get {return _context.Members; }
        }

        public IEnumerable<Member> AllIncluding(params System.Linq.Expressions.Expression<Func<Member, object>>[] includeProperties)
        {
            return includeProperties.Aggregate<Expression<Func<Member, object>>, IQueryable<Member>>(_context.Members, (current, includeProperty) => current.Include(includeProperty));
        }

        public Member Find(int id)
        {
            return _context.Members.Find(id);
        }

        public void InsertOrUpdate(Member entity)
        {
            if (entity.MemberID == default(int))
            {
                // New entity
                _context.Members.Add(entity);
            }
            else
            {
                // Existing entity
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var member = _context.Members.Find(id);
            _context.Members.Remove(member);
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
