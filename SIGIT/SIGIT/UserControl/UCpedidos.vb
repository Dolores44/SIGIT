Imports System.IO
Imports System.Windows.Forms.Design
Imports MySqlConnector
Public Class UCpedidos

    Sub Cargarpedidos(Optional filtro As String = "")
        'Creo subrutina para cargar pedidos
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'cargo consulta
                Dim consulta As String = "SELECT pe.ID_pedido AS Nropedido,
                                          pe.ID_Cliente,
                                          pe.fecha_pedido AS Fecha, 
                                          pe.fecha_entrega_prevista AS FechaEntrega, 
                                          pe.estado AS Estado, 
                                          cli.nombre, 
                                          pe.observaciones as Observaciones" &
                                          " FROM pedido AS pe " &
                                          "JOIN  Cliente AS cli ON pe.ID_Cliente = cli.ID_cliente"

                'Esto es para buscar por nombre de cliente

                If String.IsNullOrEmpty(buscartxt.Text) Then
                    consulta = consulta &
                               " ORDER BY ID_cliente;"
                Else
                    consulta = consulta &
                               " WHERE ID_cliente Like @cliente " &
                               " ORDER BY ID_cliente;"
                End If

                Using cmd As New MySqlCommand(consulta, cn) 'Evito SQL injection

                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")

                    Dim tabla As New DataTable 'Creo variable tabla, para dejar los datos de la base aca

                    Using lector As MySqlDataReader = cmd.ExecuteReader 'Leo los datos y ejecuta el comando
                        tabla.Load(lector)
                    End Using
                    dgwpedidos.DataSource = tabla 'asigno datos a la tabla

                    If (dgwpedidos.Columns.Contains("ID_cliente")) Then 'Si la columna contiene ID_CLIENTE
                        dgwpedidos.Columns("ID_cliente").Visible = False 'entonces, cambiamos la propiedad y lo hacemos invisible
                    End If
                End Using

            End Using
        Catch ex As Exception

            MessageBox.Show("Error en la carga de pedidos " & ex.Message)

        End Try

    End Sub

    Private Sub Cargarcombo() 'Cargo Estados al combo box, para luego filtrar con eso
        Try
            Using CN As New MySqlConnection(CADENA)
                CN.Open()
                Dim sql As String = "SELECT COLUMN_TYPE  
                                    FROM INFORMATION_SCHEMA.COLUMNS " & 'Busca un metadato (¿Que es? Un metadato es un dato sobre otro dato, aca busca el dato de ESTADO DE PEDIDO de PEDIDO sobre la BD de sigit :)
                                    "WHERE TABLE_SCHEMA = 'sigit'  
                                    AND TABLE_NAME = 'pedido' 
                                    AND COLUMN_NAME = 'estado';"

                'Agarro estado y el ID que lo acopla
                Using cmd As New MySqlCommand(sql, CN)
                    Dim tabla As New DataTable()

                    Dim resultado As String = cmd.ExecuteScalar().ToString() 'El executescalar trae un resultado, es decir, lo que hay en el
                    'ENUM de la base de datos

                    resultado = resultado.Replace("enum(", "").Replace(")", "") ' Sacamos el () de ENUM
                    resultado = resultado.Replace("'", "")  ' Le sacamos las comillas simples
                    ' Ahora resultado ess lo que hay en el ENUM de la base de datos, osea el estado

                    ' Al hacer un SCHEMA, sacamos los datos como esta puesto en la tabla dentro de la base de datos
                    ' Osea, que nos trae el dato completo: enum('pendiente','en_produccion','listo_para_retirar','entregado')
                    'Se remplaza para sacar enum y comillas simples, al ponerlo al combobox aparece bien



                    Dim estadopedido() As String = resultado.Split(","c)
                    'un array para el enum
                    comboestado.Items.Clear()
                    comboestado.Items.Add("Todos") 'El todos que saldria si no seleccionas nada

                    For Each valorestado As String In estadopedido 'Un for each bien papurrico, para recorer el ENUM de la base de datos
                        comboestado.Items.Add(valorestado) ' cargar las opciones
                    Next

                    comboestado.SelectedIndex = 0 'index 0 de todos

                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try





    End Sub




    Private Sub UCpedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llamo grilla personalizada del modulo GrillaPers, aplico a dgwpedidos
        GrillaPers.Personalizargrilla(dgwpedidos)

        buscartxt.PlaceholderText = "Cliente o Nro"
        'Cargo grilla al cargar formulario
        Cargarpedidos()
        Cargarcombo()


    End Sub


End Class
