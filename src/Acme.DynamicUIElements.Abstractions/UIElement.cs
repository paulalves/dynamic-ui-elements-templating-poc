namespace Acme.DynamicUIElements.Abstractions
{
  public abstract class UIElement
  {
    public string Id { get; protected set; }
    public abstract UIElementType Type { get; }
    public virtual IReadOnlyList<UIElement> Nodes { get; } = Array.Empty<UIElement>();
    public abstract void Accept(IUIElementVisitor elementVisitor);
  }
}