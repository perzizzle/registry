﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{

    class Program
    {

        static void Main(string[] args)
        {

            Transaction transaction = new Transaction();
            transaction = transaction.processTransaction();
            transaction.change.displayChange(transaction);

            string s = Console.ReadLine();
        }

    }
}
