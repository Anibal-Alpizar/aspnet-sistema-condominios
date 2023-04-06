﻿using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceAreasComunes
    {
        IEnumerable<RESERVA_AREA_COMUN> GetAreasComunes();
    }
}