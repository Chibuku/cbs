using System;
using Dolittle.Commands.Handling;
using Dolittle.Domain;
using Domain.SMS.Gateways;

namespace Domain.SMS
{
    public class TextMessageCommandHandler : ICanHandleCommands
    {
        readonly IAggregateRootRepositoryFor<TextMessage>  _aggregateRootRepoForMessage;

        public TextMessageCommandHandler(
            IAggregateRootRepositoryFor<TextMessage>  aggregateRootRepoForMessage            
        )
        {
             _aggregateRootRepoForMessage =  aggregateRootRepoForMessage;
        }

        public void Handle(SimulateReceivedMessage cmd)
        {
            _aggregateRootRepoForMessage.Get((Guid)cmd.Id).ReceivedMessage(cmd.Id, cmd.Sender, cmd.Text, cmd.Received);
        }

        public void Handle(ReceiveMessageFromSMSGateway cmd)
        {
            _aggregateRootRepoForMessage.Get((Guid)cmd.Id).ReceivedMessage(cmd.Id, cmd.Sender, cmd.Text, cmd.Received);
        }
    }
}
