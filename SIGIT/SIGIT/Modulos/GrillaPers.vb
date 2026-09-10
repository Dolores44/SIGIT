Module GrillaPers
    'Para personalziar las grillas, como la de pedidos, clientes, productos (creo, estamos en proceso ahre 10/9
    Sub Personalizargrilla(dvg As DataGridView)
        'Todo esto cambia las propiedades del objeto, en vez de hacerlo uno por uno en cada dvg, o en vez de copiarlo y pegarlo, es preferible codificarlo, ahorro de tiempo
        dvg.BackgroundColor = Color.GhostWhite 'Color general que utilizo en todos los froms
        dvg.BorderStyle = BorderStyle.None 'Saca los borders (lineas negras
        dvg.GridColor = Color.FromArgb(230, 230, 230)
        dvg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal 'Solo deja la linea horizontal |
        dvg.RowHeadersVisible = False 'Es para sacar la fila vacia de la izquierda de los DataGrid predeterminados

        'Encabezaado, donde van los nombres de los campos

        dvg.EnableHeadersVisualStyles = False
        dvg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 45, 58) 'Es el color del programa
        dvg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dvg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dvg.ColumnHeadersHeight = 40
        dvg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        'filas normales 

        dvg.DefaultCellStyle.SelectionForeColor = Color.Black
        dvg.DefaultCellStyle.Font = New Font("Segoe UI", 9.5)
        dvg.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
        dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230) 'Celeste
        dvg.DefaultCellStyle.BackColor = Color.White
        dvg.RowTemplate.Height = 32

        'Colores alternativos, que varie en tabla y tabla
        dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250)


        dvg.AllowUserToResizeRows = False
        dvg.AllowUserToResizeColumns = False
        dvg.AllowUserToOrderColumns = False
        dvg.AllowUserToAddRows = False  'Eso hacia que si apretabas la tabla vacia de abajo, aumente un ID_Pedido (FUE REVISADO ESTO EN TABLA PEDIDOS)
        dvg.ReadOnly = True



    End Sub
End Module
