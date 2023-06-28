namespace Acme.DynamicUIElements.Html
{
  using System;
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
          ((InputElement)element).Accept(this);
          break;
        case UIElementType.InputGroup:
          ((InputGroup)element).Accept(this);
          break;
        case UIElementType.Form:
          ((Form)element).Accept(this);
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private void WriteAttributes(UIElement element)
    {
      var count = element.Attributes.Count;
      for (var attributeIndex = 0; attributeIndex < count; attributeIndex++)
      {
        var attribute = element.Attributes[attributeIndex];
        if (string.IsNullOrEmpty(attribute.Value))
        {
          if (attributeIndex < count -1) 
            htmlWriter.InnerWriter.Write($" {attribute.Name} ");
          else
            htmlWriter.InnerWriter.Write($" {attribute.Name}");
        }
        else
        {
          if (attributeIndex < count -1) 
            htmlWriter.InnerWriter.Write($" {attribute.Name}='{attribute.Value}' ");  
          else
            htmlWriter.InnerWriter.Write($"{attribute.Name}='{attribute.Value}'");  
        }       
      }
    }
    
    public void Visit(Button button)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<button type='{button.ButtonType}' id='{button.Id}'");
      WriteAttributes(button);
      htmlWriter.WriteLine($">{button.Text}</button>");
      htmlWriter.Indent--;
    }

    public void Visit(InputText inputText)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input type='text' id='{inputText.Id}' placeholder='{inputText.PlaceHolder}' value='{inputText.TextContent}'");
      WriteAttributes(inputText);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(Label label)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<label id='{label.Id}' for='{label.For}'");
      WriteAttributes(label);
      htmlWriter.WriteLine($">{label.Text}</label>");
      htmlWriter.Indent--;
    }

    public void Visit(InputGroup inputGroup)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<div id='{inputGroup.Id}'");
      WriteAttributes(inputGroup);
      htmlWriter.WriteLine(">");

      inputGroup.Label.Accept(this);
      inputGroup.InputElement.Accept(this);
      
      htmlWriter.WriteLine("</div>");
      htmlWriter.Indent--;
    }

    public void Visit(Form form)
    {
      htmlWriter.Write($"<form id='{form.Id}' action='{form.Action}' method='{form.Method}'");
      WriteAttributes(form);
      htmlWriter.WriteLine(">");
      
      htmlWriter.Indent++;
      htmlWriter.WriteLine("<fieldset>");
      foreach (var node in form.Nodes)
      {
        node.Accept(this);
      }
      htmlWriter.WriteLine("</fieldset>");
      htmlWriter.Indent--;
      form.Button.Accept(this);
      htmlWriter.WriteLine("</form>");
    }

    public void Visit(InputButton inputButton)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input type='button' id='{inputButton.Id}' value='{inputButton.Value}'");
      WriteAttributes(inputButton);
      htmlWriter.WriteLine("/>"); 
      htmlWriter.Indent--;
    }

    public void Visit(InputCheckBox inputCheckBox)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputCheckBox.Id}' type='checkbox'");
      WriteAttributes(inputCheckBox);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputColor inputColor)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputColor.Id}' name='{inputColor.Name}' type='color' value='{inputColor.Value}'");
      WriteAttributes(inputColor);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputDate inputDate)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputDate.Id}' name='{inputDate.Name}' min='{inputDate.Min}' max='{inputDate.Max}' type='date' value='{inputDate.Value}'");
      WriteAttributes(inputDate);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputDateTimeLocal inputDateTimeLocal)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputDateTimeLocal.Id}' name='{inputDateTimeLocal.Name}' min='{inputDateTimeLocal.Min}' max='{inputDateTimeLocal.Max}' type='datetime-local' value='{inputDateTimeLocal.Value}'");
      WriteAttributes(inputDateTimeLocal);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputEmail inputEmail)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputEmail.Id}' type='email' size='{inputEmail.Size}'");
      WriteAttributes(inputEmail);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputFile inputFile)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputFile.Id}' name='{inputFile.Name}' accept='{inputFile.AcceptMime}' type='file'");
      WriteAttributes(inputFile);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputHidden inputHidden)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputHidden.Id}' name='{inputHidden.Name}' type='hidden' value='{inputHidden.Value}'");
      WriteAttributes(inputHidden);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputImage inputImage)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputImage.Id}' src='{inputImage.Src}' type='image'");
      WriteAttributes(inputImage);
      htmlWriter.WriteLine("/>");

      htmlWriter.Indent--;
    }

    public void Visit(InputMonth inputMonth)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputMonth.Id}' name='{inputMonth.Name}' min='{inputMonth.Min}' type='month' value='{inputMonth.Value}'");
      WriteAttributes(inputMonth);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputNumber inputNumber)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputNumber.Id}' name='{inputNumber.Name}' min='{inputNumber.Min}' max='{inputNumber.Max}' type='number'");
      WriteAttributes(inputNumber);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputPassword inputPassword)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputPassword.Id}' name='{inputPassword.Name}' minlength='{inputPassword.MinLength}' type='password'");
      WriteAttributes(inputPassword);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputRadio inputRadio)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputRadio.Id}' name='{inputRadio.Name}' type='radio' value='{inputRadio.Value}'");
      WriteAttributes(inputRadio);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputRange inputRange)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputRange.Id}' name='{inputRange.Name}' min='{inputRange.Min}' max='{inputRange.Max}' step='{inputRange.Step}' type='range' value='{inputRange.Value}'");
      WriteAttributes(inputRange);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputSearch inputSearch)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputSearch.Id}' name='{inputSearch.Name}' type='search'");
      WriteAttributes(inputSearch);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputSubmit inputSubmit)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputSubmit.Id}' type='submit' value='{inputSubmit.Value}'");
      WriteAttributes(inputSubmit);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputTel inputTel)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputTel.Id}' name='{inputTel.Name}' pattern='{inputTel.Pattern}' type='tel'");
      WriteAttributes(inputTel);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputTime inputTime)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputTime.Id}' min='{inputTime.Min}' max='{inputTime.Max}' type='time'");
      WriteAttributes(inputTime);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputUrl inputUrl)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputUrl.Id}' name='{inputUrl.Name}' placeholder='{inputUrl.Placeholder}' pattern='{inputUrl.Pattern}' type='url' size='{inputUrl.Size}'");
      WriteAttributes(inputUrl);
      htmlWriter.WriteLine("/>");
      htmlWriter.Indent--;
    }

    public void Visit(InputWeek inputWeek)
    {
      htmlWriter.Indent++;
      htmlWriter.Write($"<input id='{inputWeek.Id}' name='{inputWeek.Name}' min='{inputWeek.Min}' max='{inputWeek.Max}' type='week' value='{inputWeek.Value}'");
      WriteAttributes(inputWeek);
      htmlWriter.WriteLine("/>");
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