using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Production
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]

        public string Name { get; set; }

        [StringLength(100)]

        public string Country { get; set; }

        [StringLength(50)]

        public string Year { get; set; }

        public virtual ICollection<Production> Productions { get; set; }
    }
}
