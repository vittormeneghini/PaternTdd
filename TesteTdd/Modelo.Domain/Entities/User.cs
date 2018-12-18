using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo.Domain.Entities
{

    [Table("User")]
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public string Cpf { get; set; }
    }
}
 