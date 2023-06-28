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
    
    public InputUrl WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public InputUrl WithPlaceholder(string placeholder)
    {
      Placeholder = placeholder;
      return this;
    }
    
    public InputUrl WithIsRequired(bool isRequired)
    {
      IsRequired = isRequired;
      return this;
    }
    
    public InputUrl WithPattern(string pattern)
    {
      Pattern = pattern;
      return this;
    }
    
    public InputUrl WithSize(int size)
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