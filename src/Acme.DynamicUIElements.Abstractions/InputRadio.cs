namespace Acme.DynamicUIElements.Abstractions
{
  public class InputRadio : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Radio;

    public string Name { get; protected set; }
    public string Value { get; protected set; }
    public bool IsChecked { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}