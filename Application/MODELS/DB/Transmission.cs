﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.DB
{
    public class Transmission
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }

     
    }
}
