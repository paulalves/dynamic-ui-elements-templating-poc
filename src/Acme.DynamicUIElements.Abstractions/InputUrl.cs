namespace Acme.DynamicUIElements.Abstractions
{
  public class InputUrl : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Url;
    public string Name { get; protected set; }
    public string Placeholder { get; protected set; }
    public bool IsRequired { get; protected set; } = false;
    public string Pattern { get; protected set; } = "https?://.+";
    public int Size { get; protected set; }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}