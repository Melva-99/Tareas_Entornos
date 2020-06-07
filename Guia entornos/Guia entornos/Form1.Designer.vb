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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pcalculadora = New System.Windows.Forms.PictureBox()
        Me.Pformula = New System.Windows.Forms.PictureBox()
        Me.Palmacen = New System.Windows.Forms.PictureBox()
        Me.PNumero = New System.Windows.Forms.PictureBox()
        Me.Pdeduccion = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pcalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pformula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Palmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pdeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BIENVENIDO AL SISTEMA"
        '
        'Pcalculadora
        '
        Me.Pcalculadora.Image = CType(resources.GetObject("Pcalculadora.Image"), System.Drawing.Image)
        Me.Pcalculadora.Location = New System.Drawing.Point(55, 86)
        Me.Pcalculadora.Name = "Pcalculadora"
        Me.Pcalculadora.Size = New System.Drawing.Size(129, 100)
        Me.Pcalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pcalculadora.TabIndex = 3
        Me.Pcalculadora.TabStop = False
        '
        'Pformula
        '
        Me.Pformula.Image = CType(resources.GetObject("Pformula.Image"), System.Drawing.Image)
        Me.Pformula.Location = New System.Drawing.Point(285, 86)
        Me.Pformula.Name = "Pformula"
        Me.Pformula.Size = New System.Drawing.Size(129, 100)
        Me.Pformula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pformula.TabIndex = 4
        Me.Pformula.TabStop = False
        '
        'Palmacen
        '
        Me.Palmacen.Image = CType(resources.GetObject("Palmacen.Image"), System.Drawing.Image)
        Me.Palmacen.Location = New System.Drawing.Point(168, 232)
        Me.Palmacen.Name = "Palmacen"
        Me.Palmacen.Size = New System.Drawing.Size(129, 100)
        Me.Palmacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Palmacen.TabIndex = 5
        Me.Palmacen.TabStop = False
        '
        'PNumero
        '
        Me.PNumero.Image = CType(resources.GetObject("PNumero.Image"), System.Drawing.Image)
        Me.PNumero.Location = New System.Drawing.Point(55, 360)
        Me.PNumero.Name = "PNumero"
        Me.PNumero.Size = New System.Drawing.Size(129, 100)
        Me.PNumero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PNumero.TabIndex = 6
        Me.PNumero.TabStop = False
        '
        'Pdeduccion
        '
        Me.Pdeduccion.Image = CType(resources.GetObject("Pdeduccion.Image"), System.Drawing.Image)
        Me.Pdeduccion.Location = New System.Drawing.Point(285, 360)
        Me.Pdeduccion.Name = "Pdeduccion"
        Me.Pdeduccion.Size = New System.Drawing.Size(129, 100)
        Me.Pdeduccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pdeduccion.TabIndex = 7
        Me.Pdeduccion.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Calculadora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Números"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Almacén"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fórmula Cuadrática"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 475)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Deducción"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(460, 500)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pdeduccion)
        Me.Controls.Add(Me.PNumero)
        Me.Controls.Add(Me.Palmacen)
        Me.Controls.Add(Me.Pformula)
        Me.Controls.Add(Me.Pcalculadora)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Menú"
        CType(Me.Pcalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pformula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Palmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pdeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Pcalculadora As PictureBox
    Friend WithEvents Pformula As PictureBox
    Friend WithEvents Palmacen As PictureBox
    Friend WithEvents PNumero As PictureBox
    Friend WithEvents Pdeduccion As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
End Class
