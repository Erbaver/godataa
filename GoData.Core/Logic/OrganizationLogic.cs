﻿using GoData.Core.Repositories;
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
        IRepository<Organization> _repository;

        public OrganizationLogic(IRepository<Organization> repository)
        {
            _repository = repository;
        }

        public async Task<Organization> CreateOrganization(Organization organization)
        {
            //make checks
            if(organization.Name == string.Empty ||
                organization.Created == null)
            {
                throw new ArgumentException("Missing Property on organization object");
            }

            return await _repository.AddItemAsync(organization);

        }

        public IEnumerable<Organization> GetOrganizationsByUserId(int userId)
        {
            Expression<Func<Organization, bool>> expression = o => o.Members.Where(m => m.UserId == userId).FirstOrDefault().UserId == userId;
            return _repository.GetItems(expression);
        }

        public Organization GetOrganizationById(int Id)
        {
            return _repository.GetItemById<int>(Id);
        }

    }
}