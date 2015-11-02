using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using ProjectTracking.Data.Repositories;
using ProjectTracking.Model;

namespace ProjectTracking.Web.Controllers
{

    public class ProjectController : ApiController
    {
        private ProjectRepository projectRepository;
      
        // GET api/<controller>/5
        // get all projects 
        public IEnumerable<Project> GetProjects()
        {  
            projectRepository=new ProjectRepository();
            var projects = projectRepository.GetAll.ToList();
            return projects;
        }
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}