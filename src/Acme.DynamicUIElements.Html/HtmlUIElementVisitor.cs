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
        case UIElementType.InputText:
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
      throw new System.NotImplementedException();
    }

    public void Visit(InputCheckBox inputCheckBox)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputColor inputColor)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputDate inputDate)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputDateTimeLocal inputDateTimeLocal)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputEmail inputEmail)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputFile inputFile)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputHidden inputHidden)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputImage inputImage)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputMonth inputMonth)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputNumber inputNumber)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputPassword inputPassword)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputRadio inputRadio)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputRange inputRange)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputSearch inputSearch)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputSubmit inputSubmit)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputTel inputTel)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputTime inputTime)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputUrl inputUrl)
    {
      throw new System.NotImplementedException();
    }

    public void Visit(InputWeek inputWeek)
    {
      throw new System.NotImplementedException();
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