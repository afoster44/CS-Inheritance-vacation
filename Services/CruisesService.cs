using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vacation_time.Models;
using vacation_time.Repositories;

namespace vacation_time.Services
{
    public class CruisesService
    {
        public readonly CruisesRepository _repo;

        public CruisesService(CruisesRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Cruise> GetAllVacations()
        {
            return _repo.GetAllVacations();
        }
    }
}