namespace Acme.DynamicUIElements.Abstractions
{
  using System;
  using System.Collections.Generic;

  public abstract class UIElement
  {
    public string Id { get; protected set; }
    public abstract UIElementType Type { get; }
    public virtual IReadOnlyList<UIElement> Nodes { get; } = Array.Empty<UIElement>();
    public abstract void Accept(IUIElementVisitor elementVisitor);
  }
}