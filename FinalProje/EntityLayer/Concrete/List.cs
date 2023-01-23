using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        public string ListValue { get; set; }
        public bool ListStatus { get; set; }

        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}
