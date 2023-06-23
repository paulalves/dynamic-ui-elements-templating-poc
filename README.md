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
<form id='ContactForm' action='api/v1/Contacts/CreateContact' method='POST'>
    <fieldset id='IdFormGroup'>
        <label id='lblId' for='Id'>Id</label>
        <input id='Id' type='text' placeholder='Enter the id' value='' />
    </fieldset>
    <fieldset id='NameFormGroup'>
        <label id='lblName' for='Name'>Name</label>
        <input id='Name' type='text' placeholder='Enter the name' value='' />
    </fieldset>
    <fieldset id='PhoneFormGroup'>
        <label id='lblPhone' for='Phone'>Phone</label>
        <input id='Phone' type='text' placeholder='Enter the phone number' value='' />
    </fieldset>
    <fieldset id='EmailFormGroup'>
        <label id='lblEmail' for='Email'>Email</label>
        <input id='Email' type='text' placeholder='Enter the email address' value='' />
    </fieldset>
    <button id=''>Submit</button>
</form>
```

JSON

```json
{
  "id": "ContactForm",
  "type": "Form",
  "action": "api/v1/Contacts/CreateContact",
  "method": "POST",
  "nodes": [
    {
      "id": "IdFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblId",
          "type": "Label",
          "for": "Id",
          "text": "Id"
        },
        {
          "id": "Id",
          "type": "InputText",
          "placeholder": "Enter the id",
          "value": ""
        }
      ]
    },
    {
      "id": "NameFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblName",
          "type": "Label",
          "for": "Name",
          "text": "Name"
        },
        {
          "id": "Name",
          "type": "InputText",
          "placeholder": "Enter the name",
          "value": ""
        }
      ]
    },
    {
      "id": "PhoneFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblPhone",
          "type": "Label",
          "for": "Phone",
          "text": "Phone"
        },
        {
          "id": "Phone",
          "type": "InputText",
          "placeholder": "Enter the phone number",
          "value": ""
        }
      ]
    },
    {
      "id": "EmailFormGroup",
      "type": "InputGroup",
      "nodes": [
        {
          "id": "lblEmail",
          "type": "Label",
          "for": "Email",
          "text": "Email"
        },
        {
          "id": "Email",
          "type": "InputText",
          "placeholder": "Enter the email address",
          "value": ""
        }
      ]
    },
    {
      "id": "btnSubmit",
      "type": "Button",
      "text": "Submit"
    }
  ]
}
```