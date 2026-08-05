Un pedido no puede marcarse como "listo para retiro" si Saldo_pendiente > 0 (según tu historia H2/H8).
Se debe generar un aviso al cliente 1 semana antes de Fecha_entrega_limite si el pedido no está saldado (esto ya lo tenés escrito en el relevamiento, solo hay que pasarlo a regla formal).
El stock de un insumo no puede quedar por debajo de Stock_MIN sin generar alerta.
No se puede confeccionar (descontar insumos vía Ficha_Tecnica) si no hay stock suficiente del insumo.
Un usuario con rol "Empleada" no puede modificar precios de venta (esto depende de cómo definas los roles — es una pregunta para la encuesta a la jefa).
El precio de un Detalle_pedido se congela al momento del pedido (Precio_unitario_momento), no cambia si después se actualiza el precio del producto.