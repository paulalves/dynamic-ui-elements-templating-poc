namespace Acme.DynamicUIElements.Abstractions
{
  public class InputNumber : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Number;
    public int Min { get; protected set; }
    public int Max { get; protected set; }
    public string Name { get; protected set; }

    public InputNumber WithMin(int min)
    {
      Min = min;
      return this;
    }
    
    public InputNumber WithMax(int max)
    {
      Max = max;
      return this;
    }
    
    public InputNumber WithName(string name)
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