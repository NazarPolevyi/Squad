using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvertisements.Web.DTO
{
    public class CreateAdvertisement
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string UserName { get; set; }
    }
}
