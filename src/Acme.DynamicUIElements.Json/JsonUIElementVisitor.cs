namespace Acme.DynamicUIElements.Json
{
  using System;
  using System.IO;
  using System.Text;
  using Acme.DynamicUIElements.Abstractions;
  using Newtonsoft.Json;

  public class JsonUIElementVisitor : IUIElementVisitor, IDisposable
  {
    private readonly StringBuilder sb;
    private readonly JsonTextWriter jsonWriter;
    private readonly StringWriter textWriter;

    public JsonUIElementVisitor()
    {
      sb = new StringBuilder();
      textWriter = new StringWriter(sb);
      jsonWriter = new JsonTextWriter(textWriter) { Formatting = Formatting.Indented };
    }

    public void Visit(Button button)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(button.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(button.Type.ToString());
      jsonWriter.WritePropertyName("text");
      jsonWriter.WriteValue(button.Text);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputText inputText)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputText.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputText.Type.ToString());
      jsonWriter.WritePropertyName("placeholder");
      jsonWriter.WriteValue(inputText.PlaceHolder);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputText.TextContent);
      jsonWriter.WriteEndObject();
    }

    public void Visit(Label label)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(label.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(label.Type.ToString());
      jsonWriter.WritePropertyName("for");
      jsonWriter.WriteValue(label.For);
      jsonWriter.WritePropertyName("text");
      jsonWriter.WriteValue(label.Text);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputGroup inputGroup)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputGroup.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputGroup.Type.ToString());
      jsonWriter.WritePropertyName("nodes");
      jsonWriter.WriteStartArray();
      foreach (var node in inputGroup.Nodes)
      {
        node.Accept(this);
      }

      jsonWriter.WriteEndArray();
      jsonWriter.WriteEndObject();
    }

    public void Visit(Form form)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(form.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(form.Type.ToString());
      jsonWriter.WritePropertyName("action");
      jsonWriter.WriteValue(form.Action);
      jsonWriter.WritePropertyName("method");
      jsonWriter.WriteValue(form.Method);
      jsonWriter.WritePropertyName("nodes");
      jsonWriter.WriteStartArray();
      foreach (var node in form.Nodes)
      {
        node.Accept(this);
      }

      jsonWriter.WriteEndArray();
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputButton inputButton)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputCheckBox inputCheckBox)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputColor inputColor)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputDate inputDate)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputDateTimeLocal inputDateTimeLocal)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputEmail inputEmail)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputFile inputFile)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputHidden inputHidden)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputImage inputImage)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputMonth inputMonth)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputNumber inputNumber)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputPassword inputPassword)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputRadio inputRadio)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputRange inputRange)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputSearch inputSearch)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputSubmit inputSubmit)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputTel inputTel)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputTime inputTime)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputUrl inputUrl)
    {
      throw new NotImplementedException();
    }

    public void Visit(InputWeek inputWeek)
    {
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      textWriter.Flush();
      return sb.ToString();
    }

    public void Dispose()
    {
      ((IDisposable)jsonWriter).Dispose();
      textWriter.Dispose();
    }
  }

}