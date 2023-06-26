namespace Acme.DynamicUIElements.Abstractions
{
  public class InputTel : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Tel;
    public string Name { get; protected set; }
    public string Pattern { get; protected set; } = "[0-9]{3}-[0-9]{2}-[0-9]{3}";
    public bool IsRequired { get; protected set; } = false;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}