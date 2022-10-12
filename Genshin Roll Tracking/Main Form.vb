Option Explicit On
Option Strict On
Option Infer Off
' Name:         <Name of the program>
' Purpose:      <Purpose of the program>
' Programmer:   Joshua Steege on <date>


Imports System.ComponentModel

Public Class frmMain
    Dim intRolls(1) As Integer

    Private Sub UpdateCounter()
        UpdateFile()
        ' Updates the labels with the number of rolls left until pity
        txt4Star.Text = intRolls(0).ToString
        txt5Star.Text = intRolls(1).ToString
    End Sub

    Private Sub UpdateFile()
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("GenshinRollLog.txt")

        For intSub As Integer = 0 To intRolls.GetUpperBound(0)
            outFile.WriteLine(intRolls(intSub))
        Next intSub

        outFile.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim inFile As IO.StreamReader

        If IO.File.Exists("GenshinRollLog.txt") Then
            inFile = IO.File.OpenText("GenshinRollLog.txt")
            For intSub As Integer = 0 To intRolls.GetUpperBound(0)
                Integer.TryParse(inFile.ReadLine, intRolls(intSub))
            Next intSub
            inFile.Close()
            UpdateCounter()
        Else
            intRolls(0) = 10
            intRolls(1) = 90
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        UpdateCounter()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        UpdateCounter()
        Me.Close()
    End Sub

    Private Sub btn3star_Click(sender As Object, e As EventArgs) Handles btn3star.Click
        intRolls(0) -= 1
        intRolls(1) -= 1
        UpdateCounter()
    End Sub

    Private Sub btn4star_Click(sender As Object, e As EventArgs) Handles btn4star.Click
        intRolls(0) = 10
        intRolls(1) -= 1
        UpdateCounter()
    End Sub

    Private Sub btn5star_Click(sender As Object, e As EventArgs) Handles btn5star.Click
        intRolls(0) = 10
        intRolls(1) = 90
        UpdateCounter()
    End Sub
End Class
