namespace Acme.DynamicUIElements.Abstractions
{
  public class InputSearch : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Search;
    public string Name { get; protected set; }

    public InputSearch WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}