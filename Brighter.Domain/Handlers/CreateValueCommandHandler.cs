using Brighter.Domain.Commands;
using Paramore.Brighter;
using System.Diagnostics;

namespace Brighter.Domain.Handlers
{
  public class CreateValueCommandHandler : RequestHandler<CreateValueCommand>
  {
    public override CreateValueCommand Handle(CreateValueCommand command)
    {
      Debug.WriteLine($"{nameof(CreateValueCommandHandler)}: creating value {command.Value}");
      return base.Handle(command);
    }
  }
}
