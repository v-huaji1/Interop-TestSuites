@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXWSCORE.S05_ManageMeetingItems.MSOXWSCORE_S05_TC17_GetMeetingItemWithFourItemIdTypesSuccessfully /testcontainer:..\..\MS-OXWSCORE\TestSuite\bin\Debug\MS-OXWSCORE_TestSuite.dll /runconfig:..\..\MS-OXWSCORE\MS-OXWSCORE.testsettings /unique
pause