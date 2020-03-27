﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazor.Shared
{
    public class Basket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; } = false;
    }
}
