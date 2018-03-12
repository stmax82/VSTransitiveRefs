# Visual Studio Transitive References

* Open Solution{A,B,C,D} in VS
* In case of .NET Framework application -> click "Restore NuGet Packages"
* Start (Ctrl-F5)

## SolutionA

MyNETFrameworkApp -> MyNETFrameworkLib -> MyNETFrameworkLib2 -> Newtonsoft.Json

(**works!**)

## SolutionB

MyNETCoreApp -> MyNETCoreLib -> MyNETCoreLib2 -> Newtonsoft.Json

(**works!**)

## SolutionC

MyNETCoreApp -> MyNETStandardLib -> MyNETStandardLib2 -> Newtonsoft.Json

(**works!**)

## SolutionD

MyNETFrameworkApp -> MyNETStandardLib -> Newtonsoft.Json

(**doesn't work! System.IO.FileNotFoundException: Could not load file or assembly 'Newtonsoft.Json...'**)

Also doesn't work with the same error:

MyMonoAndroidApp -> MyNETStandardLib -> Newtonsoft.Json

## Tested with

VS2017 15.6.0
