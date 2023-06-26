namespace Acme.DynamicUIElements.Abstractions
{
  public class InputImage : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Image;
    public string Alt { get; protected set; }
    public string Src { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}