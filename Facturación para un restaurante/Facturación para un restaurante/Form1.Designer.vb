<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPupusas = New System.Windows.Forms.CheckBox()
        Me.chkPastel = New System.Windows.Forms.CheckBox()
        Me.chkBaleadas = New System.Windows.Forms.CheckBox()
        Me.chkTacos = New System.Windows.Forms.CheckBox()
        Me.chkArroz = New System.Windows.Forms.CheckBox()
        Me.chkSopa = New System.Windows.Forms.CheckBox()
        Me.chkChuleta = New System.Windows.Forms.CheckBox()
        Me.chkPollo = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTortillas = New System.Windows.Forms.CheckBox()
        Me.chkCarne = New System.Windows.Forms.CheckBox()
        Me.chkEnsalada = New System.Windows.Forms.CheckBox()
        Me.chkTajadas = New System.Windows.Forms.CheckBox()
        Me.chkChapsui = New System.Windows.Forms.CheckBox()
        Me.chkAguacate = New System.Windows.Forms.CheckBox()
        Me.chkHuevo = New System.Windows.Forms.CheckBox()
        Me.chkPapas = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.list1 = New System.Windows.Forms.ListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbebida = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.chkPupusas)
        Me.GroupBox1.Controls.Add(Me.chkPastel)
        Me.GroupBox1.Controls.Add(Me.chkBaleadas)
        Me.GroupBox1.Controls.Add(Me.chkTacos)
        Me.GroupBox1.Controls.Add(Me.chkArroz)
        Me.GroupBox1.Controls.Add(Me.chkSopa)
        Me.GroupBox1.Controls.Add(Me.chkChuleta)
        Me.GroupBox1.Controls.Add(Me.chkPollo)
        Me.GroupBox1.Controls.Add(Me.chkHam)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(185, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menú Principal"
        '
        'chkPupusas
        '
        Me.chkPupusas.AutoSize = True
        Me.chkPupusas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPupusas.Location = New System.Drawing.Point(391, 119)
        Me.chkPupusas.Name = "chkPupusas"
        Me.chkPupusas.Size = New System.Drawing.Size(80, 24)
        Me.chkPupusas.TabIndex = 8
        Me.chkPupusas.Text = "Pupusas"
        Me.chkPupusas.UseVisualStyleBackColor = True
        '
        'chkPastel
        '
        Me.chkPastel.AutoSize = True
        Me.chkPastel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPastel.Location = New System.Drawing.Point(391, 79)
        Me.chkPastel.Name = "chkPastel"
        Me.chkPastel.Size = New System.Drawing.Size(86, 24)
        Me.chkPastel.TabIndex = 7
        Me.chkPastel.Text = "Pastelitos"
        Me.chkPastel.UseVisualStyleBackColor = True
        '
        'chkBaleadas
        '
        Me.chkBaleadas.AutoSize = True
        Me.chkBaleadas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBaleadas.Location = New System.Drawing.Point(391, 38)
        Me.chkBaleadas.Name = "chkBaleadas"
        Me.chkBaleadas.Size = New System.Drawing.Size(84, 24)
        Me.chkBaleadas.TabIndex = 6
        Me.chkBaleadas.Text = "Baleadas"
        Me.chkBaleadas.UseVisualStyleBackColor = True
        '
        'chkTacos
        '
        Me.chkTacos.AutoSize = True
        Me.chkTacos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTacos.Location = New System.Drawing.Point(205, 119)
        Me.chkTacos.Name = "chkTacos"
        Me.chkTacos.Size = New System.Drawing.Size(133, 24)
        Me.chkTacos.TabIndex = 5
        Me.chkTacos.Text = "Tacos Mexicanos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkTacos.UseVisualStyleBackColor = True
        '
        'chkArroz
        '
        Me.chkArroz.AutoSize = True
        Me.chkArroz.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArroz.Location = New System.Drawing.Point(205, 79)
        Me.chkArroz.Name = "chkArroz"
        Me.chkArroz.Size = New System.Drawing.Size(98, 24)
        Me.chkArroz.TabIndex = 4
        Me.chkArroz.Text = "Arroz Chino" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkArroz.UseVisualStyleBackColor = True
        '
        'chkSopa
        '
        Me.chkSopa.AutoSize = True
        Me.chkSopa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSopa.Location = New System.Drawing.Point(205, 38)
        Me.chkSopa.Name = "chkSopa"
        Me.chkSopa.Size = New System.Drawing.Size(108, 24)
        Me.chkSopa.TabIndex = 3
        Me.chkSopa.Text = "Sopa de Res"
        Me.chkSopa.UseVisualStyleBackColor = True
        '
        'chkChuleta
        '
        Me.chkChuleta.AutoSize = True
        Me.chkChuleta.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChuleta.Location = New System.Drawing.Point(25, 119)
        Me.chkChuleta.Name = "chkChuleta"
        Me.chkChuleta.Size = New System.Drawing.Size(72, 24)
        Me.chkChuleta.TabIndex = 2
        Me.chkChuleta.Text = "Chuleta"
        Me.chkChuleta.UseVisualStyleBackColor = True
        '
        'chkPollo
        '
        Me.chkPollo.AutoSize = True
        Me.chkPollo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPollo.Location = New System.Drawing.Point(25, 79)
        Me.chkPollo.Name = "chkPollo"
        Me.chkPollo.Size = New System.Drawing.Size(89, 24)
        Me.chkPollo.TabIndex = 1
        Me.chkPollo.Text = "Pollo Frito"
        Me.chkPollo.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHam.Location = New System.Drawing.Point(25, 38)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(111, 24)
        Me.chkHam.TabIndex = 0
        Me.chkHam.Text = "Hamburguesa"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.chkTortillas)
        Me.GroupBox2.Controls.Add(Me.chkCarne)
        Me.GroupBox2.Controls.Add(Me.chkEnsalada)
        Me.GroupBox2.Controls.Add(Me.chkTajadas)
        Me.GroupBox2.Controls.Add(Me.chkChapsui)
        Me.GroupBox2.Controls.Add(Me.chkAguacate)
        Me.GroupBox2.Controls.Add(Me.chkHuevo)
        Me.GroupBox2.Controls.Add(Me.chkPapas)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(185, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Complementos"
        '
        'chkTortillas
        '
        Me.chkTortillas.AutoSize = True
        Me.chkTortillas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTortillas.Location = New System.Drawing.Point(298, 72)
        Me.chkTortillas.Name = "chkTortillas"
        Me.chkTortillas.Size = New System.Drawing.Size(73, 24)
        Me.chkTortillas.TabIndex = 8
        Me.chkTortillas.Text = "Tortillas"
        Me.chkTortillas.UseVisualStyleBackColor = True
        '
        'chkCarne
        '
        Me.chkCarne.AutoSize = True
        Me.chkCarne.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCarne.Location = New System.Drawing.Point(130, 72)
        Me.chkCarne.Name = "chkCarne"
        Me.chkCarne.Size = New System.Drawing.Size(63, 24)
        Me.chkCarne.TabIndex = 7
        Me.chkCarne.Text = "Carne"
        Me.chkCarne.UseVisualStyleBackColor = True
        '
        'chkEnsalada
        '
        Me.chkEnsalada.AutoSize = True
        Me.chkEnsalada.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnsalada.Location = New System.Drawing.Point(391, 92)
        Me.chkEnsalada.Name = "chkEnsalada"
        Me.chkEnsalada.Size = New System.Drawing.Size(83, 24)
        Me.chkEnsalada.TabIndex = 6
        Me.chkEnsalada.Text = "Ensalada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkEnsalada.UseVisualStyleBackColor = True
        '
        'chkTajadas
        '
        Me.chkTajadas.AutoSize = True
        Me.chkTajadas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTajadas.Location = New System.Drawing.Point(391, 44)
        Me.chkTajadas.Name = "chkTajadas"
        Me.chkTajadas.Size = New System.Drawing.Size(74, 24)
        Me.chkTajadas.TabIndex = 5
        Me.chkTajadas.Text = "Tajadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkTajadas.UseVisualStyleBackColor = True
        '
        'chkChapsui
        '
        Me.chkChapsui.AutoSize = True
        Me.chkChapsui.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChapsui.Location = New System.Drawing.Point(216, 92)
        Me.chkChapsui.Name = "chkChapsui"
        Me.chkChapsui.Size = New System.Drawing.Size(76, 24)
        Me.chkChapsui.TabIndex = 4
        Me.chkChapsui.Text = "Chapsui"
        Me.chkChapsui.UseVisualStyleBackColor = True
        '
        'chkAguacate
        '
        Me.chkAguacate.AutoSize = True
        Me.chkAguacate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAguacate.Location = New System.Drawing.Point(216, 44)
        Me.chkAguacate.Name = "chkAguacate"
        Me.chkAguacate.Size = New System.Drawing.Size(84, 24)
        Me.chkAguacate.TabIndex = 3
        Me.chkAguacate.Text = "Aguacate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkAguacate.UseVisualStyleBackColor = True
        '
        'chkHuevo
        '
        Me.chkHuevo.AutoSize = True
        Me.chkHuevo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHuevo.Location = New System.Drawing.Point(25, 92)
        Me.chkHuevo.Name = "chkHuevo"
        Me.chkHuevo.Size = New System.Drawing.Size(67, 24)
        Me.chkHuevo.TabIndex = 2
        Me.chkHuevo.Text = "Huevo"
        Me.chkHuevo.UseVisualStyleBackColor = True
        '
        'chkPapas
        '
        Me.chkPapas.AutoSize = True
        Me.chkPapas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPapas.Location = New System.Drawing.Point(25, 44)
        Me.chkPapas.Name = "chkPapas"
        Me.chkPapas.Size = New System.Drawing.Size(97, 24)
        Me.chkPapas.TabIndex = 1
        Me.chkPapas.Text = "Papas fritas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkPapas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Melva's Restaurant"
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPagar.Location = New System.Drawing.Point(864, 510)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(110, 42)
        Me.btnPagar.TabIndex = 10
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(388, 603)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 42)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar Pedido"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'list1
        '
        Me.list1.HideSelection = False
        Me.list1.Location = New System.Drawing.Point(363, 445)
        Me.list1.Name = "list1"
        Me.list1.Size = New System.Drawing.Size(160, 140)
        Me.list1.TabIndex = 1
        Me.list1.UseCompatibleStateImageBehavior = False
        Me.list1.View = System.Windows.Forms.View.List
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtCod)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtHora)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(802, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(383, 225)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturación"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(115, 79)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(181, 26)
        Me.txtTotal.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total a pagar:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(83, 171)
        Me.txtCod.Mask = "9999"
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(65, 26)
        Me.txtCod.TabIndex = 13
        Me.txtCod.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha y Hora:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(88, 33)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 22)
        Me.txtNombre.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(121, 124)
        Me.txtHora.Mask = "00/00/0000 00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(121, 26)
        Me.txtHora.TabIndex = 7
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevo.Location = New System.Drawing.Point(1024, 510)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(121, 42)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Pedido"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(857, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 38)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Factura del pedido"
        '
        'ErrorFactura
        '
        Me.ErrorFactura.ContainerControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 541)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 104)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(391, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 38)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Pedido"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(1180, -2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 42)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "X"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(849, 98)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(181, 30)
        Me.txtCantidad.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(905, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 38)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cantidad"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(1050, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 42)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtbebida
        '
        Me.txtbebida.Location = New System.Drawing.Point(849, 144)
        Me.txtbebida.Multiline = True
        Me.txtbebida.Name = "txtbebida"
        Me.txtbebida.Size = New System.Drawing.Size(181, 33)
        Me.txtbebida.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1220, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtbebida)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.list1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Melva's Restaurant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkSopa As CheckBox
    Friend WithEvents chkChuleta As CheckBox
    Friend WithEvents chkPollo As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkPupusas As CheckBox
    Friend WithEvents chkPastel As CheckBox
    Friend WithEvents chkBaleadas As CheckBox
    Friend WithEvents chkTacos As CheckBox
    Friend WithEvents chkArroz As CheckBox
    Friend WithEvents chkTortillas As CheckBox
    Friend WithEvents chkCarne As CheckBox
    Friend WithEvents chkEnsalada As CheckBox
    Friend WithEvents chkTajadas As CheckBox
    Friend WithEvents chkChapsui As CheckBox
    Friend WithEvents chkAguacate As CheckBox
    Friend WithEvents chkHuevo As CheckBox
    Friend WithEvents chkPapas As CheckBox
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents list1 As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHora As MaskedTextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorFactura As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbebida As TextBox
End Class
