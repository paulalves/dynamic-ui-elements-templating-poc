namespace Acme.DynamicUIElements.Abstractions
{
  using System;
  using System.Collections.Generic;

  public abstract class UIElement
  {
    private readonly UIAttributeCollection attributes;

    protected UIElement()
    {
      attributes = new UIAttributeCollection();
    }

    public string Id { get; protected set; }

    public abstract UIElementType Type { get; }

    public virtual IReadOnlyList<UIElement> Nodes { get; } = Array.Empty<UIElement>();

    public virtual IReadOnlyList<UIAttribute> Attributes
    {
      get { return attributes; }
    }

    public abstract void Accept(IUIElementVisitor elementVisitor);

    public UIElement WithAttribute(string name)
    {
      attributes.Add(new UIAttribute(name));
      return this;
    }
    
    public UIElement WithAttribute(string name, string value)
    {
      attributes.Add(new UIAttribute(name, value));
      return this;
    }

    public UIElement WithAttributes(params UIAttribute[] attributes)
    {
      this.attributes.AddRange(attributes);
      return this;
    }
  }

  public static class StringExtensions
  {
    public static string ToPascalCase(this string value)
    {
      // ReSharper disable once ConvertIfStatementToReturnStatement
      if (string.IsNullOrEmpty(value))
      {
        return value;
      }
      // ReSharper disable once UseStringInterpolation
      return string.Format("{0}{1}", char.ToUpperInvariant(value[0]), value.Substring(1));
    }
    
    public static string ToCamelCase(this string value)
    {
      // ReSharper disable once ConvertIfStatementToReturnStatement
      if (string.IsNullOrEmpty(value))
      {
        return value;
      }
      // ReSharper disable once UseStringInterpolation
      return string.Format("{0}{1}", char.ToLowerInvariant(value[0]), value.Substring(1));
    }
  }
}