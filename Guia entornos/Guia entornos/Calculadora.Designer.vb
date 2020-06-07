<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnCero = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ltHistorial = New System.Windows.Forms.ListBox()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(6, 47)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(51, 38)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(63, 47)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(51, 38)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(120, 47)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(51, 38)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(6, 91)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(51, 38)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(63, 91)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(51, 38)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(120, 91)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(51, 38)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(6, 135)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(51, 38)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(63, 135)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(51, 38)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(120, 135)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(51, 38)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnCero
        '
        Me.btnCero.Location = New System.Drawing.Point(6, 179)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(51, 38)
        Me.btnCero.TabIndex = 9
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(51, 38)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPunto
        '
        Me.btnPunto.Location = New System.Drawing.Point(120, 179)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(51, 38)
        Me.btnPunto.TabIndex = 11
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(177, 179)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(51, 38)
        Me.btnSuma.TabIndex = 15
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(177, 135)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(51, 38)
        Me.btnResta.TabIndex = 14
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(177, 91)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(51, 38)
        Me.btnMult.TabIndex = 13
        Me.btnMult.Text = "x"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(177, 47)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(51, 38)
        Me.btnDiv.TabIndex = 12
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(6, 7)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(222, 34)
        Me.txtResultado.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ltHistorial)
        Me.Panel1.Controls.Add(Me.btnIgual)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.txtResultado)
        Me.Panel1.Controls.Add(Me.btn1)
        Me.Panel1.Controls.Add(Me.btn2)
        Me.Panel1.Controls.Add(Me.btn3)
        Me.Panel1.Controls.Add(Me.btnSuma)
        Me.Panel1.Controls.Add(Me.btn4)
        Me.Panel1.Controls.Add(Me.btnResta)
        Me.Panel1.Controls.Add(Me.btn5)
        Me.Panel1.Controls.Add(Me.btnMult)
        Me.Panel1.Controls.Add(Me.btn6)
        Me.Panel1.Controls.Add(Me.btnDiv)
        Me.Panel1.Controls.Add(Me.btn7)
        Me.Panel1.Controls.Add(Me.btnPunto)
        Me.Panel1.Controls.Add(Me.btn8)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btn9)
        Me.Panel1.Controls.Add(Me.btnCero)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 261)
        Me.Panel1.TabIndex = 19
        '
        'ltHistorial
        '
        Me.ltHistorial.FormattingEnabled = True
        Me.ltHistorial.Location = New System.Drawing.Point(243, 47)
        Me.ltHistorial.Name = "ltHistorial"
        Me.ltHistorial.Size = New System.Drawing.Size(121, 212)
        Me.ltHistorial.TabIndex = 22
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(63, 179)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(51, 38)
        Me.btnIgual.TabIndex = 21
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.Location = New System.Drawing.Point(6, 220)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(71, 38)
        Me.Button17.TabIndex = 20
        Me.Button17.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(243, 7)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 34)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "    Historial"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(385, 288)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnCero As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents ltHistorial As ListBox
End Class
