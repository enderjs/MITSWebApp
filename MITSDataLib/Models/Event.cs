﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MITSDataLib.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string EventRegistrationType { get; set; }

        [Required]
        public int MainEventId { get; set; }

        public WildApricotEvent WaEvent { get; set; }

    }
}
