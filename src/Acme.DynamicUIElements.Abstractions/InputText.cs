namespace Acme.DynamicUIElements.Abstractions
{
  public class InputText : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.InputText;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }

    public string PlaceHolder { get; protected set; }
    public string TextContent { get; protected set; }

    public InputText WithId(string id)
    {
      Id = id;
      return this;
    }

    public InputText WithPlaceHolder(string placeHolder)
    {
      PlaceHolder = placeHolder;
      return this;
    }

    public InputText WithValue(string textContent)
    {
      TextContent = textContent;
      return this;
    }
  }
}