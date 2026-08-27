# 06_MODELO ENTIDAD-RELACION
El modelo de entidad relación fue pulido con CLAUDE | Opte por recortar el sistema porque se volvia sumamente denso:
Las tablas quitadas fueron
Proovedor
Compra
CompraDetalle

Estas tablas iban en el apartado de las compras para reponer stock e insumos, no obstante, complejizaban muchisimo mas de lo debido, ya que tendria que ir conectado a varianteproducto e insumos.

## 1. Usuarios y Roles

Rol: ID_rol, nombre_rol | PK_rol

- Se separa en tabla aparte porque hay solo 2 roles con permisos distintos (Jefe/Admin puede tocar precios,
Empleada no). Si posteriormente se añade un rol mas, como usuario en caso de existir, se añadiria aca, sin necesidad de cambiar Usuario.

Usuario: ID_usuario, nombre_completo, usuario_login, contraseña_hash, ID_rol, activo | PK_usuario, FK_rol

- contraseña_hash en vez de contraseña: nunca se guarda la contraseña en texto plano.
- activo: para dar de baja a una empleada sin borrar su usuario y perder el historial de qué pedidos o ventas
registró, valor booleano.   

## 2. Productos

Categoria: ID_categoria, nombre, descripcion | PK_categoria

Producto: ID_producto, ID_categoria, nombre, descripcion, tipo_producto | PK_producto, FK_categoria

- tipo_producto: distingue si es un producto confeccionado por el taller o un producto de reventa (mochilas,
lápices, moños, etc.).

Producto_Variante: ID_variante, ID_producto, color, talle, otra_carac, precio_venta, stock_actual,
stock_minimo | PK_variante, FK_producto

- El stock va acá y no en Producto porque se administra por variantE, por ejemplo: De una sola tanda de productos (Remera E.P.E.T N°1) puede existir distintos talles (L, XL, M, etc). Quedando asi:
                                "Remera XL: 2   
                                 Remela L: 1"

## 3. Insumos

Insumo: ID_insumo, ID_categoria, descripcion, unidad_medida, stock_actual, stock_minimo, costo_unitario |
PK_insumo, FK_categoria

- Reutiliza la tabla Categoria para no duplicar una lista de categorías casi igual solo para insumos, osea que en categoria podria existir "remeras" y luego "botones".
- stock_actual y stock_minimo acá porque cada insumo tiene su propio mínimo y se debe alertar cuando el stock
queda por debajo (la alerta la dispara el programa, no hace falta tabla aparte).

## 4. Ficha Técnica

Ficha_Tecnica: ID_ficha, ID_variante, ID_insumo, cantidad_utilizada | PK_ficha, FK_variante, FK_insumo

- Va conectada a Producto_Variante y no a Producto, porque cada variante (talle/color) puede consumir una cantidad
distinta del mismo insumo. Por ejemplo una remera XL gasta más tela que una S; si se conectara a Producto general,
se pierde esa diferencia y no se puede calcular bien cuánta tela hace falta para una tanda.


## 5. Clientes

Cliente: ID_cliente, nombre, telefono, email, direccion | PK_cliente

- Informacion basica del cliente, para tenerlo en la BD y en posibles pedidos posteriores, tenerlo a mano facilmente.

## 6. Pedidos

Pedido: ID_pedido, ID_cliente, fecha_pedido, fecha_entrega_prevista, estado, observaciones | PK_pedido, FK_cliente

- No tiene campos de pago (metodopago, seña, pagorealizado, saldo_pendiente, nmbrecliente):
  - nmbrecliente es redundante, ya está el nombre a través de FK_cliente.

  - metodopago no puede ser un solo campo porque un pedido puede tener varios pagos con métodos distintos, por ejemplo, mitad mercado pago y mitad efectivo.

  - saldo_pendiente es una resta (total del pedido menos lo pagado), no un dato que se guarda: se calcula.

- estado: recorre Pendiente, En producción, Listo para retirar, Entregado. En MariaDB se puede usar un ENUM con
esos 4 valores fijos, seria similar a un KANBAN para tener los pedidos segidos.

