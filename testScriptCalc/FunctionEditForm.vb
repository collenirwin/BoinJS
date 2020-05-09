Imports System.IO
Imports System.Drawing.Text

Public Class FunctionEditForm

#Region "Vars"

    ' text from the file
    Dim strFileString As String

#End Region

#Region "Main"

    Private Sub frmFunctionEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load the global functions file into the editor if it exists
        If File.Exists(Form1.GlobalFunctionsPath) Then
            Try
                txtMain.Text = File.ReadAllText(Form1.GlobalFunctionsPath)
            Catch ex As Exception
                MessageBox.Show("Failed to open global functions file with the following exception:" &
                    Environment.NewLine & ex.Message)
            End Try
        End If

        ' keep track of what was originally in the file
        strFileString = txtMain.Text
    End Sub

    Private Sub txtMain_PaintLine(sender As Object, e As FastColoredTextBoxNS.PaintLineEventArgs) Handles txtMain.PaintLine
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias ' Smoooooth
    End Sub

    Private Sub frmFunctionEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' if changes were made
        If txtMain.Text <> strFileString Then

            ' let the user know before closing
            If Not Form1.PromptYesOrNo("Close without saving?") Then
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

        ' attempt save to our designated location
        Try
            Using W As StreamWriter = File.CreateText(Form1.GlobalFunctionsPath)
                W.Write(txtMain.Text)
            End Using

            ' load the file into the interpeter
            Form1.AddGlobFunctions()

            ' set our new saved file text
            strFileString = txtMain.Text
        Catch ex As Exception

            ' couldn't save the file
            MessageBox.Show("Failed to save global functions file with the following exception:" &
                Environment.NewLine & ex.Message)
        End Try
    End Sub

#End Region

End Class
