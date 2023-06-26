namespace Acme.DynamicUIElements.Abstractions
{
  public class InputEmail : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.DateTimeLocal;

    public string Pattern { get; protected set; } = "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$";
    public int Size { get; protected set; } = 30;

    public InputEmail WithPattern(string pattern)
    {
      Pattern = pattern;
      return this;
    }
    
    public InputEmail WithSize(int size)
    {
      Size = size;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}