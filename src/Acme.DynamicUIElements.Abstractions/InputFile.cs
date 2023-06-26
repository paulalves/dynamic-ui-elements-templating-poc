namespace Acme.DynamicUIElements.Abstractions
{
  public class InputFile : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.File;
    public string Name { get; protected set; }
    public string AcceptMime { get; protected set; } = "image/png, image/jpeg";

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}