namespace Acme.DynamicUIElements.Abstractions
{
  public class InputWeek : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Week;
    public string Name { get; protected set; }
    public string Value { get; protected set; }
    public string Min { get; protected set; }
    public string Max { get; protected set; }
    public bool IsRequired { get; set; }

    public InputWeek WithName(string name)
    {
      Name = name;
      return this;
    }

    public InputWeek WithValue(string value)
    {
      Value = value;
      return this;
    }

    public InputWeek WithMin(string min)
    {
      Min = min;
      return this;
    }

    public InputWeek WithMax(string max)
    {
      Max = max;
      return this;
    }

    public InputWeek WithRequired(bool isRequired)
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