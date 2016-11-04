Public Class Lanjut1

    Private Sub Lanjut1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'keluar dari form lanjut1.vb
        Me.Dispose()

        'tampilkan pertemuanpertama.vb
        PERTEMUANPERTAMA.Show()
    End Sub

    Private Sub Lanjut2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lanjut2ToolStripMenuItem.Click
        'tampilkan lanjut1_2.vb
        Lanjut1_2.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
End Class