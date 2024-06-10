using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssignment
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
