-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- Utilice IA para que me haga la converscioón de BDML a Maria DB.
-- Explico yo cada punto | La referencia guia esta en 06_Modelo_ER
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 


-- Esto crea la base de datos SI NO EXISTE.
CREATE DATABASE IF NOT EXISTS sigit
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_spanish_ci;
-- Character SET pone que el UTF-8, el codigo principal utilizado por la mayoria de textos, como por ejemplo este mismo.

USE sigit;


-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 1. Usuarios y roles
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Rol (
  ID_rol      INT AUTO_INCREMENT PRIMARY KEY,
  nombre_rol  VARCHAR(50) NOT NULL
);

CREATE TABLE Usuario (
  ID_usuario        INT AUTO_INCREMENT PRIMARY KEY,
  nombre_completo   VARCHAR(100) NOT NULL,
  usuario_login     VARCHAR(50) NOT NULL UNIQUE,
  contrasena_hash   VARCHAR(255) NOT NULL,
  ID_rol            INT NOT NULL,
  activo            BOOLEAN NOT NULL DEFAULT TRUE,
  CONSTRAINT fk_usuario_rol FOREIGN KEY (ID_rol) REFERENCES Rol(ID_rol)
);

-- Referida a la tabla de usuarios del sistema, rol aparte de Usuario, a futuro o a necesidad, se crea otra categoria con el hipotetico rango.

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 2. Productos
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Categoria (
  ID_categoria  INT AUTO_INCREMENT PRIMARY KEY,
  nombre        VARCHAR(50) NOT NULL,
  descripcion   VARCHAR(255)
);

CREATE TABLE Producto (
  ID_producto     INT AUTO_INCREMENT PRIMARY KEY,
  ID_categoria    INT NOT NULL,
  nombre          VARCHAR(100) NOT NULL,
  descripcion     VARCHAR(255),
  tipo_producto   VARCHAR(50), -- confeccionado / reventa
  CONSTRAINT fk_producto_categoria FOREIGN KEY (ID_categoria) REFERENCES Categoria(ID_categoria)
);

CREATE TABLE Producto_Variante (
  ID_variante           INT AUTO_INCREMENT PRIMARY KEY,
  ID_producto           INT NOT NULL,
  color                 VARCHAR(50),
  talle                 VARCHAR(20),
  otra_caracteristica   VARCHAR(100),
  precio_venta          DECIMAL(10,2) NOT NULL,
  stock_actual          INT NOT NULL DEFAULT 0,
  stock_minimo          INT NOT NULL DEFAULT 0,
  CONSTRAINT fk_variante_producto FOREIGN KEY (ID_producto) REFERENCES Producto(ID_producto)
);

-- Lo que se menciono, el stock se maneja con variantes.
-- Dato extra: Los Decimales(10,2) por ejemplo, son iguales que en pascal, muestra el entero (10 digitos) y las decimales (2 digitos); 10.325,90

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 3. Insumos
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Insumo (
  ID_insumo       INT AUTO_INCREMENT PRIMARY KEY,
  ID_categoria    INT NOT NULL,
  descripcion     VARCHAR(150) NOT NULL,
  unidad_medida   VARCHAR(20),
  stock_actual    DECIMAL(10,2) NOT NULL DEFAULT 0,
  stock_minimo    DECIMAL(10,2) NOT NULL DEFAULT 0,
  costo_unitario  DECIMAL(10,2),
  CONSTRAINT fk_insumo_categoria FOREIGN KEY (ID_categoria) REFERENCES Categoria(ID_categoria)
);

-- Conectado a CATEGORIA, para no hacer una tabla CATEGORIA-INSUMOS, habrian muchos datos dispersos y se volveria sumamente denso conectar tablas

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 4. Ficha Tecnica
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Ficha_Tecnica (
  ID_ficha            INT AUTO_INCREMENT PRIMARY KEY,
  ID_variante         INT NOT NULL,
  ID_insumo           INT NOT NULL,
  cantidad_utilizada  DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_ficha_variante FOREIGN KEY (ID_variante) REFERENCES Producto_Variante(ID_variante),
  CONSTRAINT fk_ficha_insumo FOREIGN KEY (ID_insumo) REFERENCES Insumo(ID_insumo)
);

-- La ficha tecnica manejado por variante como foreign key, ya que cada variante tiene distintas cantidades de telas utilizadas

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 5. Clientes
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Cliente (
  ID_cliente  INT AUTO_INCREMENT PRIMARY KEY,
  nombre      VARCHAR(100) NOT NULL,
  telefono    VARCHAR(30),
  email       VARCHAR(100),
  direccion   VARCHAR(150)
);

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 6. Pedidos
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Pedido (
  ID_pedido               INT AUTO_INCREMENT PRIMARY KEY,
  ID_cliente              INT NOT NULL,
  fecha_pedido            DATE NOT NULL,
  fecha_entrega_prevista  DATE,
  estado                  ENUM('pendiente','en_produccion','listo_para_retirar','entregado')
                          NOT NULL DEFAULT 'pendiente',
  observaciones           VARCHAR(255),
  CONSTRAINT fk_pedido_cliente FOREIGN KEY (ID_cliente) REFERENCES Cliente(ID_cliente)
);

-- Enum es como posibles opciones ya implementadas, sin la necesidad de cargarlos a posterior como si fuera un ID

