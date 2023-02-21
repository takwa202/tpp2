﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int FlightID { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "Flight Id: "+this.FlightID+" more info: "+this.Destination+" "+this.Departure+" "+this.FlightDate+" "+this.EstimatedDuration;
        }
    }
}