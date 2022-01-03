Imports System.Data.SqlClient
Module acceso_datos
    'Creamos el objeto de conexi�n

    Public _ComandoBD As SqlCommand
    Public drDataReader As SqlDataReader

    Public conexion As New SqlConnection
    'Funci�n para recuperar registros de la base de datos (select)
    Public Function generar_datatabla(comando_sql As String) As DataTable
        'Definos una tabla temporal
        'para guardar el resultado del comando sql
        Dim tabla As New DataTable("Mabel")
        Try
            'Vericamos si la conexi�n actual esta cerrada
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            'Creamos el objeto para el comando sql
            Dim cmd As New SqlCommand(comando_sql, conexion)
            'Creamos el objeto para el adaptador de datos
            Dim adaptador As New SqlDataAdapter(cmd)
            'Llenamos el temporal con los resultados de la consulta
            adaptador.Fill(tabla)
            'Finalmente retornamos el resultado
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function generar_datatabla(comando_sql As String, ByRef dbtransac As SqlTransaction) As DataTable
        'Definos una tabla temporal
        'para guardar el resultado del comando sql
        Dim tabla As New DataTable("Mabel")
        Try
            'Vericamos si la conexi�n actual esta cerrada
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            'Creamos el objeto para el comando sql
            Dim cmd As New SqlCommand(comando_sql, conexion, dbtransac)
            'Creamos el objeto para el adaptador de datos
            Dim adaptador As New SqlDataAdapter(cmd)
            'Llenamos el temporal con los resultados de la consulta
            adaptador.Fill(tabla)
            'Finalmente retornamos el resultado
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Procedimiento para insertar, eliminar y actualizar 
    'un regustro en la base de datos
    Public Sub EjecutarSQL(comando_sql As String, ParamArray Arrayparametros() As Object)
        Try
            'Abrimos la conexi�n si esta cerrada
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            'Creamos el objeto para el comando sql
            Dim cmd As New SqlCommand(comando_sql, conexion)
            'Recuperamos la lista de parametros del array
            For i As Integer = 1 To Arrayparametros.Length
                cmd.Parameters.AddWithValue("@" & i.ToString, Arrayparametros(i - 1))
            Next
            'Finalmente ejecutamos el comando sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   Public Sub EjecutarSQL(instruccion_SQL As String, ByRef dbtransac As SqlTransaction, ParamArray parametros() As Object)
        Try
            Dim comando As New SqlCommand(instruccion_SQL, conexion, dbtransac)
            'cargar par�metros desde el array hacia la instrucci�n SQL
            For i As Integer = 1 To parametros.Length
                'nombre del par�metro y valor
                comando.Parameters.AddWithValue("@" & i.ToString(), parametros(i - 1))
            Next
            'ejecutar el comando
            comando.ExecuteNonQuery()
        Catch ex As Exception
            AnularTransaccion(dbtransac)
            Throw ex
        End Try
    End Sub
    'Funci�n para iniciar una transacci�n
    Public Function IniciarTransaccion() As SqlTransaction
        Try
            'Iniciar y retornar una transacci�n
            Return conexion.BeginTransaction
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    'Procedimiento para anular una transacci�n
    Public Sub AnularTransaccion(ByRef dbt As SqlTransaction)
        Try
            dbt.Rollback()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ConfirmarTransaccion(ByRef dbt As SqlTransaction)
        Try
            'Confirmar la transacci�n
            dbt.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function TraerValor(comando_sql As String) As Object
        Try
            Dim cmd As New SqlCommand(comando_sql, conexion)
            Return cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function TraerValor(instruccionSQL As String, ByRef dbtransac As SqlTransaction) As Object
        Try
            Dim cmd As New SqlCommand(instruccionSQL, conexion, dbtransac)
            'ExecuteScalar retorna el valor de la primera celda devuelta por la consulta.
            Return cmd.ExecuteScalar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Module
