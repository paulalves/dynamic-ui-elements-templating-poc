# dynamic-ui-elements-templating-poc

An overly simplified proof of concept for dynamic UI elements templating.

* Takes a tree of UI elements and parse them as HTML or JSON.

* Takes a DTO and parse it as a tree of UI elements.

> DISCLAMER: I wrote this code in a few hours, so it's not production ready. It's just a proof of concept.

Example:
```csharp
  [DtoController(
    Version = "v1",
    Controller = "Contacts",
    Get = "GetContacts",
    Post = "CreateContact",
    Update = "UpdateContact",
    Delete = "DeleteContact")]
  public class ContactDto
  {
    [PlaceHolder(
      DefaultValue = "",
      PlaceHolder = "Enter the id")]
    public string Id { get; set; } = default!;

    [PlaceHolder(
      DefaultValue = "",
      PlaceHolder = "Enter the name")]
    public string Name { get; set; } = default!;

    [PlaceHolder(
      DefaultValue = "",
      PlaceHolder = "Enter the phone number")]
    public string Phone { get; set; } = default!;

    [PlaceHolder(
      DefaultValue = "",
      PlaceHolder = "Enter the email address")]
    public string Email { get; set; } = default!;
  }
```

Another possible usage: 

```csharp
new Form().With(new[]
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
    }).WithId("myForm")
    .WithAction("/contacts")
    .WithMethod("POST")
    .WithButton(new Button()
      .WithId("btnSubmit")
      .WithText("Submit"));
```

HTML

```html
<form id='contactForm' action='api/v1/Contacts/CreateContact' method='POST'>
    <fieldset>
        <div id='idFormGroup'>
            <label id='lblId' for='id'>Id</label>
            <input type='text' id='id' placeholder='Enter the id' value=''/>
        </div>
        <div id='nameFormGroup'>
            <label id='lblName' for='name'>Name</label>
            <input type='text' id='name' placeholder='Enter the name' value=''/>
        </div>
        <div id='phoneFormGroup'>
            <label id='lblPhone' for='phone'>Phone</label>
            <input type='text' id='phone' placeholder='Enter the phone number' value=''/>
        </div>
        <div id='emailFormGroup'>
            <label id='lblEmail' for='email'>Email</label>
            <input type='text' id='email' placeholder='Enter the email address' value=''/>
        </div>
    </fieldset>
    <button type='Submit' id='btnSubmit' class='btn btn-primary' role='button'>Submit</button>
</form>
```

JSON

```json
{
  "id": "contactForm",
  "type": "Form",
  "action": "api/v1/Contacts/CreateContact",
  "method": "POST",
  "nodes": [
    {
      "id": "idFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblId",
          "type": "Label",
          "for": "id",
          "text": "Id"
        },
        {
          "id": "id",
          "type": "Input",
          "inputType": "Text",
          "placeholder": "Enter the id",
          "value": ""
        }
      ]
    },
    {
      "id": "nameFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblName",
          "type": "Label",
          "for": "name",
          "text": "Name"
        },
        {
          "id": "name",
          "type": "Input",
          "inputType": "Text",
          "placeholder": "Enter the name",
          "value": ""
        }
      ]
    },
    {
      "id": "phoneFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblPhone",
          "type": "Label",
          "for": "phone",
          "text": "Phone"
        },
        {
          "id": "phone",
          "type": "Input",
          "inputType": "Text",
          "placeholder": "Enter the phone number",
          "value": ""
        }
      ]
    },
    {
      "id": "emailFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblEmail",
          "type": "Label",
          "for": "email",
          "text": "Email"
        },
        {
          "id": "email",
          "type": "Input",
          "inputType": "Text",
          "placeholder": "Enter the email address",
          "value": ""
        }
      ]
    },
    {
      "id": "btnSubmit",
      "type": "Button",
      "text": "Submit",
      "attributes": [
        {
          "class": "btn btn-primary"
        },
        {
          "role": "button"
        }
      ]
    }
  ]
}
```