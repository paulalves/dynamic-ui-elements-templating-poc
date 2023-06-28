namespace Acme.DynamicUIElements.Json
{
  using System;
  using Acme.DynamicUIElements.Abstractions;

  public class UIElementFactory
  {
    public Form CreateForm()
    {
      return new Form();
    }

    public Button CreateButton()
    {
      return new Button();
    }

    public Label CreateLabel(string text)
    {
      return new Label();
    }

    public InputElement CreateInput(InputType type)
    {
      InputElement element;

      switch (type)
      {
        case InputType.Button:
          element = new InputButton();
          break;
        case InputType.CheckBox:
          element = new InputCheckBox();
          break;
        case InputType.Color:
          element = new InputColor();
          break;
        case InputType.Date:
          element = new InputDate();
          break;
        case InputType.DateTimeLocal:
          element = new InputDateTimeLocal();
          break;
        case InputType.Email:
          element = new InputEmail();
          break;
        case InputType.File:
          element = new InputFile();
          break;
        case InputType.Hidden:
          element = new InputHidden();
          break;
        case InputType.Image:
          element = new InputImage();
          break;
        case InputType.Month:
          element = new InputMonth();
          break;
        case InputType.Number:
          element = new InputNumber();
          break;
        case InputType.Password:
          element = new InputPassword();
          break;
        case InputType.Radio:
          element = new InputRadio();
          break;
        case InputType.Range:
          element = new InputRange();
          break;
        case InputType.Search:
          element = new InputSearch();
          break;
        case InputType.Submit:
          element = new InputSubmit();
          break;
        case InputType.Tel:
          element = new InputTel();
          break;
        case InputType.Text:
          element = new InputText();
          break;
        case InputType.Time:
          element = new InputTime();
          break;
        case InputType.Url:
          element = new InputUrl();
          break;
        case InputType.Week:
          element = new InputWeek();
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof(type), type, null);
      }

      return element;
    }

    public InputGroup CreateInputGroup()
    {
      return new InputGroup();
    }
  }
}