Imports System.IO
Imports FastColoredTextBoxNS

Public Class Form1

#Region "Vars"

    ' Constants
    Public Const STR_GLOBAL_FUNCTIONS_FILEPATH As String = "globalfunctions.js"
    Public Const STR_VERSION_NUM As String = "2.0.1"

    ' Colors for Output
    Dim clrOutput = Color.LightGray
    Dim clrOutBack = Color.FromArgb(255, 60, 60, 60)
    Dim clrPassed = Color.LightBlue
    Dim clrError = Color.LightCoral
    Dim clrDefaultBack = Color.FromArgb(255, 45, 45, 45)

    ' Line Number for Output
    Dim lineNum As Integer = 0

    ' Output Number
    Dim intOutputNumber As UInt32 = 0

    ' Settings Bools
    Dim bStarted As Boolean = False
    Dim bShowOutputNum As Boolean = False

#End Region

#Region "Form Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            chkTopmost.Checked = My.Settings.Topmost
            tsiTopmost.Checked = My.Settings.Topmost
            Me.TopMost = My.Settings.Topmost

            ShowOutputNumberToolStripMenuItem.Checked = My.Settings.ShowOutputNum
            bShowOutputNum = My.Settings.ShowOutputNum

            AddGlobFunctions()

            bStarted = True
        Catch
            MessageBox.Show("Cannot find settings file or settings file is corrupt. Some settings may be off.", "BoinJS")
        End Try
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtInput.Zoom = 100
        txtOutput.ZoomFactor = 1.0F
        If txtInput.Text = "" Then btnRun.Enabled = False
        txtInput.Focus()
        txtInput.SelectAll()
    End Sub

#End Region

