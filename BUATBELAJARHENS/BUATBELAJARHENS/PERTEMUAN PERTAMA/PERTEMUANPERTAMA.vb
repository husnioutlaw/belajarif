Public Class PERTEMUANPERTAMA
    'MEMBUAT MSGBOX BERDASARKAN DATA YANG ADA DI TEXTBOX1 DAN TEXTBOX2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MEMBUAT MSGBOX = "USERNAME:ADMIN PASSWORD:220394 DENGAN SPACE 1 SETELAH TULISAN USERNAME 
        'SPACE 2 SETELAH : PADA BAGIAN USERNAME DAN SPACE 2 SETELAH TULISAN PASSWORD SPACE 2 SETELAH
        ': PADA BAGIAN PASSWORD
        MsgBox("Username" & Space(1) & ":" & Space(2) & TextBox1.Text & _
               vbCrLf & "Password" & Space(2) & ":" & Space(2) & TextBox2.Text, MsgBoxStyle.Information, "Peringatan")

        'MENGUBAH LABEL5 MENJADI TULISAN YANG DIINPUT PADA TEXTBOX1(USERNAME)
        Label5.Text = TextBox1.Text

        'MENGUBAH LABEL6 MENJADI TULISAN YANG DIINPUT PADA TEXTBOX2(PASSWORD)
        Label6.Text = TextBox2.Text
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'MEMBUAT VALIDASI MSGBOX BAHWA DATA YANG ADA DI TEXTBOX1 ATAU TEXTBOX2 TIDAK BOLEH KOSONG
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("USERNAME ATAU PASSWORD TOLONG DIISI", MsgBoxStyle.Information, "PERINGATAN")


            'MEMBUAT VALIDASI CEK APAKAH CHECKBOXNYA TERCHEKLIST ATAU TIDAK
        ElseIf CheckBox1.Checked = True Then


            'JIKA CHECKBOX TERCHECKLIST LAKUKAN CHEK LAGI APAKAH YANG DIINPUT DI TEXTBOX1="admin" DAN 
            'TEXTBOX2="220394"
            If TextBox1.Text = "admin" And TextBox2.Text = "220394" Then



                'JIKA TEXTBOX1="admin" DAN TEXTBOX2="220394" MAKA 
                'ISIKAN TEXTBOX1 YANG ADA PADA FORM LANJUT1.VB
                'DENGAN "Selamat datang Administrator, " & YANG DIINPUT DI TEXTBOX1(USERNAME)
                Lanjut1.TextBox1.Text = "Selamat datang Administrator, " & TextBox1.Text

                'TAMPILKAN FORM LANJUT1.VB
                Lanjut1.Show()

                'SEMBUNYIKAN FORM PERTEMUANPERTAMA.VB
                Me.Hide()

                'JIKA CHECKBOX TERCHECKLIST NAMUN TEXTBOX1 DAN TEXTBOX2 DIINPUT SELAIN ADMIN DAN 220394 
                'MAKA
            Else
                'TAMPILKAN MSGBOX "MUNGKIN ANDA BUKAN ADMIN"
                MsgBox("MUNGKIN ANDA BUKAN ADMIN", MsgBoxStyle.Information, "PERINGATAN")
            End If

            'SELAIN ITU JIKA TEXTBOX1="user" dan TEXTBOX2="220394" MAKA 
        ElseIf TextBox1.Text = "user" And TextBox2.Text = "220394" Then
            'ISIKAN TEXTBOX1 YANG ADA PADA FORM LANJUT1.VB
            'DENGAN "Selamat datang User, " & YANG DIINPUT DI TEXTBOX1(USERNAME)
            Lanjut1.TextBox1.Text = "Selamat datang User, " & TextBox1.Text

            'MATIKAN MENU LANJUT2 YANG ADA PADA MENU STRIP DI FORM LANJUT1.VB AGAR TIDAK BISA DIKLIK
            Lanjut1.Lanjut2ToolStripMenuItem.Enabled = False

            'TAMPILKAN FORM LANJUT1.VB
            Lanjut1.Show()

            'SEMBUNYIKAN FORM PERTEMUANPERTAMA.VB
            Me.Hide()
        Else
            'JIKA SELAIN KONDISI DIATAS TERPENUHI MAKA TAMPILKAN MSGBOX="MUNGKIN ANDA ADMIN"
            MsgBox("MUNGKIN ANDA ADMIN", MsgBoxStyle.Information, "PERINGATAN")
        End If

    End Sub
End Class
