using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public List<Photoshop> Photoshops { get; set; }
    }
}
