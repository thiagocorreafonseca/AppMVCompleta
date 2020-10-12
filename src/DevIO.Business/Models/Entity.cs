using System;

namespace DevIO.Business.Models
{
    public abstract class Entity
    {
        public Entity()
        {
            this.Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}
