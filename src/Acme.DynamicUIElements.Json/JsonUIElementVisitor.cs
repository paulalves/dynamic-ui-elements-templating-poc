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
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputText.InputType.ToString());
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
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputButton.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputButton.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputButton.InputType.ToString());
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputCheckBox inputCheckBox)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputCheckBox.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputCheckBox.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputCheckBox.InputType.ToString());
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputColor inputColor)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputColor.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputColor.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputColor.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputColor.Name);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputColor.Value);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputDate inputDate)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputDate.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputDate.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputDate.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputDate.Name);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputDate.Value);
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputDate.Min);
      jsonWriter.WritePropertyName("max");
      jsonWriter.WriteValue(inputDate.Max);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputDateTimeLocal inputDateTimeLocal)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputDateTimeLocal.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputDateTimeLocal.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputDateTimeLocal.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputDateTimeLocal.Name);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputDateTimeLocal.Value);
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputDateTimeLocal.Min);
      jsonWriter.WritePropertyName("max");
      jsonWriter.WriteValue(inputDateTimeLocal.Max);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputEmail inputEmail)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputEmail.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputEmail.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputEmail.InputType.ToString());
      jsonWriter.WritePropertyName("pattern");
      jsonWriter.WriteValue(inputEmail.Pattern);
      jsonWriter.WritePropertyName("size");
      jsonWriter.WriteValue(inputEmail.Size);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputFile inputFile)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputFile.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputFile.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputFile.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputFile.Name);
      jsonWriter.WritePropertyName("accept");
      jsonWriter.WriteValue(inputFile.AcceptMime);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputHidden inputHidden)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputHidden.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputHidden.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputHidden.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputHidden.Name);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputHidden.Value);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputImage inputImage)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputImage.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputImage.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputImage.InputType.ToString());
      jsonWriter.WritePropertyName("alt");
      jsonWriter.WriteValue(inputImage.Alt);
      jsonWriter.WritePropertyName("src");
      jsonWriter.WriteValue(inputImage.Src);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputMonth inputMonth)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputMonth.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputMonth.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputMonth.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputMonth.Name);
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputMonth.Min);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputMonth.Value);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputNumber inputNumber)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputNumber.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputNumber.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputNumber.InputType.ToString());
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputNumber.Min);
      jsonWriter.WritePropertyName("max");
      jsonWriter.WriteValue(inputNumber.Max);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputPassword inputPassword)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputPassword.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputPassword.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputPassword.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputPassword.Name);
      jsonWriter.WritePropertyName("minLength");
      jsonWriter.WriteValue(inputPassword.MinLength);
      jsonWriter.WritePropertyName("required");
      jsonWriter.WriteValue(inputPassword.IsRequired);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputRadio inputRadio)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputRadio.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputRadio.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputRadio.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputRadio.Name);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputRadio.Value);
      jsonWriter.WritePropertyName("checked");
      jsonWriter.WriteValue(inputRadio.IsChecked);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputRange inputRange)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputRange.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputRange.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputRange.InputType.ToString());
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputRange.Min);
      jsonWriter.WritePropertyName("max");
      jsonWriter.WriteValue(inputRange.Max);
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputRange.Value);
      jsonWriter.WritePropertyName("step");
      jsonWriter.WriteValue(inputRange.Step);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputSearch inputSearch)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputSearch.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputSearch.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputSearch.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputSearch.Name);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputSubmit inputSubmit)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputSubmit.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputSubmit.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputSubmit.InputType.ToString());
      jsonWriter.WritePropertyName("value");
      jsonWriter.WriteValue(inputSubmit.Value);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputTel inputTel)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputTel.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputTel.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputTel.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputTel.Name);
      jsonWriter.WritePropertyName("pattern");
      jsonWriter.WriteValue(inputTel.Pattern);
      jsonWriter.WritePropertyName("required");
      jsonWriter.WriteValue(inputTel.IsRequired);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputTime inputTime)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputTime.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputTime.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputTime.InputType.ToString());
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputTime.Min);
      jsonWriter.WritePropertyName("max");
      jsonWriter.WriteValue(inputTime.Max);
      jsonWriter.WritePropertyName("required");
      jsonWriter.WriteValue(inputTime.IsRequired);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputUrl inputUrl)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputUrl.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputUrl.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputUrl.InputType.ToString());
      jsonWriter.WritePropertyName("name");
      jsonWriter.WriteValue(inputUrl.Name);
      jsonWriter.WritePropertyName("placeholder");
      jsonWriter.WriteValue(inputUrl.Placeholder);
      jsonWriter.WritePropertyName("pattern");
      jsonWriter.WriteValue(inputUrl.Pattern);
      jsonWriter.WritePropertyName("required");
      jsonWriter.WriteValue(inputUrl.IsRequired);
      jsonWriter.WritePropertyName("size");
      jsonWriter.WriteValue(inputUrl.Size);
      jsonWriter.WriteEndObject();
    }

    public void Visit(InputWeek inputWeek)
    {
      jsonWriter.WriteStartObject();
      jsonWriter.WritePropertyName("id");
      jsonWriter.WriteValue(inputWeek.Id);
      jsonWriter.WritePropertyName("type");
      jsonWriter.WriteValue(inputWeek.Type.ToString());
      jsonWriter.WritePropertyName("inputType");
      jsonWriter.WriteValue(inputWeek.InputType.ToString());
      jsonWriter.WritePropertyName("min");
      jsonWriter.WriteValue(inputWeek.Min);
      jsonWriter.WritePropertyName("max");
      jsonWriter.WriteValue(inputWeek.Max);
      jsonWriter.WritePropertyName("required");
      jsonWriter.WriteValue(inputWeek.IsRequired);
      jsonWriter.WriteEndObject();
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