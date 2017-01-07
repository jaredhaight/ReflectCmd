## A reflective DLL loading demo
I wanted to play around with reflective DLLs so I put this together. Most of the code for this was put together from the following resources:

* [MSDN: How to Create and Use Assemblies Using the Command Line (C#)](https://msdn.microsoft.com/en-us/library/mt632257.aspx)
* [StackOverflow: Loading DLLs at runtime in C#](http://stackoverflow.com/questions/18362368/loading-dlls-at-runtime-in-c-sharp)


## Example
```
PS C:\Build> .\ReflectCmdConsole.exe C:\ReflectCmdDll.dll "dir C:\\"
[console]: loading assembly.
[console]: loading type.
[console]: running command.
[dll]: got command: dir C:\
[dll]: new proc
[dll]: starting proc
[dll]: getting output
[dll]: returning output
[console]: printing output.


 Volume in drive C has no label.
 Volume Serial Number is 9999-9999

 Directory of C:\

07/16/2016  06:47 AM    <DIR>          PerfLogs
12/25/2016  04:12 PM    <DIR>          Program Files
12/25/2016  02:33 PM    <DIR>          Program Files (x86)
09/18/2016  08:10 PM    <DIR>          Users
01/02/2017  04:01 PM    <DIR>          Windows
               1 File(s)            125 bytes
               8 Dir(s)   6,714,937,344 bytes free

PS C:\Build>
```