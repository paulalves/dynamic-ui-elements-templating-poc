namespace Acme.DynamicUIElements.Abstractions
{
  public class InputText : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Text;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }

    public string PlaceHolder { get; protected set; }
    public string TextContent { get; protected set; }
    public bool IsRequired { get; protected set; }
    public int MaxLength { get; protected set; }
    public int MinLength { get; protected set; }
    public int Size { get; protected set; }

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