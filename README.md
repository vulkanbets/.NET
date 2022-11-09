## .NET 6 Projects on Linux
- Creating & Testing Web Apps & Micro-services
---
---
- To List All Avaiable Templates dotnet Has For Your System
~~~bash
dotnet new --list
~~~
- To Create A New Cosole App Type This Command
~~~bash
dotnet new Console -o <Name Of Console App>
~~~
- Instructions to Build Console App
- ## Build first to see Warning and Errors
  - cd into App directory
~~~bash
dotnet build
~~~
- Instructions to Run Console App
<br>
<br>
  - cd into App directory
~~~bash
dotnet run <First Command Line Argument> <Second Command Line Argument>
~~~
- Or Conversely Using One Bash Command...
~~~bash
clear && dotnet build && printf "\n\n\nBuild Succeded. Now Executing...\n\n\n" && dotnet run
~~~
