namespace Acme.DynamicUIElements.Abstractions
{
  using System;

  public interface IUIElementVisitor : IDisposable
  {
    void Visit(Button button);
    void Visit(InputText inputText);
    void Visit(Label label);
    void Visit(InputGroup inputGroup);
    void Visit(Form form);
    void Visit(InputButton inputButton);
    void Visit(InputCheckBox inputCheckBox);
    void Visit(InputColor inputColor);
    void Visit(InputDate inputDate);
    void Visit(InputDateTimeLocal inputDateTimeLocal);
    void Visit(InputEmail inputEmail);
    void Visit(InputFile inputFile);
    void Visit(InputHidden inputHidden);
    void Visit(InputImage inputImage);
    void Visit(InputMonth inputMonth);
    void Visit(InputNumber inputNumber);
    void Visit(InputPassword inputPassword);
    void Visit(InputRadio inputRadio);
    void Visit(InputRange inputRange);
    void Visit(InputSearch inputSearch);
    void Visit(InputSubmit inputSubmit);
    void Visit(InputTel inputTel);
    void Visit(InputTime inputTime);
    void Visit(InputUrl inputUrl);
    void Visit(InputWeek inputWeek); 
  }
}