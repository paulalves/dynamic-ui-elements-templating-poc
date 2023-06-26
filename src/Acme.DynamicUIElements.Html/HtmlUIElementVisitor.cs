namespace Acme.DynamicUIElements.Html
{
  using System.CodeDom.Compiler;
  using System.IO;
  using System.Text;
  using Acme.DynamicUIElements.Abstractions;

  public class HtmlUIElementVisitor : IUIElementVisitor
  {
    private readonly StringBuilder html;
    
    private readonly IndentedTextWriter htmlWriter;

    public HtmlUIElementVisitor()
    {
      html = new StringBuilder();
      htmlWriter = new IndentedTextWriter(new StringWriter(html));
    }

    public void Visit(UIElement element)
    {
      switch (element.Type)
      {
        case UIElementType.Button:
          ((Button)element).Accept(this);
          break;
        case UIElementType.Label:
          ((Label)element).Accept(this);
          break;
        case UIElementType.Input:
          ((InputText)element).Accept(this);
          break;
        case UIElementType.InputGroup:
          ((InputGroup)element).Accept(this);
          break;
      }
    }

    public void Visit(Button button)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<button type='{button.Type}' id='{button.Id}'>{button.Text}</button>");
      htmlWriter.Indent--;
    }

    public void Visit(InputText inputText)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputText.Id}' type='text' placeholder='{inputText.PlaceHolder}' value='{inputText.TextContent}' />");
      htmlWriter.Indent--;
    }

    public void Visit(Label label)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<label id='{label.Id}' for='{label.For}'>{label.Text}</label>");
      htmlWriter.Indent--;
    }

    public void Visit(InputGroup inputGroup)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<div id='{inputGroup.Id}'>");
      inputGroup.Label.Accept(this);
      inputGroup.InputElement.Accept(this);
      htmlWriter.WriteLine("</div>");
      htmlWriter.Indent--;
    }

    public void Visit(Form form)
    {
      htmlWriter.WriteLine($"<form id='{form.Id}' action='{form.Action}' method='{form.Method}'>");
      htmlWriter.Indent++;
      htmlWriter.WriteLine("<fieldset>");
      foreach (var node in form.Nodes)
      {
        node.Accept(this);
      }
      htmlWriter.WriteLine("</fieldset>");
      htmlWriter.Indent--;
      htmlWriter.WriteLine("</form>");
    }

    public void Visit(InputButton inputButton)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputButton.Id}' type='button' value='{inputButton.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputCheckBox inputCheckBox)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputCheckBox.Id}' type='checkbox' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputColor inputColor)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputColor.Id}' name='{inputColor.Name}' type='color' value='{inputColor.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputDate inputDate)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputDate.Id}' name='{inputDate.Name}' min='{inputDate.Min}' max='{inputDate.Max}' type='date' value='{inputDate.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputDateTimeLocal inputDateTimeLocal)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputDateTimeLocal.Id}' name='{inputDateTimeLocal.Name}' min='{inputDateTimeLocal.Min}' max='{inputDateTimeLocal.Max}' type='datetime-local' value='{inputDateTimeLocal.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputEmail inputEmail)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputEmail.Id}' type='email' size='{inputEmail.Size}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputFile inputFile)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputFile.Id}' name='{inputFile.Name}' accept='{inputFile.AcceptMime}' type='file' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputHidden inputHidden)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputHidden.Id}' name='{inputHidden.Name}' type='hidden' value='{inputHidden.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputImage inputImage)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputImage.Id}' src='{inputImage.Src}' type='image' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputMonth inputMonth)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputMonth.Id}' name='{inputMonth.Name}' min='{inputMonth.Min}' type='month' value='{inputMonth.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputNumber inputNumber)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputNumber.Id}' name='{inputNumber.Name}' min='{inputNumber.Min}' max='{inputNumber.Max}' type='number'/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputPassword inputPassword)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputPassword.Id}' name='{inputPassword.Name}' minlength='{inputPassword.MinLength}' type='password' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputRadio inputRadio)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputRadio.Id}' name='{inputRadio.Name}' type='radio' value='{inputRadio.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputRange inputRange)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputRange.Id}' name='{inputRange.Name}' min='{inputRange.Min}' max='{inputRange.Max}' step='{inputRange.Step}' type='range' value='{inputRange.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputSearch inputSearch)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputSearch.Id}' name='{inputSearch.Name}' type='search' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputSubmit inputSubmit)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputSubmit.Id}' type='submit' value='{inputSubmit.Value}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputTel inputTel)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputTel.Id}' name='{inputTel.Name}' pattern='{inputTel.Pattern}' type='tel' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputTime inputTime)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputTime.Id}' min='{inputTime.Min}' max='{inputTime.Max}' type='time' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputUrl inputUrl)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputUrl.Id}' name='{inputUrl.Name}' placeholder='{inputUrl.Placeholder}' pattern='{inputUrl.Pattern}' type='url' size='{inputUrl.Size}' />");
      htmlWriter.Indent--;
    }

    public void Visit(InputWeek inputWeek)
    {
      htmlWriter.Indent++;
      htmlWriter.WriteLine($"<input id='{inputWeek.Id}' name='{inputWeek.Name}' min='{inputWeek.Min}' max='{inputWeek.Max}' type='week' value='{inputWeek.Value}' />");
      htmlWriter.Indent--;
    }

    public override string ToString()
    {
      htmlWriter.Flush();
      return html.ToString();
    }

    public void Dispose()
    {
      htmlWriter.Dispose();
    }
  }
}