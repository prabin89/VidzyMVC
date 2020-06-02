using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidMVC.Models;

namespace VidMVC.ViewModel
{
    public class CustomerCollectionViewModel
    {
        public IList<Customer> Customers { get; set; }
    }
}