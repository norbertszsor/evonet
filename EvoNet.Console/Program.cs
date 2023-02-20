// See https://aka.ms/new-console-template for more information

using EvoNet.Core.Services;
using EvoNet.Interfaces.Core.Services;
using Spectre.Console;



IEnvironmnetLogic logicTest = new EnvironmentLogic();

logicTest.Initialize(10,10);
logicTest.Describe();
AnsiConsole.Markup("[underline red]Hello[/] World!");
AnsiConsole.Markup(logicTest.Describe());

