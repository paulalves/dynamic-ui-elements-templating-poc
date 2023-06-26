namespace Acme.DynamicUIElements.Abstractions
{
  public class InputCheckBox : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.CheckBox;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}