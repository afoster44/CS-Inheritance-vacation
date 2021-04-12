using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using vacation_time.Models;

namespace vacation_time.Repositories
{
    public class CruisesRepository
    {
        public readonly IDbConnection _db;

        public CruisesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Cruise> GetAllVacations()
        {
            string sql = @"SELECT
             cruises.destination,
             cruises.cruiseline,
             cruises.cost,
             cruises.id FROM cruises
             UNION SELECT
             trips.destination,
             trips.airline,
             trips.cost,
             trips.id FROM trips;";
            return _db.Query<Cruise>(sql);
        }
    }
}