using System;
using System.Collections.Generic;
using System.Text;

namespace Read.HealthRisks
{
    public class HealthRisk
    {
        public Guid Id { get; set; }
        public int ReadableId { get; set; }
        public string Name { get; set; }

        public HealthRisk(Guid id)
        {
            Id = id;
        }
    }
}
