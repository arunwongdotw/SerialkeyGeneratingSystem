Imports System.IO
Imports System.Text


Public Class testSaveDLL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "dll files (*.dll)|*.dll"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            
            If (myStream IsNot Nothing) Then
                ' Code to write the stream goes here.
                myStream.Close()
            End If
        End If
        Dim a As String = saveFileDialog1.FileName
        Dim savedata As New System.IO.StreamWriter(a)
        savedata.WriteLine("กฟหกฟหกฟหกฟหกฟกห")

        savedata.Close()
    End Sub
End Class