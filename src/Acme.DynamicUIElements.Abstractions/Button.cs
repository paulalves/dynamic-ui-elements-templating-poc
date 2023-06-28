namespace Acme.DynamicUIElements.Abstractions
{
  public class Button : UIElement
  {
    public override UIElementType Type { get; } = UIElementType.Button;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }

    public string Text { get; protected set; }
    public ButtonType ButtonType { get; protected set; } = ButtonType.Submit;
    
    public Button WithId(string id)
    {
      Id = id.ToCamelCase();
      return this;
    }

    public Button WithText(string text)
    {
      Text = text;
      return this;
    }
    
    public Button WithButtonType(ButtonType buttonType)
    {
      ButtonType = buttonType;
      return this;
    }
  }
}