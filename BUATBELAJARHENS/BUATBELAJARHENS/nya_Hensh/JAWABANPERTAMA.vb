Public Class JAWABANPERTAMA

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'keluar dari form lanjut1.vb
        Me.Dispose()

        'tampilkan pertemuanpertama.vb
        Jawaban_1.Show()
    End Sub

    Private Sub Lanjut2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lanjut2ToolStripMenuItem.Click
        'tampilkan lanjut1_2.vb
        Jawaban_2.Show()
    End Sub

    Private Sub JAWABANPERTAMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class