namespace Acme.DynamicUIElements.Abstractions
{
  public class InputSubmit : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Submit;
    public string Value { get; protected set; }

    public InputSubmit WithValue(string value)
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