#Region "General UI Control Events and Supporting Functions"

    ' Enable/disable the run button based on whether there's text in the input box
    Private Sub txtInput_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtInput.TextChanged
        btnRun.Enabled = (txtInput.Text.Trim() <> "")
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        CallScript()
    End Sub

    Private Sub RunScript(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnRun.KeyDown, btnClearAll.KeyDown, btnClearIn.KeyDown, btnClearOut.KeyDown, txtInput.KeyDown, Me.KeyDown
        If btnRun.Enabled And e.KeyCode = Keys.F5 Then _
            CallScript()
    End Sub

    ' ------------------------------------ '

    ' General function for a yes/no messagebox
    Public Function msg(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "BoinJS", MessageBoxButtons.YesNo) = DialogResult.Yes
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click, ClearAllToolStripMenuItem.Click
        If msg("Are you sure you want to clear all text fields?") Then
            txtInput.Text = ""
            txtOutput.Text = ""
            txtInput.Focus()
        End If
    End Sub

    Private Sub btnClearOut_Click(sender As Object, e As EventArgs) Handles btnClearOut.Click, ClearOutputToolStripMenuItem.Click, ToolStripMenuItem3.Click
        If msg("Are you sure you want to clear the output field?") Then
            txtOutput.Text = ""
            txtInput.Focus()
        End If
    End Sub

    Private Sub btnClearIn_Click(sender As Object, e As EventArgs) Handles btnClearIn.Click, ClearInputToolStripMenuItem.Click, ClearToolStripMenuItem.Click
        If msg("Are you sure you want to clear the input field?") Then
            txtInput.Text = ""
            txtInput.Focus()
        End If
    End Sub

    ' ------------------------------------ '

    ' Toggling the topmost setting
    Private Sub chkTopmost_CheckedChanged(sender As Object, e As EventArgs) Handles chkTopmost.CheckedChanged
        If bStarted Then
            tsiTopmost.Checked = chkTopmost.Checked
            My.Settings.Topmost = chkTopmost.Checked
            Me.TopMost = chkTopmost.Checked
        End If
    End Sub

    ' ------------------------------------ '

    ' Draws the line between panels in the splitcontainer
    Private Sub spltContainer_Paint(sender As Object, e As PaintEventArgs) Handles spltContainer.Paint
        Dim s As SplitContainer = sender
        e.Graphics.FillRectangle(Brushes.Silver, s.SplitterRectangle.X, s.SplitterDistance, s.SplitterRectangle.Width, s.SplitterWidth)
    End Sub

    ' Super smooth text rendering!
    Private Sub txtInput_PaintLine(sender As Object, e As PaintLineEventArgs) Handles txtInput.PaintLine
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
    End Sub

#End Region

#Region "ToolStrip/MenuStrip Item Events"

    Private Sub tsiTopmost_Click(sender As Object, e As EventArgs) Handles tsiTopmost.Click
        If bStarted Then
            chkTopmost.Checked = tsiTopmost.Checked
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click, FindToolStripMenuItem1.Click
        txtInput.ShowFindDialog()
    End Sub

    Private Sub FindReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindReplaceToolStripMenuItem.Click, FindReplaceToolStripMenuItem1.Click
        txtInput.ShowReplaceDialog()
    End Sub

    Private Sub GlobalFunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalFunctionsToolStripMenuItem.Click
        frmFunctionEdit.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ofd1.Title = ofd1.Tag
        ofd1.ShowDialog()
    End Sub

    Private Sub OpenAppendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAppendToolStripMenuItem.Click
        ofd1.Title = ofd1.Tag & " + Append"
        ofd1.ShowDialog()
    End Sub

    ' Attempts to save
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If lblFilePath.Text = lblFilePath.Tag Then ' Unsaved
            sfd1.ShowDialog() ' Show Save As dialog
        Else ' We know the file name
            SaveFile(lblFilePath.Text) ' Save
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        sfd1.ShowDialog()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtInput.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtInput.Paste()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        txtOutput.Copy()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    ' Toggles ShowOutputNum setting
    Private Sub ShowOutputNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowOutputNumberToolStripMenuItem.Click
        If bStarted Then
            My.Settings.ShowOutputNum = ShowOutputNumberToolStripMenuItem.Checked
            bShowOutputNum = ShowOutputNumberToolStripMenuItem.Checked
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click, UndoToolStripMenuItem1.Click
        txtInput.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click, RedoToolStripMenuItem1.Click
        txtInput.Redo()
    End Sub

    Private Sub ResetAllZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetZoomToolStripMenuItem.Click
        txtInput.Zoom = 100
        ResetStubbornUglyAnnoyingWindowsRichTextBox()
    End Sub

    Private Sub ResetZoomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetZoomToolStripMenuItem1.Click
        txtInput.Zoom = 100
    End Sub

    Private Sub ResetStubbornUglyAnnoyingWindowsRichTextBox()
        ' wow - this hack is actually needed
        ' txtOutput.ZoomFactor = 1.0 does not work

        While txtOutput.ZoomFactor > 1.0
            txtOutput.ZoomFactor -= 0.01
        End While
        While txtOutput.ZoomFactor < 1.0
            txtOutput.ZoomFactor += 0.01
        End While
    End Sub

    Private Sub ResetZoomToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ResetZoomToolStripMenuItem2.Click
        ResetStubbornUglyAnnoyingWindowsRichTextBox()
    End Sub

#End Region

#Region "Script Evaluation"

    Private Sub ResetScriptControl()
        scrpt1.Reset() ' Clear all code from the script control
        AddGlobFunctions() ' Add in the global functions
    End Sub

    ' Prints line num for output
    Private Function GetLineNum() As String
        Return " Line " & lineNum & ": "
    End Function

    ' Adds the global functions that are defined by the user in frmFunctionsEdit to the script control
    Public Sub AddGlobFunctions()
        If File.Exists(STR_GLOBAL_FUNCTIONS_FILEPATH) Then
            Dim s As String = ""
            Using R As StreamReader = File.OpenText(STR_GLOBAL_FUNCTIONS_FILEPATH)
                While R.Peek <> -1
                    s &= R.ReadLine() & vbCrLf
                End While
            End Using
            Try
                scrpt1.AddCode(s)
            Catch ex As Exception
                MessageBox.Show("Script errored out with the following message: " & ex.Message, "BoinJS - Error")
            End Try

        End If
    End Sub

    Private Sub PrintOutputNumber()

        AppendOutput("Output", Color.LightGray, clrOutBack)

        Dim s As String = "["

        If intOutputNumber = UInt32.MaxValue - 1 Then
            intOutputNumber = 0
            s &= "reset - "
        End If

        If bShowOutputNum Then
            intOutputNumber += 1
            s &= intOutputNumber & "]"
            AppendOutput(s, Color.Wheat, clrOutBack)
        End If

        AppendOutput(":" & vbCrLf, Color.LightGray, clrOutBack)
    End Sub

    Private Sub AppendOutput(text As String, color As Color, backColor As Color)
        txtOutput.SelectionStart = txtOutput.TextLength
        txtOutput.SelectionLength = 0

        txtOutput.SelectionColor = color
        txtOutput.SelectionBackColor = backColor
        txtOutput.AppendText(text)
    End Sub

    Private Sub CallScript()
        lineNum = 0
        Try
            PrintOutputNumber()

            Dim bIsCode As Boolean = False

            For x = 0 To txtInput.Lines.Count - 1
                Dim line As String = Trim(txtInput.Lines(x))
                lineNum += 1
                If line <> "" And line.StartsWith("//") = False Then
                    bIsCode = True
                    Dim out As String = scrpt1.Eval(line)
                    If out = "" Then
                        out = "null"
                    End If
                    AppendOutput(GetLineNum(), clrOutput, clrDefaultBack)
                    AppendOutput(out & vbCrLf, clrPassed, clrDefaultBack)
                End If
            Next
            If bIsCode = False Then
                AppendOutput(" null" & vbCrLf, clrPassed, clrDefaultBack)
            End If

        Catch ex As Exception
            AppendOutput(GetLineNum(), clrOutput, clrDefaultBack)
            AppendOutput(ex.Message & vbCrLf, Color.LightCoral, clrDefaultBack)
        End Try

        scrpt1.Reset()
        AddGlobFunctions()

        txtOutput.SelectionStart = txtOutput.Text.Count - 1
        txtOutput.ScrollToCaret()
    End Sub

#End Region

#Region "Files and IO"

    Private Sub ofd1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd1.FileOk
        If Not ofd1.Title.Contains("Append") Then
            If txtInput.Text.Trim() <> "" Then
                If msg("Would you like to save the current file first?") Then
                    If lblFilePath.Text = lblFilePath.Tag Then
                        sfd1.ShowDialog()
                    Else
                        SaveFile(lblFilePath.Text)
                    End If
                End If
            End If
            txtInput.Text = ""
        Else
            txtInput.Text &= vbCrLf
        End If

        Dim path As String = ofd1.FileName
        If File.Exists(path) Then
            Try
                Using R As StreamReader = File.OpenText(path)
                    While R.Peek <> -1
                        txtInput.Text &= R.ReadLine() & vbCrLf
                    End While
                End Using
                SetPath(path)
            Catch
                MessageBox.Show("Failed to open '" & path & "'.", "BoinJS - Error")
            End Try
        End If
    End Sub

    Private Sub SetPath(path As String)
        Me.Text = Me.Tag & " - " & path
        lblFilePath.Text = path
    End Sub

    Private Sub SaveFile(path As String)
        Try
            Using W As StreamWriter = File.CreateText(path)
                W.Write(txtInput.Text)
            End Using
            SetPath(path)
        Catch
            MessageBox.Show("Failed to save file to '" & path & "'.", "BoinJS - Error")
        End Try
    End Sub

    Private Sub sfd1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd1.FileOk
        SaveFile(sfd1.FileName)
    End Sub

#End Region

End Class