using System.Collections.Generic;
using GiveCRM.Models;

namespace GiveCRM.BusinessLogic
{
    public class MemberSearchFilterService : IMemberSearchFilterService
    {
        private readonly IMemberSearchFilterRepository repository;

        public MemberSearchFilterService(IMemberSearchFilterRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<MemberSearchFilter> ForCampaign(int id)
        {
            return repository.GetByCampaignId(id);
        }

        public void Insert(MemberSearchFilter memberSearchFilter)
        {
            repository.Insert(memberSearchFilter);
        }

        public void Delete(int id)
        {
            repository.DeleteById(id);
        }

    }
}