﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models.Read
{
    public partial class TblPurchase
    {
        public long IntPurchaseId { get; set; }
        public long IntSupplierId { get; set; }
        public DateTime DtePurchaseDate { get; set; }
        public bool IsActive { get; set; }
    }
}
