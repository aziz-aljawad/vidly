﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set;  }
        public byte Duration { get; set;    }
        public byte DiscountRate { get; set; }

        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYouGo = 1;


    }
}