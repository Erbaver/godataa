using GoData.Core.Repositories;
using GoData.Data.Contexts;
using GoData.Entities.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoData.Core.Logic
{
    public class OrganizationLogic
    {
        OrganizationRepository _repository;

        public OrganizationLogic(DefaultContext context)
        {
            _repository = new OrganizationRepository(context);
        }

        public async Task<Organization> CreateOrganization(Organization organization)
        {
            //make checks
            if(organization.Name == string.Empty ||
                organization.Created == null ||
                organization.OrganizationMembers.Count < 1)
            {
                throw new ArgumentException("Missing Property on organization object");
            }

            return await _repository.AddItemAsync(organization);

        }

        public IEnumerable<Organization> GetOrganizations(string objectId)
        {
            Expression<Func<Organization, bool>> expression = o => o.OrganizationMembers.Where(m => m.UserId == objectId).FirstOrDefault().UserId == objectId;
            return _repository.GetItems(expression);
        }

    }
}
