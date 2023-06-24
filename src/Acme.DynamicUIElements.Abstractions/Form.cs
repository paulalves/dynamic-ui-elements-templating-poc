namespace Acme.DynamicUIElements.Abstractions
{
  using System.Collections.Generic;

  public class Form : UIElement
  {
    private readonly List<InputGroup> groups;

    public Form(Button button)
    {
      Button = button;
      groups = new List<InputGroup>();
    }

    public Form() : this(new Button().WithText("Submit"))
    {
    }

    public override UIElementType Type { get; } = UIElementType.Form;

    public string Action { get; protected set; }

    public string Method { get; protected set; }

    public Button Button { get; protected set; }

    public IReadOnlyList<InputGroup> Groups
    {
      get { return groups; }
    }

    public Form With(InputGroup group)
    {
      groups.Add(group);
      return this;
    }

    public Form With(InputGroup[] groups)
    {
      this.groups.AddRange(groups);
      return this;
    }

    public Form WithAction(string action)
    {
      Action = action;
      return this;
    }

    public Form WithMethod(string method)
    {
      Method = method;
      return this;
    }

    public Form WithId(string id)
    {
      Id = id;
      return this;
    }

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      elementVisitor.Visit(this);
    }

    public override IReadOnlyList<UIElement> Nodes
    {
      get
      {
        var elements = new List<UIElement>();
        elements.AddRange(Groups);
        elements.Add(Button);
        return elements.AsReadOnly();
      }
    }

    public Form WithButton(Button button)
    {
      Button = button;
      return this;
    }
  }
}