CREATE TABLE Detalle_Pedido (
  ID_detalle               INT AUTO_INCREMENT PRIMARY KEY,
  ID_pedido                INT NOT NULL,
  ID_variante              INT NOT NULL,
  cantidad                 INT NOT NULL,
  precio_unitario_momento  DECIMAL(10,2) NOT NULL,
  observaciones            VARCHAR(255),
  CONSTRAINT fk_detpedido_pedido FOREIGN KEY (ID_pedido) REFERENCES Pedido(ID_pedido),
  CONSTRAINT fk_detpedido_variante FOREIGN KEY (ID_variante) REFERENCES Producto_Variante(ID_variante)
);

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 7. Ventas
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Venta (
  ID_venta    INT AUTO_INCREMENT PRIMARY KEY,
  ID_pedido   INT NULL,  -- nullable: venta de mostrador sin pedido
  ID_cliente  INT NOT NULL,
  ID_usuario  INT NOT NULL,
  fecha       DATE NOT NULL,
  total       DECIMAL(10,2) NOT NULL DEFAULT 0,
  CONSTRAINT fk_venta_pedido FOREIGN KEY (ID_pedido) REFERENCES Pedido(ID_pedido),
  CONSTRAINT fk_venta_cliente FOREIGN KEY (ID_cliente) REFERENCES Cliente(ID_cliente),
  CONSTRAINT fk_venta_usuario FOREIGN KEY (ID_usuario) REFERENCES Usuario(ID_usuario)
);

CREATE TABLE Detalle_Venta (
  ID_detalle_venta  INT AUTO_INCREMENT PRIMARY KEY,
  ID_venta          INT NOT NULL,
  ID_variante       INT NOT NULL,
  cantidad          INT NOT NULL,
  precio_unitario   DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_detventa_venta FOREIGN KEY (ID_venta) REFERENCES Venta(ID_venta),
  CONSTRAINT fk_detventa_variante FOREIGN KEY (ID_variante) REFERENCES Producto_Variante(ID_variante)
);

-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 
-- 8. Pagos
-- -!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-! 

CREATE TABLE Pago (
  ID_pago         INT AUTO_INCREMENT PRIMARY KEY,
  ID_venta        INT NOT NULL,
  fecha           DATE NOT NULL,
  monto           DECIMAL(10,2) NOT NULL,
  tipo_pago       VARCHAR(60),  -- sena / parcial / saldo / total
  metodo_pago     VARCHAR(60),  -- efectivo / transferencia / tarjeta
  num_operacion   VARCHAR(50),
  CONSTRAINT fk_pago_venta FOREIGN KEY (ID_venta) REFERENCES Venta(ID_venta)
);

-- Podria cambiar el tipo_pago | metodo_pago por ENUM, pero puede que un cliente eliga 2 metodos de pago o inclusive mas.

-- 9. Produccion


CREATE TABLE Produccion (
  ID_produccion       INT AUTO_INCREMENT PRIMARY KEY,
  ID_pedido           INT NULL,  -- nullable: produccion de stock sin pedido puntual
  fecha_inicio        DATE,
  fecha_fin_estimada  DATE,
  fecha_fin_real      DATE,
  estado              VARCHAR(30),
  observaciones       VARCHAR(255),
  CONSTRAINT fk_produccion_pedido FOREIGN KEY (ID_pedido) REFERENCES Pedido(ID_pedido)
);

CREATE TABLE Tanda_Produccion (
  ID_tanda               INT AUTO_INCREMENT PRIMARY KEY,
  ID_produccion          INT NOT NULL,
  ID_variante            INT NOT NULL,
  cantidad_planificada   INT NOT NULL,
  cantidad_producida     INT NOT NULL DEFAULT 0,
  CONSTRAINT fk_tanda_produccion FOREIGN KEY (ID_produccion) REFERENCES Produccion(ID_produccion),
  CONSTRAINT fk_tanda_variante FOREIGN KEY (ID_variante) REFERENCES Producto_Variante(ID_variante)
);

CREATE TABLE Proceso (
  ID_proceso  INT AUTO_INCREMENT PRIMARY KEY,
  nombre      VARCHAR(50) NOT NULL,
  orden       INT NOT NULL
);

CREATE TABLE Seguimiento_Produccion (
  ID_seguimiento     INT AUTO_INCREMENT PRIMARY KEY,
  ID_tanda           INT NOT NULL,
  ID_proceso         INT NOT NULL,
  cantidad           INT NOT NULL DEFAULT 0,
  estado             VARCHAR(30),
  fecha_inicio       DATE,
  fecha_finalizacion DATE,
  observaciones      VARCHAR(255),
  CONSTRAINT fk_seguimiento_tanda FOREIGN KEY (ID_tanda) REFERENCES Tanda_Produccion(ID_tanda),
  CONSTRAINT fk_seguimiento_proceso FOREIGN KEY (ID_proceso) REFERENCES Proceso(ID_proceso)
);

-- Inserta los dos roles correspondientes.

INSERT INTO Rol (nombre_rol) VALUES ('Jefe/Admin'), ('Empleada');

-- Inserta los procesos correspondientes.

INSERT INTO Proceso (nombre, orden) VALUES
  ('Corte', 1),
  ('Confeccion', 2),
  ('Bordado/Estampado', 3),
  ('Control', 4),
  ('Terminado', 5);

  -- Por que existe 2 modelos "kaban"? Bueno, mi idea principal es ver 2 seguimientos del proceso, uno que sea eficaz, y otra mas tecnica para la empleada y jefa del taller.
  -- Cliente viene, pregunta por su pedido, la empleada ve y dice "esta en produccion"
  -- Aunque el cliente no utilice el programa, es facilmente visible en que estado se encuentra el PEDIDO ('pendiente','en_produccion','listo_para_retirar','entregado')
  --  Y en caso de que la empleada quiera ver como esta la tanda de productos y no sabe por donde seguir, mira el programa y ve "Corte", sabiendo que le falta los demas pasos