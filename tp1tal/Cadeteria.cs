using Cadetes;

namespace Cadeterias
{
public class Cadeteria
    {
        private string? nombre;
        private string? telefono;
        private List<Cadete>? listadoCadetes;

        public Cadeteria(string nombre, string telefono){
            this.nombre = nombre;   
            this.telefono = telefono;  
            listadoCadetes = new List<Cadete>();
        }

        public void agregarCadete(Cadete nuevoCadete){
            listadoCadetes?.Add(nuevoCadete);
            Console.WriteLine("Se agrego nuevo cadete");
            return; 
        }

        public void listarCadetes(){
            
        }
    }      

}

    