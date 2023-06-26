namespace Acme.DynamicUIElements.Abstractions
{
  public class InputCheckBox : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.CheckBox;
    public bool IsChecked { get; set; }

    public InputCheckBox WithIsChecked(bool isChecked)
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