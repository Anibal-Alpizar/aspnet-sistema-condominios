﻿using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceUsuario
    {
        IEnumerable<USUARIO> GetUSUARIOs();
        USUARIO GetUsuarioById(int id);



    }
}