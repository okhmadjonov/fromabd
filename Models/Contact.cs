﻿namespace CrudMVCByKING.Models
{
    public class Contact : IEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public int? WhenCall { get; set; }
        public Guid? UserId{ get; set;}
    }
}
