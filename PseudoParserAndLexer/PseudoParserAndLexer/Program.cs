using Newtonsoft.Json;
using PseudoParserAndLexer.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace PseudoParserAndLexer
{
    class Program
    {
        

        static void Main(string[] args)
        {
           LoadJson();
        }

        public static GrammarModel LoadJson()
        {
            // Loading json here
            using (StreamReader jsonFile = File.OpenText(@"language_definition.json")) 
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                return (GrammarModel)jsonSerializer.Deserialize(jsonFile, typeof(GrammarModel));
            }
        }

        public static void Update()
        {
            var inputProgram = File.ReadAllText(@"program.pl");
            var grammarModel = LoadJson();
            var parser = new Parser(grammarModel);
            parser.Parse(inputProgram);
        }
    }
}
