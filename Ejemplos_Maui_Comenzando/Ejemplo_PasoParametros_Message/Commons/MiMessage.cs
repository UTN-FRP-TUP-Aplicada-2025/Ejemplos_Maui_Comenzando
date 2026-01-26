
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Ejemplo_PasoParametros_Message.Commons;

public class MiMessage : ValueChangedMessage<MiParametro>
{
    public MiMessage(MiParametro parametro) : base(parametro) { }
}

