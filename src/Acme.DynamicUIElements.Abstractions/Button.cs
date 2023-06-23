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

    public Button WithId(string id)
    {
      Id = id;
      return this;
    }

    public Button WithText(string text)
    {
      Text = text;
      return this;
    }
  }
}