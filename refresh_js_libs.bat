@echo off

echo rinfresca Saltarelle.AngularJS

copy ..\GitHub\Saltarelle.AngularJS\AngularJS\bin\Debug\Saltarelle.AngularJS.js  Portento.Server\libs

copy packages\Saltarelle.Runtime.2.5.0\mscorlib.js     Portento.Server\libs
copy packages\Saltarelle.Runtime.2.5.0\mscorlib.min.js Portento.Server\libs

pause
         