using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoParserAndLexer.TestModels
{
    class NonTank : INonTankEntity
    {
        public void NonTankMethod()
        {
            Console.WriteLine("NonTankMethod was executed");
        }
    }
}
