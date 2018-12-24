using System;
using System.Collections.Generic;
using System.Linq;
namespace TripTracker.BackService.Models
{
    public class Repository
    {
        public Repository()
        {
        }

        private List<Trip> MyTrip = new List<Trip> {

        new Trip{
        ID = 1,
        Name = "Trip to Goa",
        StartTime = new DateTime(2018,7,9),
        EndTime = new DateTime(2018,7,15)
        },
        new Trip{
        ID = 2,
        Name = "To Home Bahraich",
        StartTime = new DateTime(2018,10,3),
        EndTime = new DateTime(2018,11,9)
        },
        new Trip{
        ID = 3,
        Name = "Sapeint Interview",
        StartTime = new DateTime(2018,11,10),
        EndTime = new DateTime(2018,11,10)
        }

        };

        public List<Trip> Get()
        {

            return MyTrip;
        }

        public Trip Get(int id)
        {
            return MyTrip.First(t => t.ID == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrip.Add(newTrip);
        }

        public void update(Trip tripToUpdate)
        {

            MyTrip.Remove(MyTrip.First(t => t.ID == tripToUpdate.ID));
        }

        public void remove(int id)
        {
            MyTrip.Remove(MyTrip.First(t => t.ID == id));
        }


    }
}
