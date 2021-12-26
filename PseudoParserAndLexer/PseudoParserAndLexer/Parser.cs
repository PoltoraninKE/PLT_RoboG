using System;
using System.Collections.Generic;
using System.Linq;

namespace PseudoParserAndLexer
{
    public class Parser
    {
        private GrammarModel _grammarModel;
        private Queue<string> _queueOfCommands;

        public Parser(GrammarModel grammarModel) 
        {
            _grammarModel = grammarModel;
        }

        public void Parse(string inputProgram)
        {
            string nonTerminal = "";
            for (int i = 0; i < inputProgram.Length; i++)
            {
                if (_grammarModel.Terminals.ContainsKey(inputProgram[i].ToString()))
                    break;
            }
        }
    }
}
