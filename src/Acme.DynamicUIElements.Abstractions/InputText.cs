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

  public class InputButton : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  
  public class InputCheckBox : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputColor : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputDate : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputDateTimeLocal : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputEmail : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputFile : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputHidden : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputImage : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputMonth : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputNumber : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputPassword : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputRadio : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputRange : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputSearch : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputSubmit : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputTel : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputTime : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputUrl : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputWeek : InputElement {
    public override UIElementType Type { get; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
}