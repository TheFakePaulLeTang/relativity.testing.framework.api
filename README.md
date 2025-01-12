# Relativity.Testing.Framework.Api

This repository contains a C#/NuGet library that abstracts out API functionality for Relativity test setup and teardown.

## Build Tasks

This repository builds with the [dotnet sdk](https://dotnet.microsoft.com/download). It supports standard tasks like dotnet build, dotnet test and dotnet pack.

## Local Testing

This repository has unit and functional tests in it. Functional tests have Category=FunctionalTests.

### Unit Testing

Run through the standard compile and (unit) test tasks. These can be done without any external environment to test on.

```PowerShell
dotnet test ./Source/ --filter TestCategory!=FunctionalTests
```

### Functional Testing

To do the rest of the testing, we need to provide an instance of Relativity to test against.
This should ideally be an ephemeral one that we can throw away afterwards.

#### Creating Runsettings

Before we can run the tests, we'll need to provide a runsettings file that points the tests to the instance of Relativity that is being tested against.
To create the runsettings file, run the following command, replacing instance settings parameters with what you need:

```PowerShell
./DevelopmentScripts/New-TestSettings.ps1 -ServerBindingType "https" -RelativityHostAddress "YOUR_HOST_ADDRESS" -AdminUsername "YOUR_ADMIN_USERNAME" -AdminPassword "YOUR_ADMIN_PASSWORD"

```
This script will create FunctionalTest.runsettings and put it next to itself. You shall use this file to setup functional testing.

#### Running Functional Tests

Run Tests in Visual Studio:

* Attach your runsettings file to the solution in Visual Studio.
* Use the built in test runner.

You can also run functional tests from the command line:

```PowerShell
dotnet test ./Source/ --filter TestCategory=FunctionalTests -s .\DevelopmentScripts\FunctionalTest.runsettings

```

## Documentation

For more details check out our documentation that can be found [here](https://relativitydev.github.io/relativity.testing.framework.api/)