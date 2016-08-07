<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_docs = New System.Windows.Forms.Button()
        Me.btn_backUp = New System.Windows.Forms.Button()
        Me.btn_retrive = New System.Windows.Forms.Button()
        Me.btn_logs = New System.Windows.Forms.Button()
        Me.btn_memCheck = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(525, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.AboutToolStripMenuItem.Text = "&About Data Corruption Recovery"
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(391, 343)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(93, 22)
        Me.btn_logout.TabIndex = 1
        Me.btn_logout.Text = "Log Out"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_docs
        '
        Me.btn_docs.Location = New System.Drawing.Point(37, 126)
        Me.btn_docs.Name = "btn_docs"
        Me.btn_docs.Size = New System.Drawing.Size(93, 22)
        Me.btn_docs.TabIndex = 2
        Me.btn_docs.Text = "Documents"
        Me.btn_docs.UseVisualStyleBackColor = True
        '
        'btn_backUp
        '
        Me.btn_backUp.Location = New System.Drawing.Point(37, 178)
        Me.btn_backUp.Name = "btn_backUp"
        Me.btn_backUp.Size = New System.Drawing.Size(93, 22)
        Me.btn_backUp.TabIndex = 3
        Me.btn_backUp.Text = "Back-Up"
        Me.btn_backUp.UseVisualStyleBackColor = True
        '
        'btn_retrive
        '
        Me.btn_retrive.Location = New System.Drawing.Point(37, 231)
        Me.btn_retrive.Name = "btn_retrive"
        Me.btn_retrive.Size = New System.Drawing.Size(93, 22)
        Me.btn_retrive.TabIndex = 4
        Me.btn_retrive.Text = "Retrieve"
        Me.btn_retrive.UseVisualStyleBackColor = True
        '
        'btn_logs
        '
        Me.btn_logs.Location = New System.Drawing.Point(37, 280)
        Me.btn_logs.Name = "btn_logs"
        Me.btn_logs.Size = New System.Drawing.Size(93, 22)
        Me.btn_logs.TabIndex = 5
        Me.btn_logs.Text = "Logs"
        Me.btn_logs.UseVisualStyleBackColor = True
        '
        'btn_memCheck
        '
        Me.btn_memCheck.Location = New System.Drawing.Point(37, 79)
        Me.btn_memCheck.Name = "btn_memCheck"
        Me.btn_memCheck.Size = New System.Drawing.Size(93, 22)
        Me.btn_memCheck.TabIndex = 6
        Me.btn_memCheck.Text = "Memory Check"
        Me.btn_memCheck.UseVisualStyleBackColor = True
        '
        'frm_mainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 377)
        Me.Controls.Add(Me.btn_memCheck)
        Me.Controls.Add(Me.btn_logs)
        Me.Controls.Add(Me.btn_retrive)
        Me.Controls.Add(Me.btn_backUp)
        Me.Controls.Add(Me.btn_docs)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_mainPage"
        Me.Text = "Main Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_docs As System.Windows.Forms.Button
    Friend WithEvents btn_backUp As System.Windows.Forms.Button
    Friend WithEvents btn_retrive As System.Windows.Forms.Button
    Friend WithEvents btn_logs As System.Windows.Forms.Button
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_memCheck As System.Windows.Forms.Button

End Class
