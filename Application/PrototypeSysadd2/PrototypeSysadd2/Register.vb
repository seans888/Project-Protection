Public Class frm_register

    Private Sub RegistrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBPrototype)

    End Sub

    Private Sub frm_register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBPrototype.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.DBPrototype.Registration)

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        My.Settings.Username = UsernameTextBox.Text
        My.Settings.Password = PasswordTextBox.Text
        My.Settings.Retype_Password = Retype_PasswordTextBox.Text
        My.Settings.Save()
        MsgBox("Account created!", MsgBoxStyle.Information, "Created!")
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub Retype_PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retype_PasswordTextBox.TextChanged
        If Not PasswordTextBox.Text = Retype_PasswordTextBox.Text Then
            Label1.Text = "Passwords do not match!"
        Else
            Label1.Text = " "
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class