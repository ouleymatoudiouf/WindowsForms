﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class Classe
    {
        public Classe( )
        {
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Etudiant> etudiants { get; set; }
    }
}
