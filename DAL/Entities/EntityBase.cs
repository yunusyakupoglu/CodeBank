using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EntityBase : IEntity
    {
        [Key]
        public int Id { get; set; }
        public bool isArchived { get; set; }
    }
}
