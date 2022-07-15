using System;
using System.Collections.Generic;

namespace ShoppingMVC.Models.EF
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string? Pname { get; set; }
        public string? Pcategory { get; set; }
        public int? Pprice { get; set; }
        public bool? PinStock { get; set; }
    }
}
