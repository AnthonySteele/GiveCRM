using System;
using System.Collections.Generic;
using GiveCRM.Models;

namespace GiveCRM.BusinessLogic
{
    public class FacetsService : IFacetsService
    {
        private readonly IRepository<Facet> repository;

        public FacetsService(IRepository<Facet> repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this.repository = repository;
        }

        public IEnumerable<Facet> All()
        {
            var facets = repository.GetAll();
            return facets;
        }

        public Facet Get(int id)
        {
            var facet = repository.GetById(id);
            return facet;
        }

        public void Insert(Facet facet)
        {
            repository.Insert(facet);             
        }

        public void Update(Facet facet)
        {
            repository.Update(facet);
        }
    }

    
}