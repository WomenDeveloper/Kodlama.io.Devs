using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Persistence.Pepositories
{
    public class Entity
    {
        
        public int Id { get; set; }

        public Entity()
        {
        }

        public Entity(int id) : this()
        {
            Id = id;
        }
    }
}

