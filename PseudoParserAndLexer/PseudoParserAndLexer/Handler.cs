using PseudoParserAndLexer.Enums;
using PseudoParserAndLexer.TestModels;
using System;
using System.Collections.Generic;

namespace PseudoParserAndLexer
{
    public static class Handler
    {
        public static void ExampleOfReflection(string funcName, object?[] args, Types type)
        {
            Type entityType;
            switch (type)
            {
                case Types.Tank:
                    entityType = typeof(ITankEntity);
                    break;
                case Types.NonTank:
                    entityType = typeof(INonTankEntity);
                    break;
                default:
                    throw new Exception("Type wasnt emplemented");
            }
            entityType.GetMethod(funcName).Invoke(type, args);
        }

        public static void ExecuteCommandWithParams(string keyWord, List<string> inputParameters)
        {
            switch (keyWord)
            {
                case "goto":
                    if (inputParameters.Count == 2)
                        Console.WriteLine("Im going to coordinates: " + inputParameters[0] + ", " + inputParameters[1]);
                    else
                        ThrowError("Error: count of parameters are shitty - " + inputParameters.Count);
                    break;
                case "cut":
                    if (inputParameters.Count == 1)
                        Console.WriteLine("Im cutting forest while count of cutted tree isnt equals:" + inputParameters[0]);
                    else
                        ThrowError("Error: count of parameters are shitty - " + inputParameters.Count);
                    break;
                case "mine":
                    if (inputParameters.Count == 3)
                        Console.WriteLine("Im mining a hole: " + inputParameters[0] + "x" + inputParameters[1] + "size and " + inputParameters[2] + " in deep");
                    else
                        ThrowError("Error: count of parameters are shitty - " + inputParameters.Count);
                    break;
                default:
                    ThrowError("Error: unknown command");
                    break;
            }
        }

        public static void ThrowError(string errorText)
        {
            Console.WriteLine(errorText);
        }

    }
}
