using PseudoParserAndLexer.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PseudoParserAndLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExampleOfReflection()
            Load();
            //while (true)
            //{
            //    //Update();
            //}
        }

        public static void Load()
        {
            // load jsons here instead of deserialize it just in time
        }

        public static void Update()
        {
            string input = Console.ReadLine();
            Console.Write("\n\n\n");
            Parser.Parse(input);
            Console.Write("\n\n\n");
        }
    }
}
