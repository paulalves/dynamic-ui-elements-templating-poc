namespace Acme.DynamicUIElements.Abstractions
{
  public class UIAttribute
  {
    public UIAttribute(string name, string value)
    {
      Name = name.ToCamelCase(); 
      Value = value;
    }

    public string Name { get; protected set; }
    public string Value { get; protected set; }
  }
}