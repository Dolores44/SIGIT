Module Validaciones
    'Hago una funcion de validaciones grobal para ahorrar codigo en caso de verificar.
    Public Function Validaciones(Caja As TextBox, Errorlbl As Label, nombrecampo As String) As Boolean
        'Verifico con un IF
        If String.IsNullOrWhiteSpace(Caja.Text) Then
            Errorlbl.Text = nombrecampo & " no puede estar vacio"
            Caja.Focus()
            'El visible es porque el LABEL ERROR va a estar invisible, si salta error, lo activa
            Errorlbl.Visible = True
            Return False

        End If
        'Hago false porsi se vuelve a ejectutar. no siga apareicendo el mensaje de error
        Errorlbl.Visible = False
        Return True
    End Function


End Module
