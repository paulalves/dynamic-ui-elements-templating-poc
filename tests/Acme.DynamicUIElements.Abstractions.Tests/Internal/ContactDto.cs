namespace Acme.DynamicUIElements.Abstractions.Tests.Internal
{
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
}