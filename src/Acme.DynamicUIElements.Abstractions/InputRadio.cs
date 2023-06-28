namespace Acme.DynamicUIElements.Abstractions
{
  public class InputRadio : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Radio;

    public string Name { get; protected set; }
    public string Value { get; protected set; }
    public bool IsChecked { get; protected set; }

    public InputRadio WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }

    public InputRadio WithValue(string value)
    {
      Value = value;
      return this;
    }
    
    public InputRadio WithIsChecked(bool isChecked)
    {
      IsChecked = isChecked;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}