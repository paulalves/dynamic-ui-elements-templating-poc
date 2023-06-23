namespace Acme.DynamicUIElements.Abstractions.Tests.Internal
{
  [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
  public sealed class PlaceHolderAttribute : Attribute
  {
    public string? PlaceHolder { get; set; } = default!;
    public string? DefaultValue { get; set; } = default!;
  }
}