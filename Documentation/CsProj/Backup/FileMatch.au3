#include<MsgBoxConstants.au3>
#include<FileBackup.au3>
#include<FileCreation.au3>


$arrayName[1] =1;
Local $a;

Local $WinName = "lol";
Sleep	(1000)


	for $c = 0 to 20 step +1
	if $arrayName[$c] <> "" Then
		$a = $c;
		Call("Backup",$a);
		MsgBox($MB_ICONERROR,"",$arrayName[0]);
	EndIf

	Next

