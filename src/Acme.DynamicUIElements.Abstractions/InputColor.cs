namespace Acme.DynamicUIElements.Abstractions
{
  public class InputColor : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Color;
    public string Name { get; protected set; }
    public string Value { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}