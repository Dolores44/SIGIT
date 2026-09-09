Imports MySqlConnector
Module Conexion
    'Modulo de conexión de BD
    Public Const CADENA As String =
    "Server=localhost;Port=3306;Database=SIGIT;" &
    "User ID=sigit_app;Password=12345"
    Public Function NuevaConexion() As MySqlConnection
        Return New MySqlConnection(CADENA)
    End Function

End Module
