﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDD2_La05.Models
{
    public interface IUploadDataZigZag<T>
    {

        IFormFile ArchivoCargado { get; set; }
        T TamañoCarriles { get; set; }
        string NuevoNombre { get; set; }
        string Palabra { get; set; }
        int Tamaño { get; set; }
    }
}
