/*
*todo: start the dotnet app
*todo: replace initial code with lighter syntax version
todo: copy the larger code block and spot the differences
*/

//^ original code
// using System;

// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

//^second code block
// System.Console.WriteLine("Hello World!");

//^ third block... this one took in an answer in the terminal, and tehn ranit through teh conditional. very cool 

// System.Console.Write("Who would you like to say hello to? ");

// string name = System.Console.ReadLine();

// if (string.IsNullOrWhiteSpace(name))
// {
//     System.Console.WriteLine("Fine, don't say 'hello'!");
// }
// else
// {
//     System.Console.WriteLine($"Hello, {name}!");
// }

//^4th blck, using USING

using System;

Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
} 


