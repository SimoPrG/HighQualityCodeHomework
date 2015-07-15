using System;
using System.Collections.Generic;
using System.Text;

public class Brackets
{
    // taken from https://msdn.microsoft.com/en-us/library/x53a06bb.aspx - remove all known keywords which can invoke methods (primitive data types) - example int.Parse
    private static string[] keywords =
        {
            "abstract",
            "as",
            "base",
            "break",
            "case",
            "catch",
            "checked",
            "class",
            "const",
            "continue",
            "default",
            "delegate",
            "do",
            "else",
            "enum",
            "event",
            "explicit",
            "extern",
            "false",
            "finally",
            "fixed",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in",
            "interface",
            "internal",
            "is",
            "lock",
            "namespace",
            "new",
            "null",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sealed",
            "sizeof",
            "stackalloc",
            "static",
            "struct",
            "switch",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "unchecked",
            "unsafe",
            "using",
            "virtual",
            "void",
            "volatile",
            "while"
        };

    public static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        List<string> methodCalls = new List<string>();

        int foundMethods = 0;

        for (int i = 0; i < numberOfLines; i++)
        {
            string currentReadLineTrimmed = Console.ReadLine().Trim();
            int indexOfMethodDeclaration = 0;

            if (currentReadLineTrimmed.IndexOf("static ") == 0)
            {
                if (methodCalls.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", methodCalls));
                }

                if (foundMethods > 0 && methodCalls.Count == 0)
                {
                    Console.WriteLine("None");
                }

                methodCalls.Clear();

                int indexOfOpenBracket = currentReadLineTrimmed.IndexOf("(");
                int indexOfWhiteSpace = indexOfOpenBracket;

                while (!char.IsLetter(currentReadLineTrimmed[indexOfWhiteSpace]))
                {
                    indexOfWhiteSpace--;
                }

                int indexOfSpaceBeforeBracket = currentReadLineTrimmed.LastIndexOf(" ", indexOfWhiteSpace);
                indexOfMethodDeclaration = indexOfOpenBracket;

                Console.Write(currentReadLineTrimmed.Substring(indexOfSpaceBeforeBracket + 1, indexOfOpenBracket - indexOfSpaceBeforeBracket - 1).Trim());
                Console.Write(" -> ");
                foundMethods++;
            }

            var currentWord = new StringBuilder();

            bool isKeyWord = false;
            string lastKeyword = string.Empty;

            for (int j = indexOfMethodDeclaration; j < currentReadLineTrimmed.Length; j++)
            {
                if (char.IsLetter(currentReadLineTrimmed[j]))
                {
                    currentWord.Append(currentReadLineTrimmed[j]);
                    continue;
                }

                if (!char.IsLetter(currentReadLineTrimmed[j]) && currentWord.Length > 0)
                {
                    var currentWordString = currentWord.ToString();
                    if (Array.IndexOf(keywords, currentWordString) > -1)
                    {
                        isKeyWord = true;
                        currentWord.Clear();
                        lastKeyword = currentWordString;
                        continue;
                    }
                    else if (lastKeyword != "new")
                    {
                        isKeyWord = false;
                    }

                    if (CheckForMethodCall(currentReadLineTrimmed, j))
                    {
                        if (isKeyWord)
                        {
                            isKeyWord = false;
                            currentWord.Clear();
                            continue;
                        }

                        isKeyWord = false;

                        methodCalls.Add(currentWordString);
                    }

                    currentWord.Clear();
                }
            }
        }

        if (methodCalls.Count > 0)
        {
            Console.WriteLine(string.Join(", ", methodCalls));
        }

        if (foundMethods > 0 && methodCalls.Count == 0)
        {
            Console.WriteLine("None");
        }
    }

    private static bool CheckForMethodCall(string line, int position)
    {
        for (int i = position; i < line.Length; i++)
        {
            if (line[i] == ' ')
            {
                continue;
            }

            if (line[i] == '(')
            {
                return true;
            }

            break;
        }

        return false;
    }
}