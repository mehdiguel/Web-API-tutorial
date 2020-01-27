using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_tutorial.Models;

namespace Web_API_tutorial.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List <Customer> Customers { get; set; }
    }
}