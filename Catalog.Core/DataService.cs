using System;
using System.Collections.Generic;

namespace Catalog.Core
{
    public class DataService
    {
        private static DataService instance;
        private DataService()
        {
            var eagles = new Team { Id = 0, Name = "Eagles" };
            var bears = new Team { Id = 1, Name = "Bears" };

            Teams = new List<Team>
            {
                eagles,
                bears
            };

            People = new List<Person>
            {
                new Person { Id = 432, Name = "John" },
                new Person { Id = 44332, Name = "Joe" },
                new Person { Id = 43342, Name = "Ed", Team = eagles },
                new Person { Id = 4352, Name = "Merphy", Team = bears },
                new Person { Id = 4342, Name = "Met", Team = bears },
            };
        }

        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Person> People { get; set; }

        public static DataService GetInstance()
        {
            if (instance == null)
                instance = new DataService();
            return instance;
        }
    }
}
