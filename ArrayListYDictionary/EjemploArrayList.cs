﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayListYDictionary
{
    class EjemploArrayList
    {
        public EjemploArrayList()
        {
            // Material del arraylist
            ArrayList miListaDinamica = new ArrayList();

            // Agregar de forma manual
            miListaDinamica.Add(256);
            miListaDinamica.Add("Un String");
            miListaDinamica.Add(new Program());

            // Agregar elementos de forma automatizada
            for (int i = 0; i < 10; i++)
                miListaDinamica.Add("Posiciones: " + i);

            // Mostrar elementos
            foreach (Object tipo in miListaDinamica)
                continue;//Console.WriteLine(tipo);
        }
    }
}
