﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivosMvc.Modelo
{
    public class ActivoAsignado : Activo
    {
        public virtual int CantidadAsignada { get; set; }
        public virtual Area Area { get; set; }
    }
}