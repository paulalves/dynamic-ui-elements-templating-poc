namespace Acme.DynamicUIElements.Abstractions
{
  public class InputNumber : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Number;
    public int Min { get; protected set; }
    public int Max { get; protected set; }
    public string Name { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}