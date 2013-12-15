ConsoleCheckTbExist
===================

## About

Created as a Visual C# console application using Visual Studio 2012.

## Running the console application

1. Change the ctid variable in the code to reflect the ctid you wish to test for.
2. Press Start.
3. A console will open up and display the return code when `mchecktbexist.exe` is done running.

## Utility Location

http://storage.conduit.com/PS/utilities/mini/mchecktbexist.exe

## Adding the utility to a project

Make sure the utility is in the same folder as the program being debugged.

-- 

In our case, we placed the `mchecktbexist.exe` utitlity in the following path after downloading it:

[ConsoleCheckTbExist/tree/master/ConsoleCheckTbExist/bin/Debug](https://github.com/pbojinov/ConsoleCheckTbExist/tree/master/ConsoleCheckTbExist/bin/Debug)

## Utility Return Codes

0 - Toolbar is installed

1 - Toolbar is not installed

2 - Cancelled by User

3 - Bad Command or Filename (no CTID passed)

4 - Internet Connection Error

5 - Failed to Install a Module


[![Bitdeli Badge](https://d2weczhvl823v0.cloudfront.net/pbojinov/consolechecktbexist/trend.png)](https://bitdeli.com/free "Bitdeli Badge")

