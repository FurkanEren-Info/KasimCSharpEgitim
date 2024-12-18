﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08SiniflarClasses
{
    internal class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        // navigation property ile classlar arasındaki bağ kurabiliriz 
        public Marka? Marka { get; set; }
        public Kategori? Kategori { get; set; }
    }
}