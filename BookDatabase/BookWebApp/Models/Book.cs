using BookWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApp
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public double Price { get; set; }

        public Publisher Publisher { get; set; }
    };

}

