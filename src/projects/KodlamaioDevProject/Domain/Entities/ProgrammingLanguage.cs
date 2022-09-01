using System;
using Core.Persistence.Pepositories;

namespace Domain.Entities
{
    public class ProgrammingLanguage : Entity
    {
        
        public string Name { get; set; }

        public ProgrammingLanguage()
        {

        }

        public ProgrammingLanguage(int id,string name) :this()
        {
            Id = id;
            Name = name;
        }
    }
}

