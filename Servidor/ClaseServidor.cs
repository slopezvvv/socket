using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Servidor
{
    class ClaseServidor
    {
        // Atributos de la clase
        private const int _port = 8080; // puerto
        private IPAddress _ipAddress = IPAddress.Parse("127.0.0.1"); // ip del servidor
        private TcpListener _objServidor; // objeto del servidor

        public ClaseServidor()
        {
            _objServidor = new TcpListener(_ipAddress, _port); // Instancia del objeto servidor
        }

        public void IniciarServicio()
        {
            TcpClient cliente = null;

            // La negociacion del protocolo TCP/IP
            try
            {
                Console.WriteLine("Iniciando servidor..");
                _objServidor.Start();

                Console.WriteLine("Servidor iniciado correctamente.");
                cliente = _objServidor.AcceptTcpClient(); // Contiene un cliente aceptado en la conexion

                NetworkStream stream = cliente.GetStream(); // Los 1's y 0's del cliente
                byte[] buffer = new byte[100]; // el contenedor de los 1's y 0's

                stream.Read(buffer, 0, buffer.Length); // leemos el stream y guardamos en el buffer cada cero espacios de offset

                Console.WriteLine(buffer); // Sin codificacion ASCII, es decir, 1's y 0's binario
                Console.WriteLine(Encoding.ASCII.GetString(buffer)); // Codificacion en ASCII para poder leerlo en lenguaje humano
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error del servidor: " + ex.Message);
            }
            finally
            {
                cliente.Close();
            }
        }
    }
}
