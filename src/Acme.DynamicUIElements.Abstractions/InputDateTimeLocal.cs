namespace Acme.DynamicUIElements.Abstractions
{
  public class InputDateTimeLocal : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.DateTimeLocal;
    public string Name { get; protected set; }
    public string Value { get; protected set; }
    public string Min { get; protected set; }
    public string Max { get; protected set; }

    public InputDateTimeLocal WithName(string name)
    {
      Name = name;
      return this;
    }
    
    public InputDateTimeLocal WithValue(string value)
    {
      Value = value;
      return this;
    }
    
    public InputDateTimeLocal WithMin(string min)
    {
      Min = min;
      return this;
    }
    
    public InputDateTimeLocal WithMax(string max)
    {
      Max = max;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}