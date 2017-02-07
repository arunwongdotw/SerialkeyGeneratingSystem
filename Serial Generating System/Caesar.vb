Imports System.Text

Public Class Caesar

    Private shift As Integer

    Public Sub New()
        Me.New(New System.Random().Next(1, 25))
    End Sub

    Public Sub New(ByVal shift As Integer)
        Me.shift = shift
    End Sub

    Public Function getShift() As Integer
        Return shift
    End Function

    Public Shared Function encript(ByVal text As String, ByVal shift As String) As String
        Dim strEncript As New System.Text.StringBuilder()
        For Each c As Char In text
            If Asc(c) = 45 Then
                strEncript.Append("-")
            ElseIf Char.IsLower(c) Then
                strEncript.Append(Chr((((Asc(c) Mod Asc("a")) + shift) Mod 26) + Asc("a")))
            ElseIf Char.IsUpper(c) Then
                strEncript.Append(Chr((((Asc(c) Mod Asc("A")) + shift) Mod 26) + Asc("A")))
            ElseIf Char.IsNumber(c) Then
                strEncript.Append(Chr(Asc("A") + (Asc(c) Mod 48) + (shift Mod 26)))
            End If
        Next
        Return strEncript.ToString
    End Function

    Public Shared Function decript(ByVal text As String, ByVal shift As String) As String
        Dim strDecript As New System.Text.StringBuilder()
        Dim index As Integer
        For Each c As Char In text
            index = Asc(c) + (shift Mod 26)
            If Char.IsUpper(c) Then
                strDecript.Append(Chr(Asc("Z") - ((Asc("Z") Mod Asc(c)) + shift) Mod 26))
            ElseIf Char.IsLower(c) Then
                strDecript.Append(Chr(Asc("z") - ((Asc("z") Mod Asc(c)) + shift) Mod 26))
            End If
        Next
        Return strDecript.ToString
    End Function


    Public Function encript(ByVal text As String) As String
        Dim strEncript As New System.Text.StringBuilder()
        For Each c As Char In text
            If Char.IsLower(c) Then
                strEncript.Append(Chr((((Asc(c) Mod Asc("a")) + shift) Mod 26) + Asc("a")))
            ElseIf Char.IsUpper(c) Then
                strEncript.Append(Chr((((Asc(c) Mod Asc("A")) + shift) Mod 26) + Asc("A")))
            ElseIf Char.IsNumber(c) Then
                strEncript.Append(Chr(Asc("A") + (Asc(c) Mod 48) + (shift Mod 26)))
            End If
        Next
        Return strEncript.ToString
    End Function
    Public Function decript(ByVal text As String) As String
        Dim strDecript As New System.Text.StringBuilder()
        Dim index As Integer
        For Each c As Char In text
            index = Asc(c) + (shift Mod 26)
            If Char.IsUpper(c) Then
                strDecript.Append(Chr(Asc("Z") - ((Asc("Z") Mod Asc(c)) + shift) Mod 26))
            ElseIf Char.IsLower(c) Then
                strDecript.Append(Chr(Asc("z") - ((Asc("z") Mod Asc(c)) + shift) Mod 26))
            End If
        Next
        Return strDecript.ToString
    End Function

    Public Shared Function decriptToNumber(ByVal text As String, ByVal shift As String) As String
        Dim strDecript As New System.Text.StringBuilder()
        Dim index As Integer
        For Each c As Char In text
            index = Asc(c) + (shift Mod 26)
            strDecript.Append(Chr((Asc("Z") - ((Asc("Z") Mod Asc(c)) - shift) Mod 26) - 17))
        Next
        Return strDecript.ToString
    End Function

End Class
