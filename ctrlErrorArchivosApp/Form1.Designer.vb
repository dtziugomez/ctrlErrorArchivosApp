<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNomArchivo = New System.Windows.Forms.TextBox
        Me.btnExaminar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtTexto = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExaminar)
        Me.GroupBox1.Controls.Add(Me.txtNomArchivo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre del Archivo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTexto)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Texto a Guardar"
        '
        'txtNomArchivo
        '
        Me.txtNomArchivo.Location = New System.Drawing.Point(6, 30)
        Me.txtNomArchivo.Name = "txtNomArchivo"
        Me.txtNomArchivo.Size = New System.Drawing.Size(265, 20)
        Me.txtNomArchivo.TabIndex = 0
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(302, 30)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Examinar..."
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(333, 292)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(6, 19)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(384, 124)
        Me.txtTexto.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 327)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents txtNomArchivo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button

End Class
