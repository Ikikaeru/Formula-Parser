using IkiCore.TextAnalyzer;
using IkiCore.TextAnalyzer.Instructions;
using IkiCustom.Calculator;
using System;
using System.Collections.Generic;

namespace FormulaParser
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string totalParam = Console.ReadLine();
                AnalyzeObjects obj = new AnalyzeObjects(totalParam,
                    new List<IInstruction>()
                    {
                        new BlockContent("Parenthesis", "(", ")"),
                        new BlockContent("Brackets", "[", "]"),
                        new BlockContent("CurlyBrackets", "{", "}")
                    },
                    new List<IInstruction>()
                    {
                        new IkiCustom.Calculator.Number(true, true),
                        new Word(),
                        new IkiCustom.Calculator.Symbol()
                    });
                var analyzerCleanup = ComputationLogic.Cleanup(obj.Analyzer.Content);
                var analyzerContent = ComputationLogic.Operators(analyzerCleanup);
                string content = ComputationLogic.GetConcatenatedContent(analyzerContent);
                Console.WriteLine($"Result: {content}");
            }
        }
    }
}
