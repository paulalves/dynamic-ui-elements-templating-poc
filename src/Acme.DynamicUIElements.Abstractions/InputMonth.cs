namespace Acme.DynamicUIElements.Abstractions
{
  public class InputMonth : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Month;
    public string Name { get; protected set; }
    public string Min { get; protected set; }
    public string Value { get; protected set; }

    public InputMonth WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public InputMonth WithMin(string min)
    {
      Min = min;
      return this;
    }
    
    public InputMonth WithValue(string value)
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