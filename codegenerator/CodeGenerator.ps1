


Get-ChildItem -Path .\code -Filter *.cs 

Get-ChildItem -File -Recurse | % { Rename-Item -Path $_.PSPath -NewName $_.Name.replace("Paper","Paper")} 
Get-ChildItem -File -Recurse  | echo  Get-Content -path C:\ReplaceDemo.txt
 

 gci -r -include "*","*.config","*.cfg" |
 foreach-object { $a = $_.fullname; ( get-content $a ) |
 foreach-object { $_ -replace "Paper","Paper" }  | 
set-content $a }

