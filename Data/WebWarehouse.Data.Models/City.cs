using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebWarehouse.Data.Models
{
    public class City
    {
        public City()
        {
            
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
