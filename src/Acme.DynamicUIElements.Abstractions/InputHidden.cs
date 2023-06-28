namespace Acme.DynamicUIElements.Abstractions
{
  public class InputHidden : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Hidden;
    public string Name { get; protected set; }
    public string Value { get; protected set; }

    public InputHidden WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public InputHidden WithValue(string value)
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