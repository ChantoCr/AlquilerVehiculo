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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnSIGPS = New System.Windows.Forms.RadioButton()
        Me.rbtnNoGPS = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnBasico = New System.Windows.Forms.RadioButton()
        Me.rbtnCompleto = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantDias = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumPasaporte = New System.Windows.Forms.TextBox()
        Me.lvMetodos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtSeguro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTarifaDiaria = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxPasajeros = New System.Windows.Forms.ComboBox()
        Me.txtGPS = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cbxPasajeros)
        Me.Panel1.Controls.Add(Me.txtTarifaDiaria)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCantDias)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPlaca)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(47, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 160)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de Placa:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(484, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 109)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(484, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 112)
        Me.Panel3.TabIndex = 2
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(151, 19)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(181, 20)
        Me.txtPlaca.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GPS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnNoGPS)
        Me.GroupBox1.Controls.Add(Me.rbtnSIGPS)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rbtnSIGPS
        '
        Me.rbtnSIGPS.AutoSize = True
        Me.rbtnSIGPS.Location = New System.Drawing.Point(7, 3)
        Me.rbtnSIGPS.Name = "rbtnSIGPS"
        Me.rbtnSIGPS.Size = New System.Drawing.Size(36, 17)
        Me.rbtnSIGPS.TabIndex = 0
        Me.rbtnSIGPS.TabStop = True
        Me.rbtnSIGPS.Text = "Sí"
        Me.rbtnSIGPS.UseVisualStyleBackColor = True
        '
        'rbtnNoGPS
        '
        Me.rbtnNoGPS.AutoSize = True
        Me.rbtnNoGPS.Location = New System.Drawing.Point(7, 37)
        Me.rbtnNoGPS.Name = "rbtnNoGPS"
        Me.rbtnNoGPS.Size = New System.Drawing.Size(39, 17)
        Me.rbtnNoGPS.TabIndex = 1
        Me.rbtnNoGPS.TabStop = True
        Me.rbtnNoGPS.Text = "No"
        Me.rbtnNoGPS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seguro"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnCompleto)
        Me.GroupBox2.Controls.Add(Me.rbtnBasico)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rbtnBasico
        '
        Me.rbtnBasico.AutoSize = True
        Me.rbtnBasico.Location = New System.Drawing.Point(7, 0)
        Me.rbtnBasico.Name = "rbtnBasico"
        Me.rbtnBasico.Size = New System.Drawing.Size(57, 17)
        Me.rbtnBasico.TabIndex = 0
        Me.rbtnBasico.TabStop = True
        Me.rbtnBasico.Text = "Básico"
        Me.rbtnBasico.UseVisualStyleBackColor = True
        '
        'rbtnCompleto
        '
        Me.rbtnCompleto.AutoSize = True
        Me.rbtnCompleto.Location = New System.Drawing.Point(7, 35)
        Me.rbtnCompleto.Name = "rbtnCompleto"
        Me.rbtnCompleto.Size = New System.Drawing.Size(69, 17)
        Me.rbtnCompleto.TabIndex = 1
        Me.rbtnCompleto.TabStop = True
        Me.rbtnCompleto.Text = "Completo"
        Me.rbtnCompleto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cantidad de Pasajeros: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cantidad de Días: "
        '
        'txtCantDias
        '
        Me.txtCantDias.Location = New System.Drawing.Point(151, 85)
        Me.txtCantDias.Name = "txtCantDias"
        Me.txtCantDias.Size = New System.Drawing.Size(181, 20)
        Me.txtCantDias.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tarifa Diaria: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Información de Vehículo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Información Personal"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtNumPasaporte)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(47, 254)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 72)
        Me.Panel4.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Número de Pasaporte: "
        '
        'txtNumPasaporte
        '
        Me.txtNumPasaporte.Location = New System.Drawing.Point(148, 19)
        Me.txtNumPasaporte.Name = "txtNumPasaporte"
        Me.txtNumPasaporte.Size = New System.Drawing.Size(191, 20)
        Me.txtNumPasaporte.TabIndex = 1
        '
        'lvMetodos
        '
        Me.lvMetodos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvMetodos.Location = New System.Drawing.Point(48, 350)
        Me.lvMetodos.Name = "lvMetodos"
        Me.lvMetodos.Size = New System.Drawing.Size(636, 171)
        Me.lvMetodos.TabIndex = 0
        Me.lvMetodos.UseCompatibleStateImageBehavior = False
        Me.lvMetodos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Placa"
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Monto Alquiler"
        Me.ColumnHeader2.Width = 107
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Monto Seguro"
        Me.ColumnHeader3.Width = 102
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Monto GPS"
        Me.ColumnHeader4.Width = 102
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Monto Descuento"
        Me.ColumnHeader5.Width = 111
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(721, 26)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "&Agregar"
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agrega el Alquiler")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(721, 65)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 7
        Me.btnMostrar.Text = "&Mostrar"
        Me.ToolTip1.SetToolTip(Me.btnMostrar, "Muestra en la cajita los montos")
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(721, 110)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "Limpia todas las Casillas")
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(721, 150)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "&Salir"
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir del sistema")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtSeguro
        '
        Me.txtSeguro.Location = New System.Drawing.Point(118, 548)
        Me.txtSeguro.Name = "txtSeguro"
        Me.txtSeguro.ReadOnly = True
        Me.txtSeguro.Size = New System.Drawing.Size(117, 20)
        Me.txtSeguro.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 548)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Seguro: "
        '
        'txtTarifaDiaria
        '
        Me.txtTarifaDiaria.Location = New System.Drawing.Point(151, 114)
        Me.txtTarifaDiaria.Name = "txtTarifaDiaria"
        Me.txtTarifaDiaria.Size = New System.Drawing.Size(181, 20)
        Me.txtTarifaDiaria.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(383, 547)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "GPS: "
        '
        'cbxPasajeros
        '
        Me.cbxPasajeros.FormattingEnabled = True
        Me.cbxPasajeros.Items.AddRange(New Object() {"5", "7", "11"})
        Me.cbxPasajeros.Location = New System.Drawing.Point(151, 52)
        Me.cbxPasajeros.Name = "cbxPasajeros"
        Me.cbxPasajeros.Size = New System.Drawing.Size(181, 21)
        Me.cbxPasajeros.TabIndex = 2
        '
        'txtGPS
        '
        Me.txtGPS.Location = New System.Drawing.Point(424, 545)
        Me.txtGPS.Name = "txtGPS"
        Me.txtGPS.ReadOnly = True
        Me.txtGPS.Size = New System.Drawing.Size(131, 20)
        Me.txtGPS.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 595)
        Me.Controls.Add(Me.txtGPS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSeguro)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lvMetodos)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Alquiler de Vehículos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoGPS As RadioButton
    Friend WithEvents rbtnSIGPS As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnBasico As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtnCompleto As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxPasajeros As ComboBox
    Friend WithEvents txtTarifaDiaria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantDias As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtNumPasaporte As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lvMetodos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtSeguro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtGPS As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
