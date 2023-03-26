using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApp.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set;}

        public ICollection<Book> Books { get; set; }
    };
}
