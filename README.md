[![.NET](https://github.com/reuzun/dotnet-Sql-Helper/actions/workflows/dotnet.yml/badge.svg)](https://github.com/reuzun/dotnet-Sql-Helper/actions/workflows/dotnet.yml) ![badge](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/reuzun/d915b1f8f53c1209a3dbfb09d626b440/raw/test.json)

# What is it?

A SQL helper class that contains some utility methods which mainly aims to reduce code repetition.

# Installation

```
dotnet add package Reuzun.DB
```

# How to use it?

```c#
SQLDateHelper SQLHelper = new SQLDateHelper();

string Date = "2022-12-05T22:22:19";
  
string DateWithoutT = SQLHelper.FixSQLDate(Date);

Console.WriteLine(DateWithoutT); // prints 2022-12-05 22:22:19

DateTime LocalDateTime = DateTime.Now; // Assume 2022-12-05 22:22:19

Console.WriteLine(SQLHelper.GetDate(LocalDateTime, '.', DateStyleEnum.YearToDay)); // prints 2022.12.05
Console.WriteLine(SQLHelper.GetDate(LocalDateTime, '|')); // prints 05|12|2022
Console.WriteLine(SQLHelper.GetClock(LocalDateTime, '?')); // prints 22?22?19
```
