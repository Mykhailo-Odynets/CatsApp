using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsApp.Models
{
    public class Cat
    {
        public Breed? breed { get; set; }
        public required string id { get; set; }
        public required string url { get; set; }
        public required int width { get; set; }
        public required int height { get; set; }
        public Category? category { get; set; }
    }
}
