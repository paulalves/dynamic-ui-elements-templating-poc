namespace Acme.DynamicUIElements.Json
{
  using System.IO;
  using Acme.DynamicUIElements.Abstractions;
  using Newtonsoft.Json;

  public class JsonUIElementParser
  {
    private readonly UIElementFactory factory;

    public JsonUIElementParser()
    {
      factory = new UIElementFactory();
    }

    public UIElement Parse(string json)
    {
      JsonReader document = new JsonTextReader(new StringReader(json));
      return Parse(document);
    }

    private UIElement Parse(JsonReader document)
    {
      var element = factory.CreateForm();

      while (document.Read())
      {
        var value = document.Value;
        var token = document.TokenType;

        if (token == JsonToken.StartObject)
        {
          continue;
        }

        value = document.Value;
        token = document.TokenType;

        if (token == JsonToken.PropertyName)
        {
          var propertyName = value.ToString();
          switch (propertyName)
          {
            case "id":
              element.WithId(document.ReadAsString());
              break;
            case "action":
              element.WithAction(document.ReadAsString());
              break;
            case "method":
              element.WithMethod(document.ReadAsString());
              break;
            case "nodes":
              // todo: 
              break;
          }
        }
      }

      return element;
    }

    // private Button ParseButton(JsonReader document)
    // {
    //   var button = factory.CreateButton();
    //   while (document.Read())
    //   {
    //     if (document.TokenType == JsonToken.PropertyName)
    //     {
    //       var propertyName = document.Value.ToString();
    //       switch (propertyName)
    //       {
    //         case "id":
    //           button.WithId(document.ReadAsString());
    //           break;
    //         case "text":
    //           button.WithText(document.ReadAsString());
    //           break;
    //         default:
    //           throw new ArgumentOutOfRangeException(nameof(propertyName), propertyName, null);
    //       }
    //     }
    //   }
    //
    //   return button;
    // }
    //
    // private InputGroup ParseInputGroups(JsonReader document)
    // {
    //   var group = factory.CreateInputGroup();
    //   while (document.Read())
    //   {
    //     if (document.TokenType == JsonToken.PropertyName)
    //     {
    //       var propertyName = document.Value.ToString();
    //       switch (propertyName)
    //       {
    //         case "id":
    //           group.WithId(document.ReadAsString());
    //           break;
    //         case "nodes":
    //           document.Read();
    //           if (document.TokenType == JsonToken.StartArray)
    //           {
    //             while (document.Read())
    //             {
    //               switch (document.Value)
    //               {
    //                 case "type":
    //
    //                   break;
    //               }
    //             }
    //           }
    //
    //           break;
    //         default:
    //           throw new ArgumentOutOfRangeException(nameof(propertyName), propertyName, null);
    //       }
    //     }
    //   }
    //
    //   return group;
    // }
  }
}