using PseudoParserAndLexer.Enums;
using PseudoParserAndLexer.TestModels;
using System;
using System.Collections.Generic;

namespace PseudoParserAndLexer
{
    public static class Handler
    {
        public static void ExecuteMethod(Queue<string> queueOfCommand, ITankEntity objectToCall)
        {
            foreach (var command in queueOfCommand)
            {
                Handler.ExampleOfReflection(command, null, objectToCall);
            }
        }

        private static void ExampleOfReflection(string funcName, object?[] args, ITankEntity objectToCall)
        {
            Type entityType = typeof(ITankEntity);
            entityType.GetMethod(funcName).Invoke(objectToCall, args);
        }

        public static void ThrowError(string errorText)
        {
            Console.WriteLine(errorText);
        }

    }
}
