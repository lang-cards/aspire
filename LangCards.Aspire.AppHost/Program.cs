var builder = DistributedApplication.CreateBuilder(args);

var langCardsWeb = builder.AddProject("web", @"..\..\LangCards\Lang.Dictionary.Web\Lang.Dictionary.Web.csproj");

builder.Build().Run();
