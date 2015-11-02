using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracking.Model;


namespace ProjectTracking.Data.Infrastructure
{

    public interface IProjectRepository : IRepository<Project>
    {

    }
    public interface IMemberRepository : IRepository<Member>
    {

    }
 
 
}

