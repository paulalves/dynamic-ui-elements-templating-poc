namespace Acme.DynamicUIElements.Abstractions
{
  public class InputTel : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Tel;
    public string Name { get; protected set; }
    public string Pattern { get; protected set; } = "[0-9]{3}-[0-9]{2}-[0-9]{3}";
    public bool IsRequired { get; protected set; } = false;

    public InputTel WithName(string name)
    {
      Name = name;
      return this;
    }
    
    public InputTel WithPattern(string pattern)
    {
      Pattern = pattern;
      return this;
    }
    
    public InputTel WithIsRequired(bool isRequired)
    {
      IsRequired = isRequired;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}