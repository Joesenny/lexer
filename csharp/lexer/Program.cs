// lexer in c# for to parse HTML

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace lexer
{
    class Program
    {
        static void Main(string[] args)
          {
            string filename = args[0];
            string text = File.ReadAllText(filename);
            Lexer lexer = new Lexer(text);
            Token token = lexer.nextToken();
            while (token.type != TokenType.EOF)
            {
                Console.WriteLine(token);
                token = lexer.nextToken();
            }
        }   
    }

    enum TokenType
    

