﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingProgram
{
    public class CashierClass
    {
        
        private static int x = 10000;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue = new Queue<string>();

        public static string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
        public static event Action OnQueueChanged;
        internal static string DequeueNumber()
        {
            if (CashierQueue.Count > 0)
            {
                return CashierQueue.Dequeue();
            }
            return null;
        }
    }
    }




  
       