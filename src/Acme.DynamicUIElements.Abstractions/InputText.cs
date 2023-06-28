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
      Id = id.ToCamelCase();
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
    
    public InputText WithIsRequired(bool isRequired)
    {
      IsRequired = isRequired;
      return this;
    }
    
    public InputText WithMaxLength(int maxLength)
    {
      MaxLength = maxLength;
      return this;
    }
    
    public InputText WithMinLength(int minLength)
    {
      MinLength = minLength;
      return this;
    }
  }
}