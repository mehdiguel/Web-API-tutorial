using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_tutorial.Models;

namespace Web_API_tutorial.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}