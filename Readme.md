COMPOSICION
- Pedidos con Cliente, el Cliente se crea y se destruye junto al pedido


ASOCIACION
- Cadete y Pedido, ya que el cadete tiene un listado de pedidos, pero este puede existir sin un cadete, a su vez el pedido puede pasar de un cadete a otro por lo que es independiente del cadete


METODOS
- Cadete
    . CambiarEstadoPedido
    . 

- Cadeteria
    . obtenerCadete
    . generarInforme


DISEÑO DE COSNTRUCTORES
-Tanto el Cadete como la Cadeteria, sus construcores reciben como parametos los mismo atributos que la definene. Por ej: la cadeteria recibe un nombre, telefono y listado de cadetes
-En el caso del pedidos, al tener este una composicion con la clase Cliente , este en su constructor recibira tambien los datos del cliente para asi poder instanciar un objeto de la clase cliente