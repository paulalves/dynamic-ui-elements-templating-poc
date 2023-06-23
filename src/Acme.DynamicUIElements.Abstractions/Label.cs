namespace Acme.DynamicUIElements.Abstractions
{
  public class Label : UIElement
  {
    public override UIElementType Type { get; } = UIElementType.Label;
    public string For { get; protected set; }
    public string Text { get; protected set; }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }

    public Label WithId(string id)
    {
      Id = id;
      return this;
    }

    public Label WithFor(string @for)
    {
      For = @for;
      return this;
    }

    public Label WithText(string text)
    {
      Text = text;
      return this;
    }
  }
}