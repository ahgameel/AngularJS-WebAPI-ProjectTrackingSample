using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ProjectTracking.Model;

namespace ProjectTracking.Data
{
    public partial class ProjectTrackingContext : DbContext
    {
        public ProjectTrackingContext()
            : base("name=ProjectTrackingContext")
        {

        }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Member> Members { get; set; }
    }
}
