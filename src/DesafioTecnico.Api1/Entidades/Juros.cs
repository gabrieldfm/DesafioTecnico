﻿using DesafioTecnico.Api1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTecnico.Api1.Entidades
{
    public class Juros : IJuros
    {
        public double Taxa => 1;
    }
}
