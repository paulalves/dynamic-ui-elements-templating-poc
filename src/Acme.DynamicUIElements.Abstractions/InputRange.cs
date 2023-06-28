namespace Acme.DynamicUIElements.Abstractions
{
  public class InputRange : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Range;
    public string Name { get; protected set; }
    public int Min { get; protected set; }
    public int Max { get; protected set; }
    public int Value { get; protected set; }
    public int Step { get; protected set; }
    
    public InputRange WithName(string name)
    {
      Name = name.ToCamelCase(); 
      return this;
    }
    
    public InputRange WithMin(int min)
    {
      Min = min;
      return this;
    }
    
    public InputRange WithValue(int value)
    {
      Value = value;
      return this;
    }

    public InputRange WithStep(int step)
    {
      Step = step;
      return this;
    }
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }
  }
}