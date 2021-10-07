# Outline

A constrain example of dynamically including project and content using MSBuild Directory.Build.* files to adhere to project naming conventions.

When a C# project is created, and it has matching Unit, Integration or Environment test projects the source project (being testing) and a shared testing project is included.

For example, given a project called `SampleApp.Core` - and any combination of `SampleApp.Core.UnitTests`, `SampleApp.Core.IntegrationTests` or `SampleApp.Core.EnvironmentTests` then the `SampleApp.Core` project is dynamically included.

While this works using MSBuild, Azure DevOps and the tests successfully execute using `dotnet test` and the VS Test Explorer, NCrunch cannot process the files due to `The referenced project '../SampleApp.Core/SampleApp.Core.csproj' does not exist`.

Other things of note are:

* Testing NuGet packages are dynamically included.
* Variables are setup and maintained for testing project.
* As much content is in a central location as possible - this allows us to use git submodules to store the shared Directory.Build.* files.