Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS

Public Class Form1

#Region "Vars"

    ' Constants
    Public Const GlobalFunctionsPath As String = "globalfunctions.js"
    Public Const VersionNumber As String = "2.1.0"

    ' Colors for Output
    Private ReadOnly _outputColor = Color.LightGray
    Private ReadOnly _outputBackColor = Color.FromArgb(255, 60, 60, 60)
    Private ReadOnly _passedColor = Color.LightBlue
    Private ReadOnly _errorColor = Color.LightCoral
    Private ReadOnly _defaultBackColor = Color.FromArgb(255, 45, 45, 45)

    Private _outputNumber As UInteger = 0
    Private _started As Boolean = False
    Private _isDirty As Boolean = False
    Private _showOutputNumber As Boolean = False

#End Region

#Region "Form Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            chkTopmost.Checked = My.Settings.Topmost
            tsiTopmost.Checked = My.Settings.Topmost
            TopMost = My.Settings.Topmost

            ShowOutputNumberToolStripMenuItem.Checked = My.Settings.ShowOutputNum
            _showOutputNumber = My.Settings.ShowOutputNum

            AddGlobalFunctions()

            _started = True
        Catch
            MessageBox.Show("Cannot find settings file or settings file is corrupt. Some settings may be off.", "BoinJS")
        End Try
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtInput.Zoom = 100
        txtOutput.ZoomFactor = 1.0F
        btnRun.Enabled = txtInput.Text.Trim() <> ""
        txtInput.Focus()
        txtInput.SelectAll()
    End Sub

#End Region

