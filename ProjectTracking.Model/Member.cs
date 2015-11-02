using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracking.Model
{
    public partial class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Title { get; set; }
        public int ProjectID { get; set; }
    }
}
