#include <File.au3>
#include <Date.au3>
#include <MsgBoxConstants.au3>

#RequireAdmin
#include-once

Global $myTime = _NowTime(3)
Global $myDate = _NowDate() ;
Global $path = "F:\Source\" ;
Global $dest = "F:\Back-up Beta\" ;
Global $arrayName[20];

local $c=0;

Local $Name = ($myDate & " " & $myTime) ;
Local $WD = _DateDayOfWeek(@WDAY)
Global $FileName = StringReplace($Name, ":", "-") ;

Global $location= $WD & " " & $FileName;


_FileCreate($path & $location&".txt") ; :create a file
ShellExecute($path & $location&".txt") ;
$arrayName[$c] = $location
$c+=1;


