Imports System.IO

Public Class frmFunctionEdit

#Region "Vars"

    Dim strFileString As String

#End Region

#Region "Main"

    Private Sub frmFunctionEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Form1.STR_GLOBAL_FUNCTIONS_FILEPATH) Then
            txtMain.Text = ""
            Using R As StreamReader = File.OpenText(Form1.STR_GLOBAL_FUNCTIONS_FILEPATH)
                While R.Peek <> -1
                    txtMain.Text &= R.ReadLine() & vbCrLf
                End While
            End Using
        End If
        strFileString = txtMain.Text
    End Sub

    Private Sub txtMain_PaintLine(sender As Object, e As FastColoredTextBoxNS.PaintLineEventArgs) Handles txtMain.PaintLine
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias ' Smoooooth
    End Sub

    Private Sub frmFunctionEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If txtMain.Text <> strFileString Then
            If Form1.msg("Close without saving?") = False Then
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region "ToolStrip/MenuStrip Stuff"

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click, UndoToolStripMenuItem1.Click
        txtMain.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click, RedoToolStripMenuItem1.Click
        txtMain.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtMain.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtMain.Paste()
    End Sub

    Private Sub ResetZoomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetZoomToolStripMenuItem1.Click, ResetZoomToolStripMenuItem.Click
        txtMain.Zoom = 100
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click, FindToolStripMenuItem1.Click
        txtMain.ShowFindDialog()
    End Sub

    Private Sub FindReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindReplaceToolStripMenuItem.Click, FindReplaceToolStripMenuItem1.Click
        txtMain.ShowReplaceDialog()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Using W As StreamWriter = File.CreateText(Form1.STR_GLOBAL_FUNCTIONS_FILEPATH)
            W.Write(txtMain.Text)
        End Using
        Form1.AddGlobFunctions()
        strFileString = txtMain.Text
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Form1.ShowHelp("globalfunctions")
    End Sub

#End Region
   
End Class