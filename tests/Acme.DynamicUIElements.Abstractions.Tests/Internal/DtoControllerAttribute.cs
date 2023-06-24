namespace Acme.DynamicUIElements.Abstractions.Tests.Internal
{
  using System;

  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
  public class DtoControllerAttribute : Attribute
  {
    public string Version { get; set; } = default!;
    public string Controller { get; set; } = default!;

    public string Get { get; set; } = default!;
    public string Post { get; set; } = default!;
    public string Update { get; set; } = default!;
    public string Delete { get; set; } = default!;

    public string Route => $"{Version}/{Controller}";
  }
}