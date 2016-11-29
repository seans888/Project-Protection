#include<FileCreation.au3>
#include<MsgBoxConstants.au3>

Func Backup($a)
local $set = 0;
local $b = $a
MsgBox($MB_ICONERROR,"",$arrayName[$b]);
Do
WinWaitActive($arrayName[$b] & " - Notepad","");

		Send("^s");
		Sleep(2000);
		FileDelete($dest & $arrayName[$b]&".txt");
		Sleep(100);
		FileCopy($path & $arrayName[$b]&".txt", $dest & $arrayName[$b]&".txt") ;
	Until($set = 1);
 EndFunc