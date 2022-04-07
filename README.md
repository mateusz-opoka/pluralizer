[![Nuget](https://img.shields.io/nuget/v/SimplePluralizer)](https://www.nuget.org/packages/SimplePluralizer/)
[![build](https://github.com/mateusz-opoka/pluralizer/actions/workflows/main.yml/badge.svg?branch=master)](https://github.com/mateusz-opoka/pluralizer/actions/workflows/main.yml)
[![codecov](https://codecov.io/gh/mateusz-opoka/pluralizer/branch/master/graph/badge.svg?token=X4791BUXF8)](https://codecov.io/gh/mateusz-opoka/pluralizer)
[![Maintainability](https://api.codeclimate.com/v1/badges/b5defd551c9835766770/maintainability)](https://codeclimate.com/github/mateusz-opoka/pluralizer/maintainability)

# SimplePluralizer
The SimplePluralizer is a package written in C# that allows you to use a noun in the correct form depending on a numeric value.

## Supportability

The SimplePluralizer package supports the below environments:

* .NET 5 or greater
* .NET Core 2.0 or greater
* .NET Framework 4.6.1 and greater

## Download

The SimplePluralizer NuGet package is available on [NuGet.org](https://www.nuget.org/packages/SimplePluralizer/).

## Installation

```powershell
PM> Install-Package SimplePluralizer
```

## Example Usage

Return a correct form for English:

```csharp
var pluralizer = new Pluralizer("key", "keys");

string result1 = pluralizer.Format(1); // Result: "key"
string result2 = pluralizer.Format(2); // Result: "keys"
string result5 = pluralizer.Format(5); // Result: "keys"
```

In Polish, for example, endings in the genitive plural are not equal for all grammatical genders:

```csharp
var pluralizer = new Pluralizer("klucz", "klucze", "kluczy");

string result1 = pluralizer.Format(1); // Result: "klucz"
string result2 = pluralizer.Format(2); // Result: "klucze"
string result5 = pluralizer.Format(5); // Result: "kluczy"
```
