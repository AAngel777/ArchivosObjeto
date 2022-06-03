using System;
using System.IO;
namespace ArchivosObjeto
{
    class Persona
    {
        public string nombre;
        public long num;
        public float prom;
       public Persona(string nombre, long num, float prom)
        {
            this.nombre = nombre;
            this.num = num;
            this.prom = prom;
        }
        public void Escribe()
        {
            StreamWriter sw = new StreamWriter("Alumnos.txt", true);
            sw.WriteLine(nombre + num + prom);
            sw.Close();

        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese numero de control: ");
                long num = long.Parse(Console.ReadLine());
                Console.Write("Ingrese promedio: ");
                float prom = float.Parse(Console.ReadLine());
                Persona o1 = new Persona(nombre,num,prom);
                o1.Escribe();
                Console.WriteLine("Escribiendo...");
                Console.ReadLine();
            }
           catch(IOException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
 
        }
    }
}
