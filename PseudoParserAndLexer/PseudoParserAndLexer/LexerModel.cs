using PseudoParserAndLexer.Enums;
using System.Collections.Generic;

namespace PseudoParserAndLexer
{
    public class LexerModel
    {
        public Dictionary<string, string> ModelGrammar { get; set; }
        public Types ModelType { get; set; }
    }
}
