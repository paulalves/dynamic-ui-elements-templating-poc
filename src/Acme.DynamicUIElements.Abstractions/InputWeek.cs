namespace Acme.DynamicUIElements.Abstractions
{
  public class InputWeek : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Week;
    public string Name { get; protected set; }
    public string Value { get;protected set; }
    public string Min { get; protected set; }
    public string Max { get; protected set; }
    public bool IsRequired { get; set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}