namespace Acme.DynamicUIElements.Abstractions
{
  public class InputDate : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Date;
    public string Name { get; protected set; }
    public string Value { get; protected set; }
    public string Min { get; protected set; }
    public string Max { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}