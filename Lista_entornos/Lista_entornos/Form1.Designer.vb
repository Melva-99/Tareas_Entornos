﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmblista = New System.Windows.Forms.ComboBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmblista
        '
        Me.cmblista.FormattingEnabled = True
        Me.cmblista.Items.AddRange(New Object() {"Montagua", "Real España", "Olimpia", "Chelsea", "Man United", "B.Dortmund"})
        Me.cmblista.Location = New System.Drawing.Point(48, 46)
        Me.cmblista.Name = "cmblista"
        Me.cmblista.Size = New System.Drawing.Size(121, 21)
        Me.cmblista.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(73, 108)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 179)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cmblista)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmblista As ComboBox
    Friend WithEvents btnMostrar As Button
End Class
