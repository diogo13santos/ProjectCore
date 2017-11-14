using System;
using System.Collections.Generic;

namespace ProjectCore.Domain.Entities
{
    public class Module
    {
        public int Id { get; set; }
        public int Module_Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModification { get; set; }
        public virtual Module SuperModule { get; set; }
        public ICollection<Resource> Resources { get; set; }

        public Module()
        {
            this.Resources = new List<Resource>();
        }
    }
}