namespace Acme.DynamicUIElements.Abstractions
{
  public class InputColor : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Color;
    public string Name { get; protected set; }
    public string Value { get; protected set; }
    
    public InputColor WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public InputColor WithValue(string value)
    {
      Value = value;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}