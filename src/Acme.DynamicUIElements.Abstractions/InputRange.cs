namespace Acme.DynamicUIElements.Abstractions
{
  public class InputRange : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Range;
    public string Name { get; protected set; }
    public int Min { get; protected set; }
    public int Max { get; protected set; }
    public int Value { get; protected set; }
    public int Step { get; protected set; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}