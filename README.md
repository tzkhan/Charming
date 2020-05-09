# Charming

![](https://github.com/tzkhan/Charming/workflows/CI/badge.svg)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Charming)
![Nuget](https://img.shields.io/nuget/dt/Charming)

If you are someone who is comfortable using C# and are looking to avoid labouring with the cumbersome json syntax of an [ARM](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/overview) template, then **Charming** is for you. 😎

## What does it do?
You can define a template and the resources within it using C#, leveraging all its power and Charming will appropriately serialise the template to json. You can then deploy the outputted json template using any of the existing available methods such as the Azure CLI, Powershell or the Resource Manager REST API.

This library **does not aim** to provide functionality to create, modify or manage infrastructure. It does not handle any state or track any deployments. If you require such functionality, then you should check out other awesome tools like [Terraform](https://www.terraform.io/) or [Pulumi](https://www.pulumi.com/).

### Features
- Use regular language features and control flow via C# - no more unwieldly logic using template functions or copy loops
- Use strongly typed models to define templates and resources - no need to deal with json anymore
- Use standard testing tools (xUnit, nUnit, etc) to validate template structure and semantics
- Convenient helper functions that facilitate referencing resources and defining outputs easily
- Does away with some of the limitations encountered while authoring templates by hand, for instance:
  - [empty arrays](https://stackoverflow.com/questions/53722613/arm-resource-iteration-failing-with-an-empty-array)
  - [nested loops](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/copy-resources#iteration-for-a-child-resource)

## Getting started

There are two NuGet packages available:
- [Charming](https://www.nuget.org/packages/Charming): contains the core types and serialisation functionality
- [Charming.Types](https://www.nuget.org/packages/Charming.Types): contains types that represent commonly used Azure resources (**recommended**)

#### Install NuGet package:

```
Install-Package Charming.Types
```

or via the command line

```
dotnet add package Charming.Types
```

## Usage

For detailed documentation and examples, check out the [wiki](https://github.com/tzkhan/Charming/wiki).

Following example generates a template to deploy a storage account with a blob service and multiple containers:

```csharp
// Define a storage account
var storage = new StorageAccount("samplestorage")
{
    Kind = "BlobStorage",
    Sku = new Sku { Name = "Standard_LRS" },
    Properties = new StorageAccountProperties { AccessTier = "Hot" },
};

// Container names - perhaps loaded from external configuration
var containers = new[] { "container1", "container2", "container3" };

// Define blob service with containers
var blobService = new StorageAccountBlobService("default")
    .WithResources(
        containers.Select(name => new StorageAccountBlobServiceContainer(name)));

// Add blob service as a child resource to storage
storage.Resources.Add(blobService);

// Create a resource group level deployment template
var template = new ResourceGroupDeploymentTemplate()
    .WithResources(storage);

// Generate json and write to a file that can be used for deployment
File.WriteAllText("azuredeploy.json", template.ToJson());
```

Add the following `using` directives for the example above:

```csharp
using System.IO;
using System.Linq;
using Charming;
using Charming.Types.Storage;
```

## Contributing
All contributions and feedback are welcome and highly appreciated. You can suggest and help develop new features, fix bugs or improve documentation.

Considering that Charming focusses mainly on helping generate ARM templates, new features must aim to:
- provide guardrails that help avoid invalid arm template syntax and sematics
- add more convenience functions to help build a template
