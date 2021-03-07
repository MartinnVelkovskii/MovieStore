using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(350)]
        public string Title { get; set; }

        [StringLength(350)]

        public string ProducerName { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

        public DateTime YearofIssue { get; set; }
        public int LengthOfMovie { get; set; }

        [StringLength(350)]

        public string ProductionName { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public int UserId { get; set; }

        [StringLength(150)]

        public string Genre { get; set; }

        [StringLength(150)]
        public string CategoryName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }

        [StringLength(50)]
        public string MovieType { get; set; }

        [StringLength(500)]

        public string Description { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(50)]
        public string Country { get; set; }
        public int Edition { get; set; }

        [StringLength(50)]
        public string Dimension { get; set; }

        [StringLength(50)]
        public string Shipping { get; set; }
        public string PhotoURL { get; set; }
        public int SoldItems { get; set; }
        public double Rating { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
