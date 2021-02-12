﻿using CoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public string CarName { get; set; }

        public string UserName { get; set; }

        public string CustomerName { get; set; }

        public DateTime RentTime { get; set; }

        public DateTime ReturnTime { get; set; }
    }
}