using System.Collections.Generic;

namespace PseudoParserAndLexer
{
    public static class Lexer
    {
        private static Dictionary<string, string> _nonParametrizedNonTerminals;
        private static Dictionary<string, string> _parametrizedNonTerminals;
        private static Dictionary<string, string> _terminals;

        public static void LoadGrammar(Dictionary<string, string> nonParametrizedNonTerminals, Dictionary<string, string> parametrizedNonTerminals, Dictionary<string, string> terminals)
        {
            _nonParametrizedNonTerminals = nonParametrizedNonTerminals;
            _parametrizedNonTerminals = parametrizedNonTerminals;
            _terminals = terminals;
        }

        public static void ExecuteMethod(LexerModel model)
        {
            foreach (var line in model.ModelGrammar)
            {
                Handler.ExampleOfReflection(line.Value, null, model.ModelType);
            }
        }
    }
}
