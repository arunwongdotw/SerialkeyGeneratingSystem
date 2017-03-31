Imports System.IO
Imports System.Text

Imports System.CodeDom.Compiler
Imports System.Diagnostics
Imports Microsoft.CSharp


Public Class testSaveDLL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "dll files (*.dll)|*.dll"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'myStream = saveFileDialog1.OpenFile()

            'Dim a As String = saveFileDialog1.FileName


            'If (myStream IsNot Nothing) Then
            ' Code to write the stream goes here.

            'Dim codeProvider As New VBCodeProvider()
            'Dim icc As ICodeCompiler = codeProvider.CreateCompiler
            'Dim parameters As New CompilerParameters()
            'Dim results As CompilerResults

            'parameters.GenerateExecutable = True
            'parameters.OutputAssembly = "autogen.Dll"
            'results = icc.CompileAssemblyFromSource(parameters, "aaa")
            Dim bw As BinaryWriter
            Dim s As String = "Imports System.Management" & vbCrLf
            s &= "Imports System.Net" & vbCrLf
            s &= "Imports System.IO" & vbCrLf
            s &= "Imports System.Text" & vbCrLf
            s &= "Imports System.Security.Cryptography" & vbCrLf
            s &= "Public Class encrypt" & vbCrLf
            s &= "Private Shared DES As New TripleDESCryptoServiceProvider" & vbCrLf
            s &= "Private Shared MD5 As New MD5CryptoServiceProvider" & vbCrLf
            bw = New BinaryWriter(New FileStream(saveFileDialog1.FileName, FileMode.Create))
            bw.Write(s)
            bw.Close()
            'Dim output As New IO.StreamWriter(saveFileDialog1.FileName)

            'output1.Write(True)
            'Write lines of text to the file.
            'output.WriteLine("This is a line of text.")
            'output.WriteLine("This is another line of text.")

            'Close the file.
            'output.Close()


            'myStream.Close()
        End If
        'End If
        'Dim a As String = saveFileDialog1.FileName
        'Dim savedata As New System.IO.StreamWriter(a)
        'Dim savedata1 As System.IO.BinaryWriter


        'savedata.WriteLine("กฟหกฟหกฟหกฟหกฟกห")
        'savedata.Encoding("กฟหกฟหกฟหกฟหกฟกห")

        'savedata.Close()




    End Sub
End Class