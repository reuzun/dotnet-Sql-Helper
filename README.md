# What is it?

Just removes T from the dates like 2022-12-05T22:22:19 .. etc

# Installation

```
dotnet add package Reuzun.DB
```

# How to use it?

```c#
SQLDateHelper SQLHelper = new SQLDateHelper();

string Date = "2022-12-05T22:22:19";
  
string DateWithoutT = SQLHelper.FixSQLDate(Date);
```
