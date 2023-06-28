namespace Acme.DynamicUIElements.Abstractions
{
  public class InputFile : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.File;
    public string Name { get; protected set; }
    public string AcceptMime { get; protected set; } = "image/png, image/jpeg";
  
    public InputFile WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public InputFile WithAccept(string accept)
    {
      AcceptMime = accept;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}