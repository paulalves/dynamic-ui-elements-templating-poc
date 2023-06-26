namespace Acme.DynamicUIElements.Abstractions
{
  public class InputPassword : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Password;
    public string Name { get; protected set; }
    public string Value { get; protected set; }
    public int MinLength { get; protected set; }
    public bool IsRequired { get; protected set; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}