﻿using System;
using System.Collections.Generic;

namespace ProjectCore.Domain.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Module_Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModification { get; set; }
        public virtual Module Module { get; set; }
        public ICollection<Privilege> Privileges { get; set; }

        public Resource()
        {
            this.Privileges = new List<Privilege>();
        }
    }
}