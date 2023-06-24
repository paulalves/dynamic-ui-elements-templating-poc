namespace Acme.DynamicUIElements.Abstractions
{
  using System;

  public interface IUIElementVisitor : IDisposable
  {
    void Visit(Button button);
    void Visit(InputText inputText);
    void Visit(Label label);
    void Visit(InputGroup inputGroup);
    void Visit(Form form);
  }
}