- fecha_entrega_prevista: es la fecha límite. Distinta de fecha_pedido (cuándo se tomó el pedido). Contra esta
fecha se compara la fecha actual si más adelante se quiere avisar que se acerca la entrega.

Detalle_Pedido: ID_detalle, ID_pedido, ID_variante, cantidad, precio_unitario_momento, observaciones | PK_detalle,
FK_pedido, FK_variante

- precio_unitario_momento: el precio se congela al momento de la seña y no puede subir después aunque cambie el
precio de lista. Por eso no alcanza con leer el precio desde Producto_Variante, hay que guardarlo acá.

- El total del pedido se calcula sumando cantidad x precio_unitario_momento de todas sus filas, no se guarda como
columna aparte.

## 7. Ventas

Venta: ID_venta, ID_pedido, ID_cliente, ID_usuario, fecha, total | PK_venta, FK_pedido (puede ser NULL),
FK_cliente, FK_usuario

- ID_pedido puede ser NULL: una venta de mostrador no tiene pedido detrás, puede ser directamente desde el taller, un cliente que caiga sin previo aviso.

- La fila de Venta se crea en el mismo momento en que se registra el Pedido (no recién cuando se entrega). Así,
cuando el cliente deja la seña, ya existe una Venta donde registrar ese pago. Si Venta se creara solo al entregar,
no habría dónde anotar la seña.
- ID_usuario: para saber qué empleada o jefa registró la operación.

Detalle_Venta: ID_detalle_venta, ID_venta, ID_variante, cantidad, precio_unitario | PK_detalle_venta, FK_venta,
FK_variante

- precio_unitario se guarda acá también (y no solo en Producto_Variante) por el mismo motivo que en
Detalle_Pedido: si el precio de lista cambia más adelante, no tiene que afectar el registro histórico de una
venta ya hecha.

- Acá se descuenta el stock de Producto_Variante, tanto en ventas de mostrador como en las que vienen de un
pedido ya entregado.

## 8. Pagos

Pago: ID_pago, ID_venta, fecha, monto, tipo_pago, metodo_pago, num_operacion | PK_pago, FK_venta

- Se conecta solo a Venta, no a Pedido. Como toda Venta ya existe desde que se crea el Pedido (ver punto 7), no
hace falta que Pago tenga dos posibles conexiones (a Pedido o a Venta).

- tipo_pago: distingue seña, pago parcial, saldo final o pago total.

- El saldo pendiente se calcula como total de la Venta menos la suma de sus Pagos (no se guarda como columna).

## 9. Producción

Produccion: ID_produccion, ID_pedido, fecha_inicio, fecha_fin_estimada, fecha_fin_real, estado, observaciones |
PK_produccion, FK_pedido (puede ser NULL)

- ID_pedido puede ser NULL porque el taller puede producir stock por adelantado sin que haya un pedido puntual
detrás (para tener variantes disponibles en mostrador o tenerlo simplemente de stock).

Tanda_Produccion: ID_tanda, ID_produccion, ID_variante, cantidad_planificada, cantidad_producida | PK_tanda,
FK_produccion, FK_variante

- Se conecta a Producto_Variante y no a Producto porque una misma tanda puede combinar distintas variantes (por
ejemplo la tanda 001 con remeras S y M en cantidades distintas)

Proceso: ID_proceso, nombre, orden | PK_proceso

- Catálogo simple: Corte, Confección, Bordado/Estampado, Control, Terminado. El campo orden define el orden del
kanban de producción.

Seguimiento_Produccion: ID_seguimiento, ID_tanda, ID_proceso, cantidad, estado, fecha_inicio, fecha_finalizacion,
observaciones | PK_seguimiento, FK_tanda, FK_proceso

- Es el detalle de cuántas unidades de esa tanda ya pasaron por cada etapa (por ejemplo, de 25 remeras, 20 ya
confeccionadas y 5 pendientes).