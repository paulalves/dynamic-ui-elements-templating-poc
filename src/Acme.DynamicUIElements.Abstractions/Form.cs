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

    public Form()
    {
      groups = new List<InputGroup>();
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
      group.WithParent(this);
      groups.Add(group);
      return this;
    }

    public Form With(InputGroup[] groups)
    {
      for (var g = 0; g < groups.Length; g++)
      {
         groups[g].WithParent(this);
      }
      
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
      Id = id.ToCamelCase();
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
        return elements.AsReadOnly();
      }
    }

    public Form WithButton(Button button)
    {
      button.WithParent(this);
      Button = button;
      return this;
    }
  }
}