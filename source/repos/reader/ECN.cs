﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    public class ECN
    {
        public string ID { get; private set; }
        public string N { get; private set; }
        public string H { get; private set; }
        public string L { get; private set; }

        public ECN(string columnID, string columnN, string columnH, string columnL)
        {
            ID = columnID;
            N = columnN;
            H = columnH;
            L = columnL;
        }

        public override string ToString()
        {
            return $"{ID,-20} {N,-20} {H,-20} {L,-20}";
        }
    }
}
