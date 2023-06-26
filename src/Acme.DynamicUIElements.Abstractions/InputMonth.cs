namespace Acme.DynamicUIElements.Abstractions
{
  public class InputMonth : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Month;
    public string Name { get; protected set; }
    public string Min { get; protected set; }
    public string Value { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}