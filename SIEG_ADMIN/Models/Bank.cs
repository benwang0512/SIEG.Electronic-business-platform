﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SIEG_ADMIN.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Member = new HashSet<Member>();
        }

        public string BankCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}