<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_register
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
        Dim Retype_PasswordLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Me.DBPrototype = New WindowsApplication1.DBPrototype()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationTableAdapter = New WindowsApplication1.DBPrototypeTableAdapters.RegistrationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DBPrototypeTableAdapters.TableAdapterManager()
        Me.Retype_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Retype_PasswordLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        CType(Me.DBPrototype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Retype_PasswordLabel
        '
        Retype_PasswordLabel.AutoSize = True
        Retype_PasswordLabel.Location = New System.Drawing.Point(222, 179)
        Retype_PasswordLabel.Name = "Retype_PasswordLabel"
        Retype_PasswordLabel.Size = New System.Drawing.Size(93, 13)
        Retype_PasswordLabel.TabIndex = 5
        Retype_PasswordLabel.Text = "Retype Password:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(222, 141)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Password:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(222, 103)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Username:"
        '
        'DBPrototype
        '
        Me.DBPrototype.DataSetName = "DBPrototype"
        Me.DBPrototype.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.DBPrototype
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Me.RegistrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DBPrototypeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Retype_PasswordTextBox
        '
        Me.Retype_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Retype Password", True))
        Me.Retype_PasswordTextBox.Location = New System.Drawing.Point(321, 176)
        Me.Retype_PasswordTextBox.Name = "Retype_PasswordTextBox"
        Me.Retype_PasswordTextBox.Size = New System.Drawing.Size(137, 20)
        Me.Retype_PasswordTextBox.TabIndex = 6
        Me.Retype_PasswordTextBox.Text = "*******"
        Me.Retype_PasswordTextBox.UseSystemPasswordChar = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(321, 138)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.Text = "*******"
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(321, 100)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(137, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.final_logo12
        Me.LogoPictureBox.Location = New System.Drawing.Point(49, 70)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(340, 228)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(237, 228)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 8
        Me.OK.Text = "&Register"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Message"
        '
        'frm_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 344)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Retype_PasswordLabel)
        Me.Controls.Add(Me.Retype_PasswordTextBox)
        Me.Name = "frm_register"
        Me.Text = "Registration"
        CType(Me.DBPrototype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBPrototype As WindowsApplication1.DBPrototype
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As WindowsApplication1.DBPrototypeTableAdapters.RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DBPrototypeTableAdapters.TableAdapterManager
    Friend WithEvents Retype_PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
