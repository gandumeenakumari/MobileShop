using System;
using System.Collections.Generic;

namespace MobileShop.Data
{
    public partial class Mobile
    {
        public int MobileId { get; set; }
        public string Model { get; set; } = null!;
        public string Ram { get; set; } = null!;
        public int Cost { get; set; }
    }
}
