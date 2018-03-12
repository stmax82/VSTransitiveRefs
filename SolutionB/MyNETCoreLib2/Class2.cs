using Newtonsoft.Json;
using System;

namespace MyNETCoreLib2 {
  public class Class2 {
    public static void Foo() {
      Console.WriteLine(JsonConvert.SerializeObject("foo"));
    }
  }
}
