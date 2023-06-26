namespace Acme.DynamicUIElements.Abstractions
{
  public class InputButton : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Button;
    public string Value { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}