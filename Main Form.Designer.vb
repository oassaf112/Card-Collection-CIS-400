<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.chkGraded = New System.Windows.Forms.CheckBox()
        Me.grpSigned = New System.Windows.Forms.GroupBox()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExitFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSigned.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCards
        '
        Me.lstCards.BackColor = System.Drawing.Color.White
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.ItemHeight = 17
        Me.lstCards.Location = New System.Drawing.Point(12, 48)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(172, 276)
        Me.lstCards.TabIndex = 0
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.BackColor = System.Drawing.Color.White
        Me.lblPlayerName.Location = New System.Drawing.Point(202, 48)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(89, 19)
        Me.lblPlayerName.TabIndex = 1
        Me.lblPlayerName.Text = "&Player Name:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(202, 88)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(38, 19)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "&Year:"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.BackColor = System.Drawing.Color.White
        Me.lblTeam.Location = New System.Drawing.Point(202, 127)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(44, 19)
        Me.lblTeam.TabIndex = 5
        Me.lblTeam.Text = "&Team:"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.BackColor = System.Drawing.Color.White
        Me.txtPlayerName.Location = New System.Drawing.Point(305, 48)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(211, 25)
        Me.txtPlayerName.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        Me.txtYear.Location = New System.Drawing.Point(305, 88)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(87, 25)
        Me.txtYear.TabIndex = 4
        '
        'cboTeam
        '
        Me.cboTeam.BackColor = System.Drawing.Color.White
        Me.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Location = New System.Drawing.Point(305, 128)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(158, 25)
        Me.cboTeam.TabIndex = 6
        '
        'chkGraded
        '
        Me.chkGraded.AutoSize = True
        Me.chkGraded.BackColor = System.Drawing.Color.White
        Me.chkGraded.Location = New System.Drawing.Point(305, 172)
        Me.chkGraded.Name = "chkGraded"
        Me.chkGraded.Size = New System.Drawing.Size(82, 23)
        Me.chkGraded.TabIndex = 7
        Me.chkGraded.Text = "&Graded?"
        Me.chkGraded.UseVisualStyleBackColor = False
        '
        'grpSigned
        '
        Me.grpSigned.BackColor = System.Drawing.Color.White
        Me.grpSigned.Controls.Add(Me.rdoNo)
        Me.grpSigned.Controls.Add(Me.rdoYes)
        Me.grpSigned.Location = New System.Drawing.Point(305, 211)
        Me.grpSigned.Name = "grpSigned"
        Me.grpSigned.Size = New System.Drawing.Size(174, 88)
        Me.grpSigned.TabIndex = 8
        Me.grpSigned.TabStop = False
        Me.grpSigned.Tag = ""
        Me.grpSigned.Text = "S&igned?"
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Checked = True
        Me.rdoNo.Location = New System.Drawing.Point(99, 41)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(48, 23)
        Me.rdoNo.TabIndex = 1
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(26, 41)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(50, 23)
        Me.rdoYes.TabIndex = 0
        Me.rdoYes.Text = "Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(206, 317)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(340, 317)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 33)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "&Update Item"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(474, 317)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(114, 33)
        Me.btnAddItem.TabIndex = 11
        Me.btnAddItem.Text = "&Add New Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(13, 360)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 40)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(489, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 40)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(619, 28)
        Me.mnuMain.TabIndex = 14
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenFile, Me.mnuSaveFile, Me.ToolStripMenuItem1, Me.mnuExitFile})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuOpenFile
        '
        Me.mnuOpenFile.Name = "mnuOpenFile"
        Me.mnuOpenFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuOpenFile.Text = "&Open Collection"
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuSaveFile.Text = "&Save Collection"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'mnuExitFile
        '
        Me.mnuExitFile.Name = "mnuExitFile"
        Me.mnuExitFile.Size = New System.Drawing.Size(224, 26)
        Me.mnuExitFile.Text = "E&xit"
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project___Omar.My.Resources.Resources.Camp_nou_Opening_Hour
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(619, 412)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpSigned)
        Me.Controls.Add(Me.chkGraded)
        Me.Controls.Add(Me.cboTeam)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lstCards)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuMain
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Soccer Cards"
        Me.grpSigned.ResumeLayout(False)
        Me.grpSigned.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCards As ListBox
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents cboTeam As ComboBox
    Friend WithEvents chkGraded As CheckBox
    Friend WithEvents grpSigned As GroupBox
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpenFile As ToolStripMenuItem
    Friend WithEvents mnuSaveFile As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExitFile As ToolStripMenuItem
End Class
