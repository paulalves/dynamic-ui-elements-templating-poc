namespace Acme.DynamicUIElements.Abstractions
{
  using System.Collections.Generic;

  public class InputGroup : UIElement
  {
    public InputGroup()
    {
    }

    public InputGroup(Label label, InputText inputElement)
    {
      Label = label;
      InputElement = inputElement;
    }

    public override UIElementType Type { get; } = UIElementType.InputGroup;
    public Label Label { get; protected set; }
    public InputElement InputElement { get; protected set; }

    public override IReadOnlyList<UIElement> Nodes
    {
      get { return new UIElement[] { Label, InputElement }; }
    }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }

    public InputGroup WithId(string id)
    {
      Id = id.ToCamelCase();
      return this;
    }

    public InputGroup WithLabel(Label label)
    {
      label.WithParent(this);
      Label = label;
      return this;
    }

    public InputGroup WithInputElement(InputElement inputElement)
    {
      inputElement.WithParent(this);
      InputElement = inputElement;
      return this;
    }
  }
}