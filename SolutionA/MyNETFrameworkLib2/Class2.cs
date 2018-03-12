using Newtonsoft.Json;
using System;

namespace MyNETFrameworkLib2 {
  public class Class2 {
    public static void Foo() {
      Console.WriteLine(JsonConvert.SerializeObject("foo"));
    }
  }
}
