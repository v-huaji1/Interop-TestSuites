@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASAIRS.S04_StatusError.MSASAIRS_S04_TC04_IncorrectOrder /testcontainer:..\..\MS-ASAIRS\TestSuite\bin\Debug\MS-ASAIRS_TestSuite.dll /runconfig:..\..\MS-ASAIRS\MS-ASAIRS.testsettings /unique
pause