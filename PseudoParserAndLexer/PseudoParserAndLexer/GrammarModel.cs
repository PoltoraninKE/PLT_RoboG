using PseudoParserAndLexer.Enums;
using System.Collections.Generic;

namespace PseudoParserAndLexer
{
    public class GrammarModel
    {   
        public Dictionary<string, string> ParametrizedNonTerminals { get; set; }
        public Dictionary<string, string> NonParametrizedNonTerminals { get; set; }
        public Dictionary<string, string> Terminals { get; set; }
    }
}
