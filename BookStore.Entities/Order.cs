using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieProducer { get; set; }
        public string MovieCountry { get; set; }
        public string MovieProduction { get; set; }
        public string MovieCategory { get; set; }
        public string MovieType { get; set; }
        public string MovieDimensions { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
