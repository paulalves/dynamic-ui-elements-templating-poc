namespace Acme.DynamicUIElements.Abstractions
{
  public class InputText : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;

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

  public class InputButton : InputElement
  {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Button;
    public string Value { get; protected set; }
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  
  public class InputCheckBox : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.CheckBox;
    
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputColor : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Color;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputDate : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Date;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputDateTimeLocal : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.DateTimeLocal;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputEmail : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.DateTimeLocal;

    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputFile : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.File;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputHidden : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Hidden;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputImage : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Image;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputMonth : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Month;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputNumber : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Number;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputPassword : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Password;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputRadio : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Radio;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputRange : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Range;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputSearch : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Search;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputSubmit : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Submit;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputTel : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Tel;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputTime : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Time;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputUrl : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Url;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
  public class InputWeek : InputElement {
    public override UIElementType Type { get; } = UIElementType.Input;
    public InputType InputType { get; } = InputType.Week;
    public override void Accept(IUIElementVisitor elementVisitor)
    {
      throw new System.NotImplementedException();
    }
  }
}