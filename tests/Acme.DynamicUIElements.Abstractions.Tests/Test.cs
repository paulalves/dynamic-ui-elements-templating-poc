namespace Acme.DynamicUIElements.Abstractions.Tests
{
  using System.Reflection;
  using Acme.DynamicUIElements.Abstractions.Tests.Internal;
  using Acme.DynamicUIElements.Html;
  using Acme.DynamicUIElements.Json;

  using Xunit;
  using Xunit.Abstractions;

  public class Test
  {
    private readonly ITestOutputHelper output;

    public Test(ITestOutputHelper output)
    {
      this.output = output;
    }

    private static UIElement GetUIComponentTree()
    {
      return new Form().With(new[]
        {
          new InputGroup()
            .WithId("nameFormGroup")
            .WithLabel(
              new Label()
                .WithId("lblName")
                .WithFor("name")
                .WithText("Name")
            )
            .WithInputElement(
              new InputText()
                .WithId("name")
                .WithPlaceHolder("Enter your name")
                .WithValue("Paul Alves")
            ),
        })
        .WithId("myForm")
        .WithAction("/contacts")
        .WithMethod("POST")
        .WithButton(new Button()
        .WithId("btnSubmit")
        .WithText("Submit"));
    }

    [Fact]
    public void TraverseToHtmlTests()
    {
      
      using (var htmlElementVisitor = new HtmlUIElementVisitor())
      {
        GetUIComponentTree()
          .Accept(htmlElementVisitor);

        var rawHtml = htmlElementVisitor.ToString();
        output.WriteLine(rawHtml);
      }
      
    }

    [Fact]
    public void TraverseToJsonTests()
    {
      using (var jsonElementVisitor = new JsonUIElementVisitor())
      {
        GetUIComponentTree()
          .Accept(jsonElementVisitor);

        var rawJson = jsonElementVisitor.ToString();
        output.WriteLine(rawJson);
      }
    }

    [Fact]
    public void ParseDtoTests()
    {
      var dto = typeof(ContactDto);
      var props = dto.GetProperties();
      var attribute = dto.GetCustomAttribute<DtoControllerAttribute>()!;

      var form = new Form()
        .WithAction(string.Concat("api/", attribute.Route, "/", attribute.Post))
        .WithMethod("POST")
        .WithId($"{dto.Name.Replace("Dto", "")}Form");
      foreach (var prop in props)
      {
        var placeHolderAttribute = prop.GetCustomAttribute<PlaceHolderAttribute>()!;

        form.With(new InputGroup()
          .WithId($"{prop.Name}FormGroup")
          .WithLabel(
            new Label()
              .WithId($"lbl{prop.Name}")
              .WithFor(prop.Name)
              .WithText(prop.Name)
          )
          .WithInputElement(
            new InputText()
              .WithId(prop.Name)
              .WithPlaceHolder(placeHolderAttribute.PlaceHolder ?? $"Enter the {prop.Name}")
              .WithValue(placeHolderAttribute.DefaultValue ?? "")
          )).WithButton(
          new Button()
            .WithId("btnSubmit")
            .WithText("Submit")
            .WithAttribute(
              "class",
              "btn btn-primary")
            .WithAttribute("role", "button") as Button);
      }

      using (var htmlElementVisitor = new HtmlUIElementVisitor())
      using (var jsonElementVisitor = new JsonUIElementVisitor())
      {
        form.Accept(htmlElementVisitor);
        form.Accept(jsonElementVisitor);

        var rawHtml = htmlElementVisitor.ToString()!;
        var rawJson = jsonElementVisitor.ToString()!;

        output.WriteLine(rawHtml);
        output.WriteLine(rawJson);
      }
    }
  }
}