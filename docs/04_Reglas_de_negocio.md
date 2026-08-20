# Reglas de Negocio - SIGIT
## 1. Gestión de Pedidos
- 01_Modificacion de pedidos: Un pedido puede ser modoficado antes de su entrega, permitiendo agregar, quitar o modificar productos y cantidades.

- 02_Estado de pedidos: Un pedido atraviesa diferentes estados durante su realización, desde su registro hasta su entrega:
* Pendiente
* En producción
* Listo para retirar
* Entregado

- 03_Entrega: Un pedido debe regitrar uan fecha limite o prevista para la entrega

- 04_Avisos: Se debe generar un aviso al cliente cuando este cerca de la fecha limite, y tambien un aviso a la empleada/jefa, directamente desde el programa.

- 05_Pedido: El precio del pedido se congela en el momento de la seña, no puede aumentar posteriormente a lo pactado. Obligando a que haya un precio que se guarde de un producto pedido.
No alcanza con guardar el precio actual del producto, hay que hacer en detalle_pedido un "precio_unitario_momento"

## 2. Pagos 
- 06_Modalidad de pago: El sistema debe permitir registrar diferentes modalidades de pago asociadas a un pedido
* Pago total antes de la entrega
* Pago parcial/seña y saldo posterior
* Pago al momento de retirar

- 07_Pagos parciales: Un pedido puede tener uno o multiples pagos registrados, con distintos metodos 

-  08_Saldo Pendiente: El saldo pendiente de un pedido corresponde a la diferencia entre el total del pedido y pagos realizados

## 3. Stock de insumos
- 09_Stock minimo de insumos: Cada insumo puede tener defindo un stock minimo para identificar cuando es necesario realizar una reposición.  

- 10_Stock Minimo: No puede quedar debajo de un stock minimo sin generar una alerta.
* EJEMPLO:
* Stock actual 3 metros | Stock minimo 5 metros = ALERTA 


## 4. Producción
- 11_Procesos de produccion: La elaboración de un producto puede estar compuesta por diferentes procesos o etapas
* Por ejemplo, remeras
    * Tela cortada
    * Confección
    * Bordado/estampado
    * Control de lo realizado
    * Producto terminado

- 12_Produccion por tandas: Una determminada cantidad de productos puede ser procesada como una tanda de producción:
* TANDA 001
    * Producto: remera basica blanca
    * Cantidad: 25
* Corte 
    * 30 cortadas
* Confección
    * 20 confeccionadas
    * 10 pendientes
* Terminado

## 5.Productos y variantes

- 13_Variante de producto: Un producto puede poseer múltiples variantes, diferenciadas por caracteristicas como talle, color, estampado, diseño u otras prpiedades

- 14_stock por variante: El stock de los productos se administra a nivel de variantee y no únicamente a nivel del producto general
    * Un ejemplo basico
    * S     10
    * M     15
    * L     8
    * XL    3

- 15_Descuento de stock:  Cuando se registra la venta de una variante de producto terminado, el stock disponible de dicha variante debe disminuir
    * Remera M
    * Stock: 15
    * Se realiza una venta de 2

    * Stock: 13

## 6. Usuarios

- Cuenta con 2 roles importantes

* JEFE/ADMIN: Puede manipular precios, requiere un login especial con una contraseña cambiable.

* Empleada: No puede manipular precios, puede ver que productos se tiene que confeccionar, puede cambiar el estado de los pedidos, NO puede cambiar precios.


## 7. Extras

- Un pedido puede modificarse una vez empezada la producción.
- Una tanda puede producir distintas variantes.
- Para productos o pedidos a medida, primero se mide a la persona, se registra y se realiza el pedido, asi que existen pedidos por talla especiales.
- El registro de un pedido no puede generar stock negativo.



 