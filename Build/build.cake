#tool "nuget:?package=xunit.runner.console&version=2.2.0"

var configuration = Argument("Configuration","Release");
var solutionPath = Argument("SolutionPath",@"../Code/GodOfWar.sln");

Task("Build")
    .Does(() => 
    {
        MSBuild(solutionPath);
    });

    

Task("Run-Unit-Tests")
    .Does(() => 
    {
        var testAssemblyes = GetFiles("../Code/**/bin/"+configuration +"/*Tests.Unit.dll");
        XUnit(testAssemblyes);
    });

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("Run-Unit-Tests");


RunTarget("Default");
    