﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerShop.Models
{
    public class Item
    {
        public Product product
        {
            get;
            set;
        }
        public int quantity
        {
            get;
            set;
        }
    }
}