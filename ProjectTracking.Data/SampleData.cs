using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracking.Model;
using ProjectTracking.Data;

namespace ProjectTracking.Data
{
    public  class SampleData:DropCreateDatabaseIfModelChanges<ProjectTrackingContext>
    {
        protected override void Seed(ProjectTrackingContext context)
        {
            new List<Project>
            {
                new Project { Name = "Erp Project",CreatedDate =DateTime.Parse("2015-04-25"),StartDate = DateTime.Parse("2015-04-28"),EndDate = DateTime.Parse("2015-06-25")},
                new Project { Name = "CRM Project",CreatedDate =DateTime.Parse("2015-04-29"),StartDate = DateTime.Parse("2015-05-01"),EndDate =DateTime.Parse("2015-07-25")},
            

            }.ForEach(m => context.Projects.Add(m));
            context.SaveChanges();
        }

    }
}
