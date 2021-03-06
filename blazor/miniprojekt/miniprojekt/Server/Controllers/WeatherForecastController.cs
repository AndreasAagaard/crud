using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniprojekt.Client.Shared;
using miniprojekt.Shared;
using MongoDB.Bson;
using MongoDB.Driver;

namespace miniprojekt.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMongoCollection<shelter> _sheltercollection;
        private IMongoCollection<Booking> _bookingcollection;

        public WeatherForecastController(IMongoClient client)
        {
            var database = client.GetDatabase("shelterdb");
            _sheltercollection = database.GetCollection<shelter>("shelter");
            _bookingcollection = database.GetCollection<Booking>("booking");

        }

        [HttpGet]
        public IEnumerable<shelter> Get()
        {
            return _sheltercollection.Find(s => s.status == "Gældende / Vedtaget").ToList();
        }

        [HttpPost]
        public string Post(Booking booking)
        {
            int antalBooking = _bookingcollection.AsQueryable().Count();
            booking.booking_id = antalBooking + 1;
            _bookingcollection.InsertOneAsync(booking);

            return "Added Succesfully";
        }

        [HttpPut]
        public string Put(shelter shel)
        {
            var filter = Builders<Booking>.Filter.Eq("shelter_id", shel._id);
            var update = Builders<Booking>.Update.Set("status", shel.status);

            _bookingcollection.UpdateOne(filter, update);

            return "Update Succesfully";
        }

        [HttpDelete]
        public string Delete(shelter shel)
        {
            var filter = Builders<Booking>.Filter.Eq("shelter_id", shel._id);
            var update = Builders<Booking>.Update.Set("status", shel.status);

            _bookingcollection.UpdateOne(filter, update);

            return "Update Succesfully";
        }
    }
}
