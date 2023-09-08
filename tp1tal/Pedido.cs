using System.ComponentModel;
using Cadetes;
using Clientes;

namespace Pedidos
{
public class Pedido
    {
        public enum Estados {
            Pendiente,
            Encamino,
            Entregado,
            Cancelado,
        }
        private int idPedido;
        private int idCadete;
        private string? observaciones;
        private Estados estado;
        private Cliente? cliente;

        
        public Pedido(int idPedido, string observaciones, string nombre, string direccion, string telefono, string datosRefDireccion, int idCadete){
            this.idPedido = idPedido;
            this.observaciones = observaciones;
            estado = Estados.Pendiente;
            cliente = new Cliente(nombre, direccion, telefono, datosRefDireccion);
            this.idCadete = idCadete;
        }
        public int GetId(){
            return idPedido;
        }

        public void verDireccionCliente(){
            Console.WriteLine("La direccion del cliente: " + cliente!.Direccion + cliente.DatosRefDireccion);
        }

        public void verDatosCliente(){
            Console.WriteLine("Nombre: " + cliente!.Nombre);
            Console.WriteLine("Telefono: " + cliente.Telefono);
        } 

        public void cambiarEstado(int tipoCambio){
            int caso = (int)estado;
            
            if(tipoCambio == 1){
                
                if(caso == 0){
                    estado = Estados.Encamino;
                }else{
                    estado = Estados.Entregado;
                }
            }else{
                estado = Estados.Cancelado;
            }
        }

 
    }
}

