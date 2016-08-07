Public Class frm_welcomePage

    Private Sub frm_welcomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        If My.Computer.FileSystem.DirectoryExists("C:\frm_mainPage") = True Then
            frm_mainPage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgBar.Increment(5)
        If ProgBar.Value = 100 Then
            frm_mainPage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ProgBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgBar.Click
        If ProgBar.Value = 100 Then
            If My.Computer.FileSystem.DirectoryExists("C:\mainPage") = True Then
                frm_mainPage.Show()
                Me.Close()
            Else
                My.Computer.FileSystem.CreateDirectory("C:\mainPage")
                Timer1.Start()
            End If
        End If
    End Sub
End Class