#Region "General UI Control Events and Supporting Functions"

    Private Sub txtInput_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtInput.TextChanged
        ' Enable/disable the run button based on whether there's text in the input box
        btnRun.Enabled = txtInput.Text.Trim() <> ""
        _isDirty = _started
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        RunScript()
    End Sub

    Private Sub RunScript(sender As Object, e As KeyEventArgs) Handles btnRun.KeyDown, btnClearAll.KeyDown, btnClearIn.KeyDown, btnClearOut.KeyDown, txtInput.KeyDown, Me.KeyDown
        If btnRun.Enabled And e.KeyCode = Keys.F5 Then _
            RunScript()
    End Sub

    ''' <summary>
    ''' Prompts the user with a Yes/No messagebox
    ''' </summary>
    ''' <param name="message">Message to display</param>
    ''' <returns>True if the user clicked Yes</returns>
    Public Function PromptYesOrNo(message As String) As Boolean
        Return MessageBox.Show(message, "BoinJS", MessageBoxButtons.YesNo) = DialogResult.Yes
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click, ClearAllToolStripMenuItem.Click
        If PromptYesOrNo("Are you sure you want to clear all text fields?") Then
            txtInput.Text = ""
            txtOutput.Text = ""
            txtInput.Focus()
        End If
    End Sub

    Private Sub btnClearOut_Click(sender As Object, e As EventArgs) Handles btnClearOut.Click, ClearOutputToolStripMenuItem.Click, ToolStripMenuItem3.Click
        If PromptYesOrNo("Are you sure you want to clear the output field?") Then
            txtOutput.Text = ""
            txtInput.Focus()
        End If
    End Sub

    Private Sub btnClearIn_Click(sender As Object, e As EventArgs) Handles btnClearIn.Click, ClearInputToolStripMenuItem.Click, ClearToolStripMenuItem.Click
        If PromptYesOrNo("Are you sure you want to clear the input field?") Then
            txtInput.Text = ""
            txtInput.Focus()
        End If
    End Sub

    Private Sub chkTopmost_CheckedChanged(sender As Object, e As EventArgs) Handles chkTopmost.CheckedChanged
        If _started Then
            tsiTopmost.Checked = chkTopmost.Checked
            My.Settings.Topmost = chkTopmost.Checked
            TopMost = chkTopmost.Checked
        End If
    End Sub

    Private Sub spltContainer_Paint(sender As Object, e As PaintEventArgs) Handles spltContainer.Paint
        ' Draws the line between panels in the splitcontainer
        Dim s As SplitContainer = sender
        e.Graphics.FillRectangle(Brushes.Silver, s.SplitterRectangle.X, s.SplitterDistance, s.SplitterRectangle.Width, s.SplitterWidth)
    End Sub

    Private Sub txtInput_PaintLine(sender As Object, e As PaintLineEventArgs) Handles txtInput.PaintLine
        ' Super smooth text rendering!
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias
    End Sub

#End Region

#Region "ToolStrip/MenuStrip Item Events"

    Private Sub tsiTopmost_Click(sender As Object, e As EventArgs) Handles tsiTopmost.Click
        If _started Then
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
        FunctionEditForm.Show()
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
        AboutForm.Show()
    End Sub

    ' Toggles ShowOutputNum setting
    Private Sub ShowOutputNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowOutputNumberToolStripMenuItem.Click
        If _started Then
            My.Settings.ShowOutputNum = ShowOutputNumberToolStripMenuItem.Checked
            _showOutputNumber = ShowOutputNumberToolStripMenuItem.Checked
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
        scriptControl.Reset() ' Clear all code from the script control
        AddGlobalFunctions() ' Add in the global functions
    End Sub

    Private Function GetOutputPrefix(text As String) As String
        Return $" {text}: "
    End Function

    Private Function GetOutputPrefix(line As Integer) As String
        Return $" Line {line}: "
    End Function

    ''' <summary>
    ''' Adds the global functions that are defined by the user in
    ''' <see cref="GlobalFunctionsPath"/> to the script control
    ''' </summary>
    Public Sub AddGlobalFunctions()
        If File.Exists(GlobalFunctionsPath) Then
            Dim s As String = ""
            Using R As StreamReader = File.OpenText(GlobalFunctionsPath)
                While R.Peek <> -1
                    s &= R.ReadLine() & Environment.NewLine
                End While
            End Using
            Try
                scriptControl.AddCode(s)
            Catch ex As Exception
                MessageBox.Show("Script errored out with the following message: " & ex.Message, "BoinJS - Error")
            End Try
        End If
    End Sub

    Private Sub PrintOutputNumber()
        AppendOutput("Output", Color.LightGray, _outputBackColor)
        Dim output As String = "["

        ' wow - we're really paranoid here
        If _outputNumber = UInteger.MaxValue - 1 Then
            _outputNumber = 0
            output &= "reset - "
        End If

        If _showOutputNumber Then
            _outputNumber += 1
            output &= _outputNumber & "]"
            AppendOutput(output, Color.Wheat, _outputBackColor)
        End If

        AppendOutput(":" & Environment.NewLine, Color.LightGray, _outputBackColor)
    End Sub

    Private Sub AppendOutput(text As String, color As Color, backColor As Color)
        txtOutput.SelectionStart = txtOutput.TextLength
        txtOutput.SelectionLength = 0

        txtOutput.SelectionColor = color
        txtOutput.SelectionBackColor = backColor
        txtOutput.AppendText(text)
    End Sub

    Private Sub AppendOutputLine(text As String, color As Color, backColor As Color)
        AppendOutput(text & Environment.NewLine, color, backColor)
    End Sub

    Private Function GetLineLabel(line As String) As String
        Dim match = Regex.Match(line, "#[^;]+;")

        If match.Success Then
            Return match.Value.Substring(1, match.Value.Length - 2)
        End If

        Return Nothing
    End Function

    Private Sub RunScript()
        Dim _lineNumber As Integer
        Try
            PrintOutputNumber()
            Dim isCode = False

            For Each line In txtInput.Lines
                line = line.Trim()
                _lineNumber += 1
                If line <> "" And Not line.StartsWith("//") Then
                    Dim label = GetLineLabel(line)
                    If label <> Nothing Then
                        line = line.Substring(label.Length + 2)
                    End If

                    Dim output = scriptControl.Eval(line)
                    AppendOutput(GetOutputPrefix(If(label, $"Line {_lineNumber}")), _outputColor, _defaultBackColor)
                    AppendOutputLine(output, _passedColor, _defaultBackColor)
                End If
            Next
        Catch ex As Exception
            AppendOutput(GetOutputPrefix(_lineNumber), _outputColor, _defaultBackColor)
            AppendOutputLine(ex.Message, Color.LightCoral, _defaultBackColor)
        End Try

        ResetScriptControl()
        txtOutput.SelectionStart = txtOutput.Text.Count - 1
        txtOutput.ScrollToCaret()
        txtInput.Focus()
    End Sub

#End Region

#Region "Files and IO"

    Private Sub ofd1_FileOk(sender As Object, e As CancelEventArgs) Handles ofd1.FileOk
        If Not ofd1.Title.Contains("Append") Then
            If txtInput.Text.Trim() <> "" Then
                If PromptYesOrNo("Would you like to save the current file first?") Then
                    If lblFilePath.Text = lblFilePath.Tag Then
                        sfd1.ShowDialog()
                    Else
                        SaveFile(lblFilePath.Text)
                    End If
                End If
            End If
            txtInput.Text = ""
        Else
            txtInput.Text &= Environment.NewLine
        End If

        Dim path As String = ofd1.FileName
        If File.Exists(path) Then
            Try
                Using R As StreamReader = File.OpenText(path)
                    While R.Peek <> -1
                        txtInput.Text &= R.ReadLine() & Environment.NewLine
                    End While
                End Using
                SetPath(path)
            Catch
                MessageBox.Show($"Failed to open '{path}'.", "BoinJS - Error")
            End Try
        End If
    End Sub

    Private Sub SetPath(path As String)
        Text = $"{Tag} - {path}"
        lblFilePath.Text = path
    End Sub

    Private Sub SaveFile(path As String)
        Try
            Using W As StreamWriter = File.CreateText(path)
                W.Write(txtInput.Text)
            End Using
            SetPath(path)
        Catch
            MessageBox.Show($"Failed to save file to '{path}'.", "BoinJS - Error")
        End Try
    End Sub

    Private Sub sfd1_FileOk(sender As Object, e As CancelEventArgs) Handles sfd1.FileOk
        SaveFile(sfd1.FileName)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = _isDirty AndAlso Not PromptYesOrNo("Close without saving?")
    End Sub

#End Region

End Class
