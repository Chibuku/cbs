using System;
using System.Linq;
using Dolittle.Queries;
using Dolittle.ReadModels;

namespace Read.Rules
{
    public class AllRules : IQueryFor<Rule>
    {
        readonly IReadModelRepositoryFor<Rule> _repositoryForRule;

        public AllRules(IReadModelRepositoryFor<Rule> repositoryForRule)
        {
            _repositoryForRule = repositoryForRule;
        }

        public IQueryable<Rule> Query => _repositoryForRule.Query;
    }
}
