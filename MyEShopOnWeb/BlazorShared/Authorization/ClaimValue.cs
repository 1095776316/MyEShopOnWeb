﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShared.Authorization
{
    public class ClaimValue
    {
        public ClaimValue()
        {

        }

        public ClaimValue(string type, string value)
        {
            Type = type;
            value = Value;
        }

        public string Type { get; set; }
        public string Value { get; set; }
    }
}
