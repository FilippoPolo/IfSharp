﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("IfSharp.Kernel")>]
[<assembly: AssemblyProductAttribute("IfSharp.Kernel")>]
[<assembly: AssemblyDescriptionAttribute("A short summary of your project.")>]
[<assembly: AssemblyVersionAttribute("2.0.2")>]
[<assembly: AssemblyFileVersionAttribute("2.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.0.2"
