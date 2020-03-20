![Inxton logo](../assets/logo.png)

# Welcome

This repo contains a single solution with various project that aim to demonstrate features of Core package of Inxton.Vortex.Framework.

# Getting started

## Check the prerequisites

Make sure you have everything you need to start using examples in this repository [here](https://github.com/Inxton/documentation/blob/master/PREREQUISITES.MD).

## Clone this repository

~~~ bash
git clone https://github.com/Inxton/Examples-Inxton.Package.Vortex.Core.git
~~~

Or download zip [here](https://github.com/Inxton/Examples-Inxton.Package.Vortex.Core/archive/master.zip)

## Open the solution

 ```Inxton.Vortex.Core.Examples.sln	```

When you explore the solution you will find that we have a XAE project that contains ``HansPlc`` program. ```HansPlc``` program has its .NET Twin project called ```HansPlcConnector```. This two projects constitute the starting point for all subsequent examples.

## Restore packages

Open Nuget manage for solution and restore missing packages.

## Activate the configuration

Activate your configuration, download the PLC to the localhost and run it as any other TwinCAT 3 project. You will need to set the target system to the target you have available (e.g. local)

## Select the project you want to try

## What to do next?

Checkout documentation  [Inxton.Package.Vortex.Core](https://github.com/Inxton/documentation)

Install the extension from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=Inxton.InxtonVortexBuilderExtensionPre)

## Compiler

Inxton.Compiler generates one to one C# objects from TwinCAT3 PLC project so you can use any .net project to access PLC data.

![inxton_transpile.gif](.\assets\inxton_transpile.gif)

You can checkout what you can do with it on [YouTube](https://www.youtube.com/channel/UCB3EcnWyLSsV5gqSt8PRDXA/featured) - basicly your PLC has all the PC capabilites.



## Getting Started examples

This repository contains several projects and examples to get you started with the basics of Inxton.Vortex.Framework.

The projects in this repository are aimed to expose features of the core package of the framework. Inxton.Package.Vortex.Core (Core) contains the foundational tools and libraries upon which the entire framework is built.

Even though the core package is the most elementary part of the framework it offers many powerful features. It opens possibilities that are traditionally unchallenged in PLC programming.

The inxton.vortex.compiler trans-piles the Plc program creating a PLC's twin on .net side. This approach represents streamlined, consistent, scalable and fast way of working with PLC data in structured manner. It preserves the deterministic behavior of the PLC yet does not limit the developer's options to the PLC resources.

## Prerequisites

See documentation for [Inxton.Package.Vortex.Core](https://github.com/Inxton/documentation/blob/master/Inxton.Package.Vortex.Core/README.MD)

## Packages update

When you clone this repository it comes without nuget packages. You will need to restore them from nuget.org.
Open 'Package Manager Console' and type

~~~ PowerShell
PS> Update-Package -Reinstall
~~~

[![Video instruction here](https://img.youtube.com/vi/11e8PGABB_U/0.jpg)](https://www.youtube.com/watch?v=11e8PGABB_U&feature=youtu.be "Update packages")


## Examples

When you explore the this repository you will find that we have a XAE project that contains 'HansPlc' program. 'HansPlc' program has its .net twin project called 'HansPlcConnector'. This two project constitute the starting point for all subsequent examples.

### Simple

*Simple* examples have a rudimentary plc counter. We aimed to show basic manipulation with twins of the PLC. Accessing variables, reading, writing, displaying (WPF, and WinForms).

> REMARKS: It is possible to use WinForms to create the valuable applications. WinForm offers simple approach, you might be more familiar with the technology. On the other hand it requires more manual coding. If you want, however get the best from the framework consider starting with WPF. WPF offers very powerful data binding, styling, templates, effective work with components. WPF on the other hand has usually slowly climbing learning curve for classical programmers. It is however worth the effort.

### AddedProperties

This example is trying to expose the feature that allows you to introduce additional properties to twin objects in the PLC code. This feature is part of wider idea that is called "Single Point of Change" (SPOC).

> In short SPOC tends to keep the changes in a single place (which in this instance is the source code of the PLC program), later in more advanced packages we will show how this concept keeps the solutions clean and consistent yet at the same time it takes a lot of workload away from the developer.

### Weather stations

In this example we are showing the ease with which you can use the power of .net ecosystem with the PLC. We are reading the data from some weather stations from around the world (via .net library) and we pass the data to the PLC. Plc then makes its own statements about the weather situation in different parts of the world.

Console application shows different ways to access PLCs' variables (Cyclical, Synchronous, Batched). There are descriptive comments in the code that should help you grasp basic concepts.

In addition this project demonstrates the ability to localize PLC strings in easy and straightforward way. The framework takes care of translating PLC STRING, WSTRING at runtime using applications' resources. Notice that localizable PLC strings are enclosed between <# and #>.


# Need help?

🧪 Or create an issue [here](https://github.com/Inxton/Feedback/issues/new/choose)

📫 We use mail too team@inxton.com 

🐤 Contact us on Twitter [@Inxton](https://twitter.com/inxtonteam)

📽 Checkout our [YouTube](https://www.youtube.com/channel/UCB3EcnWyLSsV5gqSt8PRDXA/featured)

🌐 For more info check out our website [INXTON.com](https://www.inxton.com/)


# Contributing

We are more than happy to hear your feedback, ideas!
Just submit it [here](https://github.com/Inxton/Feedback/issues/new/choose)  


# License
tldr
> Developers are encouraged to use this project -  free of charge, although when you want to use it in production enviroment you need to go to  [INXTON.com](https://www.inxton.com/) and purchase a licence.

to make our lawyers happy - read the whole licence agreement [here](https://github.com/Inxton/about/blob/master/license.md)



---
Developed with ♥ at [MTS](https://www.mts.sk/) - putting the heart into manufacturing.
 
