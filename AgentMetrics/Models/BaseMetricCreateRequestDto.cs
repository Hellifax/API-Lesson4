﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Models
{
    public abstract class BaseMetricCreateRequestDto
    {
        public int Value { get; set; }
        public DateTime Time { get; set; }
    }
}