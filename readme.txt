SolutionA: MyNETFrameworkApp -> MyNETFrameworkLib -> MyNETFrameworkLib2 -> Newtonsoft.Json (works!)
SolutionB: MyNETCoreApp      -> MyNETCoreLib      -> MyNETCoreLib2      -> Newtonsoft.Json (works!)
SolutionC: MyNETCoreApp      -> MyNETStandardLib  -> MyNETStandardLib2  -> Newtonsoft.Json (works!)
SolutionD: MyNETFrameworkApp -> MyNETStandardLib  -> Newtonsoft.Json (System.IO.FileNotFoundException: Could not load file or assembly 'Newtonsoft.Json...')
