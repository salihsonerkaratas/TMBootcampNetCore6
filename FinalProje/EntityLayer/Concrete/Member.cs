﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberPassword { get; set; }
        public string MemberMail { get; set; }
        public bool MemberStatus { get; set; }

        public List<List> Lists { get; set; }
    }
}
