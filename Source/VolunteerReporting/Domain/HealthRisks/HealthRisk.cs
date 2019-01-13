using Dolittle.Domain;
using Dolittle.Runtime.Events;
using Events.Admin.HealthRisks;

namespace Domain.HealthRisks
{
    public class HealthRisk : AggregateRoot
    {
        public HealthRisk(EventSourceId id) : base(id)
        {
        }
        public void CreateHealthRisk(
            /*HealthRiskName*/ string name,
            int readableId)
        {
            Apply(new HealthRiskCreated(EventSourceId.Value, readableId, name));
        }
    }
}
