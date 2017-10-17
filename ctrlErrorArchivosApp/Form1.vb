Imports System.IO
Public Class Form1

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        Dim dialogoGuardar As New SaveFileDialog
        If dialogoGuardar.ShowDialog() = DialogResult.OK Then
            txtNomArchivo.Text = dialogoGuardar.FileName
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim archivo As StreamWriter
        Try
            archivo = New StreamWriter(txtNomArchivo.Text)
            Dim strLinea As String
            For Each strLinea In txtTexto.Lines
                archivo.WriteLine(strLinea)
            Next
            MessageBox.Show("Texto escrito, sin excepciones")
        Catch ex As Exception
            Dim msg As String = String.Format("Error al guardar: {0}\n Stack Trace:\n {1}", _
            ex.Message, ex.StackTrace)
            MessageBox.Show(msg, ex.GetType().ToString())
        Finally
            If Not archivo Is Nothing Then
                archivo.Close()
            End If
            MessageBox.Show("El bloque Finally siempre se ejecuta, aun no ocurren excepciones")
        End Try
    End Sub
End Class
