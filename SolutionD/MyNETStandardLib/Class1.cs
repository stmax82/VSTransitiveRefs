using Newtonsoft.Json;
using System;

namespace MyNETStandardLib {
  public class Class1 {
    public static void Foo() {
      Console.WriteLine(JsonConvert.SerializeObject("foo"));
    }
  }
}
