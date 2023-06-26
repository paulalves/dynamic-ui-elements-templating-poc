namespace Acme.DynamicUIElements.Abstractions
{
  public class InputImage : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Image;
    public string Alt { get; protected set; }
    public string Src { get; protected set; }

    public InputImage WithAlt(string alt)
    {
      Alt = alt;
      return this;
    }
    
    public InputImage WithSrc(string src)
    {
      Src = src;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}