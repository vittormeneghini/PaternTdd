using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual long Id { get; set; }
    }
}
