param($p1 )
#copy template to output
Copy-Item -Path "src"   -Recurse -Destination "output" -Container
cd output
        #Get-ChildItem -Path .\code -Filter *.cs 
#rename filename
Get-ChildItem -File -Recurse | % { Rename-Item -Path $_.PSPath -NewName $_.Name.replace("#Model#",$p1)} 
        #Get-ChildItem -File -Recurse  | echo  Get-Content -path C:\ReplaceDemo.txt
 

 gci -r -include "*","*.config","*.cfg" |
 foreach-object { $a = $_.fullname; ( get-content $a ) |
 foreach-object { $_ -replace "#Model#",$p1}  | 
set-content $a }

