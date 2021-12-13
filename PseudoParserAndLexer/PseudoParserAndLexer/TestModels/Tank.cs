using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoParserAndLexer.TestModels
{
    class Tank : ITankEntity
    {
        public void TankMethod()
        {
            Console.Write("TankMethod was executed");
        }
    }
}
