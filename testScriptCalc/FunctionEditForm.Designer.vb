<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FunctionEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FunctionEditForm))
        Me.txtMain = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.cmsInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindReplaceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetZoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.txtMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInput.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.AllowMacroRecording = False
        Me.txtMain.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtMain.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtMain.AutoScrollMinSize = New System.Drawing.Size(299, 18)
        Me.txtMain.BackBrush = Nothing
        Me.txtMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtMain.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.txtMain.CharHeight = 18
        Me.txtMain.CharWidth = 9
        Me.txtMain.ContextMenuStrip = Me.cmsInput
        Me.txtMain.CurrentLineColor = System.Drawing.Color.Silver
        Me.txtMain.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMain.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMain.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtMain.IndentBackColor = System.Drawing.Color.Transparent
        Me.txtMain.IsReplaceMode = False
        Me.txtMain.Language = FastColoredTextBoxNS.Language.JS
        Me.txtMain.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtMain.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.txtMain.LineNumberColor = System.Drawing.SystemColors.HotTrack
        Me.txtMain.Location = New System.Drawing.Point(0, 24)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtMain.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtMain.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.txtMain.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMain.ServiceLinesColor = System.Drawing.Color.Transparent
        Me.txtMain.Size = New System.Drawing.Size(584, 338)
        Me.txtMain.TabIndex = 2
        Me.txtMain.Text = "// Enter Global Functions Here"
        Me.txtMain.Zoom = 100
        '
        'cmsInput
        '
        Me.cmsInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator9, Me.UndoToolStripMenuItem1, Me.RedoToolStripMenuItem1, Me.ToolStripSeparator4, Me.FindToolStripMenuItem1, Me.FindReplaceToolStripMenuItem1, Me.ToolStripSeparator11, Me.ResetZoomToolStripMenuItem1})
        Me.cmsInput.Name = "cmsInput"
        Me.cmsInput.Size = New System.Drawing.Size(153, 176)
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator1, Me.FindToolStripMenuItem, Me.FindReplaceToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetZoomToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FindReplaceToolStripMenuItem
        '
        Me.FindReplaceToolStripMenuItem.Name = "FindReplaceToolStripMenuItem"
        Me.FindReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.FindReplaceToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindReplaceToolStripMenuItem.Text = "Find + Replace"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'ResetZoomToolStripMenuItem
        '
        Me.ResetZoomToolStripMenuItem.Name = "ResetZoomToolStripMenuItem"
        Me.ResetZoomToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ResetZoomToolStripMenuItem.Text = "Reset Zoom"
        '
        'frmFunctionEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFunctionEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoinJS - Function Editor"
        CType(Me.txtMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInput.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtMain As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsInput As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindReplaceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetZoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
