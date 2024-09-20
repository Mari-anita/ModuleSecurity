﻿using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }

        public int StateId { get; set; }
        public string ? States { get; set; }

    }
}
