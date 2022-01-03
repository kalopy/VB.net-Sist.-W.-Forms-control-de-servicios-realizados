<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbDC = New System.Windows.Forms.GroupBox()
        Me.lblCodCliente = New System.Windows.Forms.Label()
        Me.nudCodCliente = New System.Windows.Forms.NumericUpDown()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblRuc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.gbGrande = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.gbServicios = New System.Windows.Forms.GroupBox()
        Me.lstServicios = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvServicioCliente = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dvwServicios = New System.Data.DataView()
        Me.gbDC.SuspendLayout()
        CType(Me.nudCodCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrande.SuspendLayout()
        Me.gbServicios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvServicioCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvwServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDC
        '
        Me.gbDC.Controls.Add(Me.lblCodCliente)
        Me.gbDC.Controls.Add(Me.nudCodCliente)
        Me.gbDC.Controls.Add(Me.dtpFecha)
        Me.gbDC.Controls.Add(Me.lblFecha)
        Me.gbDC.Controls.Add(Me.lblRuc)
        Me.gbDC.Controls.Add(Me.lblNombre)
        Me.gbDC.Controls.Add(Me.lblR)
        Me.gbDC.Controls.Add(Me.lblNom)
        Me.gbDC.Location = New System.Drawing.Point(12, 12)
        Me.gbDC.Name = "gbDC"
        Me.gbDC.Size = New System.Drawing.Size(776, 100)
        Me.gbDC.TabIndex = 0
        Me.gbDC.TabStop = False
        Me.gbDC.Text = "Datos del cliente"
        '
        'lblCodCliente
        '
        Me.lblCodCliente.AutoSize = True
        Me.lblCodCliente.Location = New System.Drawing.Point(6, 32)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.Size = New System.Drawing.Size(64, 13)
        Me.lblCodCliente.TabIndex = 9
        Me.lblCodCliente.Text = "Cod. Cliente"
        '
        'nudCodCliente
        '
        Me.nudCodCliente.Location = New System.Drawing.Point(76, 30)
        Me.nudCodCliente.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCodCliente.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCodCliente.Name = "nudCodCliente"
        Me.nudCodCliente.Size = New System.Drawing.Size(120, 20)
        Me.nudCodCliente.TabIndex = 8
        Me.nudCodCliente.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(473, 61)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(372, 67)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(95, 13)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Fecha Realizacion"
        '
        'lblRuc
        '
        Me.lblRuc.AutoSize = True
        Me.lblRuc.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblRuc.Location = New System.Drawing.Point(191, 67)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(0, 13)
        Me.lblRuc.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNombre.Location = New System.Drawing.Point(56, 67)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblNombre.TabIndex = 4
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(155, 67)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(30, 13)
        Me.lblR.TabIndex = 3
        Me.lblR.Text = "RUC"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(6, 67)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(44, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nombre"
        '
        'gbGrande
        '
        Me.gbGrande.Controls.Add(Me.lblTotal)
        Me.gbGrande.Controls.Add(Me.lblTot)
        Me.gbGrande.Controls.Add(Me.gbServicios)
        Me.gbGrande.Controls.Add(Me.GroupBox1)
        Me.gbGrande.Controls.Add(Me.btnAgregar)
        Me.gbGrande.Location = New System.Drawing.Point(12, 130)
        Me.gbGrande.Name = "gbGrande"
        Me.gbGrande.Size = New System.Drawing.Size(776, 271)
        Me.gbGrande.TabIndex = 1
        Me.gbGrande.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(469, 241)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 20)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.ForeColor = System.Drawing.Color.Green
        Me.lblTot.Location = New System.Drawing.Point(393, 241)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(49, 20)
        Me.lblTot.TabIndex = 5
        Me.lblTot.Text = "Total"
        '
        'gbServicios
        '
        Me.gbServicios.Controls.Add(Me.lstServicios)
        Me.gbServicios.Location = New System.Drawing.Point(6, 35)
        Me.gbServicios.Name = "gbServicios"
        Me.gbServicios.Size = New System.Drawing.Size(249, 211)
        Me.gbServicios.TabIndex = 0
        Me.gbServicios.TabStop = False
        Me.gbServicios.Text = "Servicios"
        '
        'lstServicios
        '
        Me.lstServicios.FormattingEnabled = True
        Me.lstServicios.Location = New System.Drawing.Point(6, 17)
        Me.lstServicios.Name = "lstServicios"
        Me.lstServicios.Size = New System.Drawing.Size(237, 186)
        Me.lstServicios.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvServicioCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(375, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 199)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicios agregados"
        '
        'dgvServicioCliente
        '
        Me.dgvServicioCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicioCliente.Location = New System.Drawing.Point(6, 19)
        Me.dgvServicioCliente.Name = "dgvServicioCliente"
        Me.dgvServicioCliente.Size = New System.Drawing.Size(361, 174)
        Me.dgvServicioCliente.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(270, 108)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 40)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(700, 407)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 40)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbGrande)
        Me.Controls.Add(Me.gbDC)
        Me.Name = "Form1"
        Me.Text = "Taller - ""La electromecanica"""
        Me.gbDC.ResumeLayout(False)
        Me.gbDC.PerformLayout()
        CType(Me.nudCodCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrande.ResumeLayout(False)
        Me.gbGrande.PerformLayout()
        Me.gbServicios.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvServicioCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvwServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDC As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvServicioCliente As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblRuc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblR As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTot As Label
    Friend WithEvents gbGrande As GroupBox
    Friend WithEvents gbServicios As GroupBox
    Friend WithEvents lstServicios As ListBox
    Friend WithEvents dvwServicios As DataView
    Friend WithEvents nudCodCliente As NumericUpDown
    Friend WithEvents lblCodCliente As Label
End Class
