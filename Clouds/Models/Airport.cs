using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clouds.Models
{
    public class Airport
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String Country { get; set; }

        public String Continent { get; set; }

        public String Code { get; set; }

        public String URL { get; set; }
    }
}