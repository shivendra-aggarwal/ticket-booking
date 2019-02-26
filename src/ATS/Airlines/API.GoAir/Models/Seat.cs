﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.GoAir.Models
{
    public class Seat
    {
        public int SeatId { get; set; }

        public DateTime Date { get; set; }

        public int BasePrice { get; set; }

        public string FromCity { get; set; }

        public string ToCity { get; set; }

        public string FlightNumber { get; set; }

        public string SeatType { get; set; }

        public int SeatNumber { get; set; }

        public Guid ExternalId { get; set; }

        public string VendorName { get; set; }
    }
}
