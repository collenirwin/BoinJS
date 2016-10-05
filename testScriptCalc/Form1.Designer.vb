<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAppendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearInputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.GlobalFunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowOutputNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsiTopmost = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.scrpt1 = New AxMSScriptControl.AxScriptControl()
        Me.cmsInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindReplaceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetZoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.spltContainer = New System.Windows.Forms.SplitContainer()
        Me.txtInput = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.cmsOutput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetZoomToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.chkTopmost = New System.Windows.Forms.CheckBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnClearIn = New System.Windows.Forms.Button()
        Me.btnClearOut = New System.Windows.Forms.Button()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.sfd1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.msMain.SuspendLayout()
        CType(Me.scrpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInput.SuspendLayout()
        CType(Me.spltContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltContainer.Panel1.SuspendLayout()
        Me.spltContainer.Panel2.SuspendLayout()
        Me.spltContainer.SuspendLayout()
        CType(Me.txtInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOutput.SuspendLayout()
        Me.pnlMid.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.BackColor = System.Drawing.Color.White
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(656, 24)
        Me.msMain.TabIndex = 7
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenAppendToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenAppendToolStripMenuItem
        '
        Me.OpenAppendToolStripMenuItem.Name = "OpenAppendToolStripMenuItem"
        Me.OpenAppendToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenAppendToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.OpenAppendToolStripMenuItem.Text = "Open + Append"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(231, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator8, Me.ClearInputToolStripMenuItem, Me.ClearOutputToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ToolStripSeparator3, Me.FindToolStripMenuItem, Me.FindReplaceToolStripMenuItem, Me.ToolStripSeparator6, Me.ResetZoomToolStripMenuItem, Me.ToolStripSeparator10, Me.GlobalFunctionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(232, 6)
        '
        'ClearInputToolStripMenuItem
        '
        Me.ClearInputToolStripMenuItem.Name = "ClearInputToolStripMenuItem"
        Me.ClearInputToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ClearInputToolStripMenuItem.Text = "Clear Input"
        '
        'ClearOutputToolStripMenuItem
        '
        Me.ClearOutputToolStripMenuItem.Name = "ClearOutputToolStripMenuItem"
        Me.ClearOutputToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ClearOutputToolStripMenuItem.Text = "Clear Output"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(232, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FindReplaceToolStripMenuItem
        '
        Me.FindReplaceToolStripMenuItem.Name = "FindReplaceToolStripMenuItem"
        Me.FindReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.FindReplaceToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.FindReplaceToolStripMenuItem.Text = "Find + Replace"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(232, 6)
        '
        'ResetZoomToolStripMenuItem
        '
        Me.ResetZoomToolStripMenuItem.Name = "ResetZoomToolStripMenuItem"
        Me.ResetZoomToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ResetZoomToolStripMenuItem.Text = "Reset All Zoom"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(232, 6)
        '
        'GlobalFunctionsToolStripMenuItem
        '
        Me.GlobalFunctionsToolStripMenuItem.Name = "GlobalFunctionsToolStripMenuItem"
        Me.GlobalFunctionsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.GlobalFunctionsToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.GlobalFunctionsToolStripMenuItem.Text = "Global Functions"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowOutputNumberToolStripMenuItem, Me.tsiTopmost})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ShowOutputNumberToolStripMenuItem
        '
        Me.ShowOutputNumberToolStripMenuItem.CheckOnClick = True
        Me.ShowOutputNumberToolStripMenuItem.Name = "ShowOutputNumberToolStripMenuItem"
        Me.ShowOutputNumberToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ShowOutputNumberToolStripMenuItem.Text = "Output Numbers"
        '
        'tsiTopmost
        '
        Me.tsiTopmost.CheckOnClick = True
        Me.tsiTopmost.Name = "tsiTopmost"
        Me.tsiTopmost.Size = New System.Drawing.Size(164, 22)
        Me.tsiTopmost.Text = "Topmost"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'scrpt1
        '
        Me.scrpt1.Enabled = True
        Me.scrpt1.Location = New System.Drawing.Point(249, -2)
        Me.scrpt1.Name = "scrpt1"
        Me.scrpt1.OcxState = CType(resources.GetObject("scrpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.scrpt1.Size = New System.Drawing.Size(38, 38)
        Me.scrpt1.TabIndex = 2
        Me.scrpt1.TabStop = False
        Me.scrpt1.Visible = False
        '
        'cmsInput
        '
        Me.cmsInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator9, Me.UndoToolStripMenuItem1, Me.RedoToolStripMenuItem1, Me.ToolStripSeparator4, Me.ClearToolStripMenuItem, Me.ToolStripSeparator5, Me.FindToolStripMenuItem1, Me.FindReplaceToolStripMenuItem1, Me.ToolStripSeparator11, Me.ResetZoomToolStripMenuItem1})
        Me.cmsInput.Name = "cmsInput"
        Me.cmsInput.Size = New System.Drawing.Size(153, 204)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(149, 6)
        '
        'UndoToolStripMenuItem1
        '
        Me.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1"
        Me.UndoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.UndoToolStripMenuItem1.Text = "Undo"
        '
        'RedoToolStripMenuItem1
        '
        Me.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1"
        Me.RedoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RedoToolStripMenuItem1.Text = "Redo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'FindToolStripMenuItem1
        '
        Me.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1"
        Me.FindToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FindToolStripMenuItem1.Text = "Find"
        '
        'FindReplaceToolStripMenuItem1
        '
        Me.FindReplaceToolStripMenuItem1.Name = "FindReplaceToolStripMenuItem1"
        Me.FindReplaceToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FindReplaceToolStripMenuItem1.Text = "Find + Replace"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(149, 6)
        '
        'ResetZoomToolStripMenuItem1
        '
        Me.ResetZoomToolStripMenuItem1.Name = "ResetZoomToolStripMenuItem1"
        Me.ResetZoomToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ResetZoomToolStripMenuItem1.Text = "Reset Zoom"
        '
        'spltContainer
        '
        Me.spltContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spltContainer.Location = New System.Drawing.Point(0, 24)
        Me.spltContainer.Name = "spltContainer"
        Me.spltContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltContainer.Panel1
        '
        Me.spltContainer.Panel1.Controls.Add(Me.txtInput)
        Me.spltContainer.Panel1MinSize = 0
        '
        'spltContainer.Panel2
        '
        Me.spltContainer.Panel2.Controls.Add(Me.txtOutput)
        Me.spltContainer.Panel2.Controls.Add(Me.pnlMid)
        Me.spltContainer.Panel2MinSize = 35
        Me.spltContainer.Size = New System.Drawing.Size(656, 467)
        Me.spltContainer.SplitterDistance = 208
        Me.spltContainer.SplitterWidth = 6
        Me.spltContainer.TabIndex = 8
        '
        'txtInput
        '
        Me.txtInput.AllowMacroRecording = False
        Me.txtInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtInput.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtInput.AutoScrollMinSize = New System.Drawing.Size(119, 18)
        Me.txtInput.BackBrush = Nothing
        Me.txtInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtInput.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.txtInput.CharHeight = 18
        Me.txtInput.CharWidth = 9
        Me.txtInput.ContextMenuStrip = Me.cmsInput
        Me.txtInput.CurrentLineColor = System.Drawing.Color.Silver
        Me.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInput.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtInput.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtInput.IndentBackColor = System.Drawing.Color.Transparent
        Me.txtInput.IsReplaceMode = False
        Me.txtInput.Language = FastColoredTextBoxNS.Language.JS
        Me.txtInput.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtInput.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.txtInput.LineNumberColor = System.Drawing.SystemColors.HotTrack
        Me.txtInput.Location = New System.Drawing.Point(12, 1)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtInput.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtInput.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.txtInput.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtInput.ServiceLinesColor = System.Drawing.Color.Transparent
        Me.txtInput.Size = New System.Drawing.Size(632, 205)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "// Welcome"
        Me.txtInput.Zoom = 100
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.ContextMenuStrip = Me.cmsOutput
        Me.txtOutput.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.LightGray
        Me.txtOutput.Location = New System.Drawing.Point(12, 35)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtOutput.Size = New System.Drawing.Size(632, 206)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.Text = ""
        '
        'cmsOutput
        '
        Me.cmsOutput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator7, Me.ToolStripMenuItem3, Me.ToolStripSeparator12, Me.ResetZoomToolStripMenuItem2})
        Me.cmsOutput.Name = "cmsInput"
        Me.cmsOutput.Size = New System.Drawing.Size(138, 82)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem1.Text = "Copy"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(134, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem3.Text = "Clear"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(134, 6)
        '
        'ResetZoomToolStripMenuItem2
        '
        Me.ResetZoomToolStripMenuItem2.Name = "ResetZoomToolStripMenuItem2"
        Me.ResetZoomToolStripMenuItem2.Size = New System.Drawing.Size(137, 22)
        Me.ResetZoomToolStripMenuItem2.Text = "Reset Zoom"
        '
        'pnlMid
        '
        Me.pnlMid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMid.Controls.Add(Me.scrpt1)
        Me.pnlMid.Controls.Add(Me.chkTopmost)
        Me.pnlMid.Controls.Add(Me.btnRun)
        Me.pnlMid.Controls.Add(Me.btnClearAll)
        Me.pnlMid.Controls.Add(Me.btnClearIn)
        Me.pnlMid.Controls.Add(Me.btnClearOut)
        Me.pnlMid.Location = New System.Drawing.Point(3, 0)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(650, 35)
        Me.pnlMid.TabIndex = 10
        '
        'chkTopmost
        '
        Me.chkTopmost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkTopmost.AutoSize = True
        Me.chkTopmost.Checked = True
        Me.chkTopmost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTopmost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.chkTopmost.Location = New System.Drawing.Point(12, 9)
        Me.chkTopmost.Name = "chkTopmost"
        Me.chkTopmost.Size = New System.Drawing.Size(67, 17)
        Me.chkTopmost.TabIndex = 5
        Me.chkTopmost.TabStop = False
        Me.chkTopmost.Text = "Topmost"
        Me.chkTopmost.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRun.Location = New System.Drawing.Point(548, 5)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(91, 23)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run (F5)"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClearAll.Location = New System.Drawing.Point(483, 5)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(59, 23)
        Me.btnClearAll.TabIndex = 2
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnClearIn
        '
        Me.btnClearIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClearIn.Location = New System.Drawing.Point(321, 5)
        Me.btnClearIn.Name = "btnClearIn"
        Me.btnClearIn.Size = New System.Drawing.Size(75, 23)
        Me.btnClearIn.TabIndex = 4
        Me.btnClearIn.Text = "Clear Input"
        Me.btnClearIn.UseVisualStyleBackColor = True
        '
        'btnClearOut
        '
        Me.btnClearOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClearOut.Location = New System.Drawing.Point(402, 5)
        Me.btnClearOut.Name = "btnClearOut"
        Me.btnClearOut.Size = New System.Drawing.Size(75, 23)
        Me.btnClearOut.TabIndex = 3
        Me.btnClearOut.Text = "Clear Output"
        Me.btnClearOut.UseVisualStyleBackColor = True
        '
        'ofd1
        '
        Me.ofd1.Filter = "JavaScript files|*.js|All files|*.*"
        Me.ofd1.Tag = "BoinJS - Open"
        Me.ofd1.Title = "BoinJS - Open"
        '
        'sfd1
        '
        Me.sfd1.DefaultExt = "js"
        Me.sfd1.Filter = "JavaScript files|*.js"
        Me.sfd1.Title = "BoinJS - Save As"
        '
        'lblFilePath
        '
        Me.lblFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFilePath.AutoEllipsis = True
        Me.lblFilePath.BackColor = System.Drawing.Color.White
        Me.lblFilePath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblFilePath.Location = New System.Drawing.Point(241, 1)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(412, 20)
        Me.lblFilePath.TabIndex = 9
        Me.lblFilePath.Tag = "Not Saved"
        Me.lblFilePath.Text = "Not Saved"
        Me.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 491)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.spltContainer)
        Me.Controls.Add(Me.msMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.MinimumSize = New System.Drawing.Size(434, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "BoinJS"
        Me.Text = "BoinJS - Not Saved"
        Me.TopMost = True
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        CType(Me.scrpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInput.ResumeLayout(False)
        Me.spltContainer.Panel1.ResumeLayout(False)
        Me.spltContainer.Panel2.ResumeLayout(False)
        CType(Me.spltContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltContainer.ResumeLayout(False)
        CType(Me.txtInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOutput.ResumeLayout(False)
        Me.pnlMid.ResumeLayout(False)
        Me.pnlMid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scrpt1 As AxMSScriptControl.AxScriptControl
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAppendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiTopmost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearInputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearOutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsInput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindReplaceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents spltContainer As System.Windows.Forms.SplitContainer
    Private WithEvents txtInput As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents pnlMid As System.Windows.Forms.Panel
    Friend WithEvents chkTopmost As System.Windows.Forms.CheckBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnClearIn As System.Windows.Forms.Button
    Friend WithEvents btnClearOut As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GlobalFunctionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents cmsOutput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowOutputNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetZoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetZoomToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
