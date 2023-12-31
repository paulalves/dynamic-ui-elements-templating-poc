namespace Acme.DynamicUIElements.Abstractions
{
  public class InputTime : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Time;
    public string Min { get; protected set; }
    public string Max { get; protected set; }
    public bool IsRequired { get; protected set; } = false;
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
    
    public InputTime WithMin(string min)
    {
      Min = min;
      return this;
    }
    
    public InputTime WithMax(string max)
    {
      Max = max;
      return this;
    }
    
    public InputTime WithRequired(bool isRequired)
    {
      IsRequired = isRequired;
      return this;
    }
  }
}