# Getting Started examples

This repository several projects and examples to get you started with the basics of Inxton.Vortex.Framework.

The projects in this repository are aimed to expose features of the core package of the framework. Inxton.Package.Vortex.Core (Core) contains the foundational tools and libraries upon which the entire framework is built.

Even though the core package is the most elemental part of the framework it offers many powerful features. It opens possibilities that are traditionally unchallenged in PLC programming.

The inxton.vortex.compiler trans-piles the Plc program creating a PLC's twin on .net side. This approach represents streamlined, consistent, scalable and fast way of working with PLC data in structured manner. It preserves the deterministic behavior of the PLC yet does not limit the developer's options to the PLC resources.

## Prerequisites

See documentation for [Inxton.Package.Vortex.Core](https://github.com/Inxton/documentation/blob/master/Inxton.Package.Vortex.Core/README.MD)

## Examples

When you exlpore the this repository you will find that we have a XAE project that contains 'HansPlc' program. 'HansPlc' program has its .net twin project called 'HansPlcConnector'. This two project constitute the starting point for all subsequent examples.

### Simple

*Simple* examples have a simple plc counter. We aimed to show basic manipulation with twins of the PLC. Accessing variables, reading, writing, displaying (WPF, and WinForms).

### AddedProperties

This example is trying to expose the feature that allows you to introduce additional properties to twin objects in PLC code. This feature is part of wider idea that is called "Single Point of Change" (SPOC).

> In short SPOC tends to make it possible to keep the changes in a single place (which in this instance is the source code of the PLC program), later in more advanced packages we will show this concept keeps the solution clean and consistent yet at the same time it take a lot of workload away from the developer.

### Weather stations

In this example we are showing the easy with which you can use the power of .net ecosystem with the PLC. We are reading the data from the station from around the world (via .net library) and we pass them to the PLC. Plc then makes its own statements about the weather situation in different parts of the world.
