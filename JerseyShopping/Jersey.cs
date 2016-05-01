using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JerseyShopping
{
    public class Jersey
    {
        public Jersey(string img,int qty)
        {
            this.img = img;
            this.qty = qty;
        }
        public string img { get; set; }
        public int qty { get; set; }
    }
}