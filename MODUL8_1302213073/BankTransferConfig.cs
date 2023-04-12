﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL8_1302213073
{
    internal class BankTransferConfig
    {
        public string lang {get; set;}
        public Transfer transfer { get; set;}
        public string[] methods { get; set;}
        public Confirmation confirmation { get; set;}
        public BankTransferConfig() 
        {
            lang = "en";
            transfer = new Transfer();
            transfer.low_fee = 6500;
            transfer.high_fee = 15000;
            transfer.threshold = 25000000;
            methods = new string[] { "RTP (real-time)", "SKN", "RTGS", "BI FAST" };
            confirmation = new Confirmation();
            confirmation.en = "yes";
            confirmation.id = "no";

        }
    }
    public class Transfer
    {
        public int threshold { get; set;}
        public int low_fee { get; set;}
        public int high_fee { get; set;}

    }
    public class Confirmation
    {
        public string en { get; set;}
        public string id {get; set;} 
    }
    
}
