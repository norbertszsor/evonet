// See https://aka.ms/new-console-template for more information

using EvoNet.Console;
using Spectre.Console;



IMatrixLogic logicTest = new MatrixLogic();

logicTest.Initialize(10,10);
logicTest.Describe();
AnsiConsole.Markup("[underline red]Hello[/] World!");
AnsiConsole.Markup(logicTest.Describe());

