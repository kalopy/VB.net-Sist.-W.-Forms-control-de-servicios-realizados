Imports System.Data.SqlClient
Public Class Form1

    '1. Codifique el evento Load del Formulario :
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = "data source = KALO; initial catalog = OT_Electro; 
                                     user id = kalo; password = kalo"
        CargarLista()
        CargarGrilla()
    End Sub

    '1.1. Cargar los servicios al listbox correspondiente. (5 puntos). 
    Private Sub CargarLista()
        Try
            lstServicios.DataSource = generar_datatabla("select * from Servicio")
            lstServicios.DisplayMember = "Descripcion"
            lstServicios.ValueMember = "CodServicio"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '2. Codifique el evento Leave del control que contiene el código del cliente 
    Private Sub nudCodCliente_Leave(sender As Object, e As EventArgs) Handles nudCodCliente.Leave
        Try
            Dim tabla As New DataTable
            '2.1. Verificar si existe el cliente con el código ingresado. (5 puntos). 
            tabla = generar_datatabla("select * from Cliente where CodCliente = '" + nudCodCliente.Text + "'")
            '2.2. Si existe, mostrar los datos del cliente en las etiquetas correspondientes. (5 puntos). 
            If tabla.Rows.Count > 0 Then
                lblNombre.Text = tabla.Rows(0).Item("NombreApellido")
                lblRuc.Text = tabla.Rows(0).Item("Ruc")
                '2.3. Si no existe, mostrar un mensaje al usuario. (5 puntos). 
            Else
                lblNombre.Text = " "
                lblRuc.Text = " "
                lblTotal.Text = " "
                MsgBox("El cliente no existe")
                nudCodCliente.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '3. Codifique el evento Click del botón “Agregar”

    '3.1. Validar que el cliente exista. (5 puntos). 
    Private Function ValidarClienteExista(ByVal CodCliente As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim tabla As New DataTable
            tabla = generar_datatabla("select * from Cliente where CodCliente = '" & CodCliente & "'")
            If tabla.Rows.Count > 0 Then
                resultado = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

    '3.2. Validar la seleccion del tipo de servicio. (5 puntos)
    Private Function ValidarSeleccionTipoServicio() As Boolean
        If (lstServicios.SelectedIndex.Equals(-1)) Then
            MessageBox.Show("Debe seleccionar el tipo de servicio")
            Return False
        End If
        Return True
    End Function

    '3.3. Obtener el costo del servicio seleccionado en el listbox de servicios. (5 puntos). 
    Private Function RecuperarCosto() As Decimal

        Dim tabla As New DataTable
        Dim Costo As Decimal
        Try
            tabla = generar_datatabla("select Costo from Servicio where Descripcion = '" + lstServicios.GetItemText(lstServicios.SelectedItem) + "'")
            If tabla.Rows.Count > 0 Then
                Costo = tabla.Rows(0).Item("Costo")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Costo
    End Function

    Private Function RecuperarCodServicio() As Integer

        Dim tabla As New DataTable
        Dim CodServicio As Integer
        Try
            tabla = generar_datatabla("select CodServicio from Servicio where Descripcion = '" + lstServicios.GetItemText(lstServicios.SelectedItem) + "'")
            If tabla.Rows.Count > 0 Then
                CodServicio = tabla.Rows(0).Item("CodServicio")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return CodServicio
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If ValidarClienteExista(nudCodCliente.Text) = True And ValidarSeleccionTipoServicio() = True Then
                Dim codServicio As Integer = RecuperarCodServicio()
                Dim codCliente As Integer = nudCodCliente.Text
                Dim costo As Decimal = RecuperarCosto()
                Dim fecha As Date = dtpFecha.Value
                '3.4. Insertar el servicio para el cliente. (10 puntos). 
                EjecutarSQL("insert ServicioCliente values (@1,@2,@3,@4)", codServicio, codCliente, costo, fecha)
                '3.5. Cargar la grilla de servicios realizados del cliente. (5 puntos) 
                CargarGrilla()
                '3.6. Acumular el total del costo en la etiqueta lblTotalCosto. (5 puntos). 
                lblTotal.Text = CostTotal().ToString

                MsgBox("Servicio insertado")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '3.5. Cargar la grilla de servicios realizados del cliente. (5 puntos) 
    Private Sub CargarGrilla()
        Try
            dvwServicios.Table = generar_datatabla("select a.Descripcion as Servicio,a.Costo,b.FechaRealizacion 
                                                    from Servicio a join ServicioCliente b 
                                                    on a.CodServicio = b.CodServicio")
            dgvServicioCliente.DataSource = dvwServicios
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '3.6. Acumular el total del costo en la etiqueta lblTotalCosto. (5 puntos).
    Private Function CostTotal() As Decimal

        Dim tabla As New DataTable
        Dim CostoTotal As Decimal
        Try
            tabla = generar_datatabla("select sum(Costo) as CostoTotal from ServicioCliente where CodCliente = '" + nudCodCliente.Text + "'")
            If tabla.Rows.Count > 0 Then
                CostoTotal = tabla.Rows(0).Item("CostoTotal")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return CostoTotal
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
        End If
    End Sub


End Class
