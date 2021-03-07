using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Category
    {
        [Key]

        public int Id { get; set; }

        [StringLength(100)]

        public string Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
