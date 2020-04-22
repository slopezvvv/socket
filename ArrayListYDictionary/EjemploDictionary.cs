using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayListYDictionary
{
    class ElementoDelDiccionario
    {
        // Atributos
        private readonly string _valor;

        // Constructor
        public ElementoDelDiccionario(string valor)
        {
            _valor = valor;
        }

        // Accesador
        public string Valor => _valor;
    }

    class EjemploDictionary
    {
        // No entra en la prueba
        private Dictionary<int, Object> diccionario;
        
        public EjemploDictionary()
        {
            diccionario = new Dictionary<int, object>();

            // Clave del elemento en el diccionario.
            int id = 2323123;

            // Elemento que guardaremos
            ElementoDelDiccionario elemento = new ElementoDelDiccionario("valor");

            // Añadimos un objeto con el id en el diccionario
            diccionario.Add(id, elemento);

            // Obtenemos el objeto desde el diccionario usando el id, Casteamos el objeto en el tipo de dato correspondiente.
            ElementoDelDiccionario objetoRescatado = (ElementoDelDiccionario) diccionario[id];

            // Imprimimos en consola.
            Console.WriteLine(objetoRescatado);
        }
    }
}
