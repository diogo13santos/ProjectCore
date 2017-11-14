using System;

namespace ProjectCore.Domain.Entities
{
    public class Privilege
    {
        public int Id { get; set; }
        public int Roles_Id { get; set; }
        public int Resources_Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModification { get; set; }
        public virtual Resource ResourcePrivilege { get; set; }
    }
}