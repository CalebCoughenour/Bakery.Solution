# 

#### By _**Caleb Coughenour**_

#### Bakery program that calculates total price of a users order

## Technologies Used

* C#
* REPL
* .NET
* MSTest


## Description

This is a console program that was built using C#. It is for a mock bakery named Pierre's Bakery. When first running the program the console will welcome the user and display the prices for both bread and pastries. Next, it will ask for how many of both types of food a user wants starting with bread. After the program receives the input it calculates the total price using two methods for each type of food. The prices are $5 per loaf and $2 per pastry. There is a sale of buy 2 get 1 free for bread and every third pastry is only $1. 

## Necessary Tools

* [REPL](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer)
* MSTest (optional but needed if you want to run the tests)
* .NET (install using "dotnet tool install -g dotnet-script" in console)

## Setup/Installation Requirements

* Copy the git repository url from the "code" drop down on this github page
* Open a shell program & navigate to your desktop
* Clone the repository using the copied URL and the "git clone" command
* In the shell program, navigate to the root directory of the newly created file called "Bakery.Solution"
* From the root directory, navigate to the directory named "Bakery"
* In this directory run "dotnet run" to run the program

## Test Instructions

* Using a shell program, navigate from the root directory to the directory named "Bakery.Tests"
* In this directory run "dotnet restore"
* Next run "dotnet test", this will run all written tests and display results in the console


## Known Bugs

* _No known issues_

## License

_[MIT License](license)_

Copyright (c) _5/6/22_ _Caleb Coughenour_



<br>
<br>
------------------------------------------------
<br>
<br>
1. receive two inputs as strings and convert them to int<br>
2. for each bread, add $5<br>
3. for every third bread subtract $5 from total<br>
4. for each pastry, add $2<br>
5. for every third pastry, subtract $1<br>