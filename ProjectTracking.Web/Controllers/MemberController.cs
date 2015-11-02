using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectTracking.Service;
using ProjectTracking.Model;

namespace ProjectTracking.Web.Controllers
{
    public class MemberController : ApiController
    {
        readonly MemberService _memberService;

        public MemberController()
        {
            _memberService=new MemberService();
        }
            // GET api/<controller>
        public IEnumerable<Member> Get()
        {
            return _memberService.GetallMembers();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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