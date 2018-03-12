using Newtonsoft.Json;
using System;

namespace MyNETStandardLib2 {
  public class Class2 {
    public static void Foo() {
      Console.WriteLine(JsonConvert.SerializeObject("foo"));
    }
  }
}
