using Cadetes;
using Pedidos;
using System.Linq;

namespace Cadeterias
{
public class Cadeteria
    {
        private string? nombre;
        private string? telefono;
        private List<Cadete> listadoCadetes;
        private List<Pedido> listadoPedidos;

        public Cadeteria(string nombre, string telefono){
            this.nombre = nombre;   
            this.telefono = telefono;  
            listadoCadetes = new List<Cadete>();
            listadoPedidos = new List<Pedido>();
        }

        public string AgregarCadete(Cadete nuevoCadete){
            listadoCadetes?.Add(nuevoCadete);
            return "Se agregro un nuevo cadete"; 
        }

        public void AgregarPedidos(Pedido nuevoPedido){
            listadoPedidos?.Add(nuevoPedido);
            Console.WriteLine("Se agrego nuevo cadete");
            return; 
        }
        /*
        public void JornalACobrar(int idCadete){
            int cantidadDePedidos = ;
            return cantidadDePedidos;
        }*/

        public string AsignarCadeteAPedido(int idCadete, int idPedido){
            Pedido ?pedidoEncontrado = listadoPedidos.FirstOrDefault(pedido => pedido.GetId() == idCadete);

            Cadete ?cadeteEncontrado = listadoCadetes.FirstOrDefault(cadete => cadete.GetId() == idPedido);

            if(pedidoEncontrado != null && cadeteEncontrado != null){
                return "Se asigno el pedido al cadete";
            }else{
                if(pedidoEncontrado == null){
                    return "ERROR: Pedido no encontrado";
                }else{
                    return "ERROR: Cadete no encontrado";
                }
            }
        }
    }      

}

    