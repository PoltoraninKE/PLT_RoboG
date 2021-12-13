using System;
using System.Collections.Generic;
using System.Linq;

namespace PseudoParserAndLexer
{
    public static class Parser
    {
        private static char commandDelimeter = ' ';
        private static char[] paramsDelimeters = { '(', ',', '.', ';', ')' };
        private static List<string> commandParameters = new List<string>();

        public static void Parse(string input)
        {
            string word = "";
            string command = "";
            commandParameters = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length > 0 || input[0] != ';')
                {
                    if (commandDelimeter == input[i] && command == "") //Если это разделитель и команда пуста - слово является строкой
                    {
                        command = word;
                        word = "";
                        i++;
                    }

                    if (command != "" && paramsDelimeters.Contains(input[i]))  //Если это разделитель и команда уже задана - собираем параметры 
                    {
                        commandParameters.Add(word);
                        word = "";
                        if (i < input.Length - 1)
                            i++;
                    }

                    if (input[i] == ';') //Если конец строки
                    {
                        Handler.ExecuteCommandWithParams(command, commandParameters);
                    }

                    word += input[i];
                }
            }
        }
    }
}
