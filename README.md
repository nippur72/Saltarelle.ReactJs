# Saltarelle.ReactJs

Saltarelle.ReactJs is a [ReactJs](http://facebook.github.io/react/) import library 
for the C#-to-Javascript compiler [Saltarelle](http://www.saltarelle-compiler.com).

# Installation

Have a Visual Studio solution containing two projects, one for hosting the website (ASP.NET or other) 
and one for the client-side C# (compiled with Saltarelle).

On the website project:

- include the `react.js` official distribution file and reference it in your HTML pages
- include the file `saltarelle-react.js` from this repo and reference it in your HTML pages after the `mscorlib.js` script reference

On the client C# project:

- add a reference to `React.dll` from this repo

