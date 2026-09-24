# CHECKLIST DEL PROYECTO SIGIT


## 1. Documentacion

- [x] 01_Proyecto.md
- [x] 02_Relevamiento.md
- [x] 04_Reglas_de_negocio.md
- [x] 03_Modelo_Entidad_Relacion.md (version nucleo, sin Compra/Aviso/Proveedores)
- [x] Backlog en Jira (9 epicas cargadas)
- [ ] Encuesta a la jefa (dueña del taller) sobre casos puntuales
- [ ] Diagrama DFD
- [x] Historias de usuario

## 2. Base de datos

- [x] Script SQL de creacion (SIGIT_MariaDB.sql) probado y funcionando
- [ ] Usuarios iniciales cargados 
- [x] Datos de prueba de Pedidos cargados
- [x] Columna para ruta de imagen en Producto_Variante (pendiente de como lo explique el profe)
- [x] Usuario dedicado sigit_app (no root) para la conexion de la app

## 3. Login y sesion

- [x] Conexion a MariaDB (Conexion.vb)
- [x] Login con bcrypt (verificacion de contrasena)
- [x] Modulo Sesion.vb (guarda rol y usuario logueado)
- [x] Logo en el login (recurso embebido)
- [ ] Responsive basico (Anchor Top/Right en el panel blanco)
- [ ] Mensaje de error mas prolijo si usuario/contrasena estan mal

## 4. Estructura general de la app (post-login)

- [x] Menu lateral (Panel1) con botones por seccion
- [x] Panel de contenido dinamico (panelcontenido) con Dock=Fill
- [x] Subrutina cargarpanel para intercambiar UserControls
- [x] Carpetas organizadas: Modulos/ | UserControl/ | Otrosforms/

## 5. Modulos reutilizables

- [x] Validaciones.vb (ValidarNoVacio)
- [x] GrillaPers.vb (estilo de las grillas: colores, sin resize, sin fila fantasma)
- [x] GrillaBadges.vb (pildoras de color para estado) -- opcional, evaluar si se usa
- [x] Conexion.vb
- [x] Sesion.vb

## 6. Pantallas (UserControls)

- [ ] Dashboard (UCdashboard) 
- [ ] Pedidos (UCpedidos)
  - [x] Grilla con JOIN a Cliente (nombre en vez de ID)
  - [x] Combo de Estado cargado desde el ENUM
  - [ ] Buscador combinado (texto + estado + fecha) en una sola consulta
  - [ ] Alta de pedido (formulario tipo carrito: elegir productos + cantidad)
  - [ ] Modificar pedido (Form modal aparte, con ID_pedido pasado por constructor)
  - [ ] Eliminar/dar de baja pedido
- [ ] Productos (UCproductos)
  - [x] Catalogo en tarjetas (FlowLayoutPanel + UcTarjetaProducto)
  - [ ] Paginacion con LIMIT/OFFSET
  - [X] Alta/edicion de producto y variante
- [ ] Stock (UCstock)
- [X] Insumos (UCinsumos)
- [ ] Produccion (UCproduccion)
  - [ ] Tandas de produccion
  - [ ] Seguimiento por proceso (kanban interno)
- [ ] Clientes (UCclientes)
- [ ] Proveedores -- evaluar si entra en el alcance final
- [ ] Pagos

- [x] DML o SCRUD de CATEGORIAS, para INSUMOS y Productos


## 7. Git / GitHub

- [x] Repositorio vinculado (Dolores44/SIGIT)
- [x] Commits organizados con mensajes descriptivos
- [ ] .gitattributes para normalizar saltos de linea (LF/CRLF)
- [ ] Revisar que no haya contrasenas reales commiteadas en el historial

## 8. Pendientes / dudas abiertas

- [ ] Confirmar con el profe si estado va como ENUM (actual) o como tabla aparte
- [ ] Definir bien "Total Cobrado" en Pedidos: total del pedido vs. suma de pagos
- [ ] Ver como el profe explica el manejo de imagenes antes de tocar Producto_Variante 