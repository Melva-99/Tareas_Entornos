<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Almacen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Almacen))
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.txtVM = New System.Windows.Forms.TextBox()
        Me.ltSmedia = New System.Windows.Forms.ListBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Items.AddRange(New Object() {"", "Almacén Pájaro Azul", "Ferretería Javier", "Almacén La Chela", "Dinant", "Pulpería El flaco", "Tienda La Confianza", "Confitería", "Comercial Lainez", "Variedades Los dos hermanos", "Mangy´s Store"})
        Me.cmbAlmacen.Location = New System.Drawing.Point(60, 61)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(121, 21)
        Me.cmbAlmacen.TabIndex = 0
        '
        'txtM
        '
        Me.txtM.Enabled = False
        Me.txtM.Location = New System.Drawing.Point(70, 263)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(100, 20)
        Me.txtM.TabIndex = 2
        '
        'txtVM
        '
        Me.txtVM.Location = New System.Drawing.Point(70, 128)
        Me.txtVM.Name = "txtVM"
        Me.txtVM.Size = New System.Drawing.Size(100, 20)
        Me.txtVM.TabIndex = 4
        '
        'ltSmedia
        '
        Me.ltSmedia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ltSmedia.Location = New System.Drawing.Point(236, 61)
        Me.ltSmedia.Name = "ltSmedia"
        Me.ltSmedia.Size = New System.Drawing.Size(146, 260)
        Me.ltSmedia.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnCalcular.Location = New System.Drawing.Point(85, 316)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 27)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(85, 182)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 11
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Seleccione el almacén"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Venta mensual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Media" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Venta Mensual Superior" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(388, 305)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(441, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(40, 43)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnregresar.BackgroundImage = CType(resources.GetObject("btnregresar.BackgroundImage"), System.Drawing.Image)
        Me.btnregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnregresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnregresar.Location = New System.Drawing.Point(3, 342)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(46, 45)
        Me.btnregresar.TabIndex = 18
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(487, 390)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.ltSmedia)
        Me.Controls.Add(Me.txtVM)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Almacen"
        Me.Text = "Almacén"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAlmacen As ComboBox
    Friend WithEvents txtM As TextBox
    Friend WithEvents txtVM As TextBox
    Friend WithEvents ltSmedia As ListBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnregresar As Button
End Class
