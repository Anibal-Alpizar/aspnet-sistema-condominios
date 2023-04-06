﻿using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceGestionPlanesCobro
    {
        IEnumerable<GESTION_PLANES_COBRO> getGestionPlanesCobro();
        GESTION_PLANES_COBRO getGestionPlanesCobroById(int id);
        GESTION_PLANES_COBRO Save(GESTION_PLANES_COBRO gestion);
    }
}