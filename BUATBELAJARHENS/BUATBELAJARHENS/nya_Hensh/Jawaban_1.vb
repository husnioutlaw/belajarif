Public Class Jawaban_1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'MEMBUAT VALIDASI MSGBOX BAHWA DATA YANG ADA DI TEXTBOX1 ATAU TEXTBOX2 TIDAK BOLEH KOSONG
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("USERNAME ATAU PASSWORD TOLONG DIISI", MsgBoxStyle.Information, "PERINGATAN")

            'MEMBUAT VALIDASI CEK APAKAH CHECKBOXNYA TERCHEKLIST ATAU TIDAK
        ElseIf CheckBox1.Checked = True Then

            'JIKA CHECKBOX TERCHECKLIST LAKUKAN CHEK LAGI APAKAH YANG DIINPUT DI TEXTBOX1="admin" DAN 
            'TEXTBOX2="220394"
            If TextBox1.Text = "HENSH" And TextBox2.Text = "04021994" Then

                MsgBox("HALLO ADMINISTRATOR HENSH" & _
                vbCrLf & "=======================" & _
               vbCrLf & "Username" & Space(1) & ":" & Space(2) & TextBox1.Text & _
               vbCrLf & "Password" & Space(2) & ":" & Space(2) & TextBox2.Text & _
               vbCrLf & "========================" & _
                vbCrLf & "SALAM DARI ADENTI : SELAMAT BEKERJA ADMIN!", MsgBoxStyle.Information, "Peringatan")

                'JIKA TEXTBOX1="admin" DAN TEXTBOX2="220394" MAKA 
                'ISIKAN TEXTBOX1 YANG ADA PADA FORM LANJUT1.VB
                'DENGAN "Selamat datang Administrator, " & YANG DIINPUT DI TEXTBOX1(USERNAME)
                JAWABANPERTAMA.TextBox1.Text = "Hallo Calonnya si Adenti Yaitu, " & TextBox1.Text

                'TAMPILKAN FORM LANJUT1.VB
                JAWABANPERTAMA.Show()

                'SEMBUNYIKAN FORM PERTEMUANPERTAMA.VB
                Me.Hide()



                'JIKA CHECKBOX TERCHECKLIST NAMUN TEXTBOX1 DAN TEXTBOX2 DIINPUT SELAIN ADMIN DAN 220394 
                'MAKA
            Else
                'TAMPILKAN MSGBOX "MUNGKIN ANDA BUKAN ADMIN"
                MsgBox("MUNGKIN ANDA BUKAN ADMIN", MsgBoxStyle.Information, "PERINGATAN")
            End If

            'SELAIN ITU JIKA TEXTBOX1="user" dan TEXTBOX2="220394" MAKA 
        ElseIf TextBox1.Text = "HUSNIOUTLAW" And TextBox2.Text = "22031994" Then

            MsgBox("HALLO HUSNIOUTLAW" & _
                vbCrLf & "=======================" & _
               vbCrLf & "Username" & Space(1) & ":" & Space(2) & TextBox1.Text & _
               vbCrLf & "Password" & Space(2) & ":" & Space(2) & TextBox2.Text & _
               vbCrLf & "========================" & _
                vbCrLf & "SELAMAT BEKERJA!", MsgBoxStyle.Information, "Peringatan")

            'ISIKAN TEXTBOX1 YANG ADA PADA FORM LANJUT1.VB
            'DENGAN "Selamat datang User, " & YANG DIINPUT DI TEXTBOX1(USERNAME)
            JAWABANPERTAMA.TextBox1.Text = "Hallo, " & TextBox1.Text

            'MATIKAN MENU LANJUT2 YANG ADA PADA MENU STRIP DI FORM LANJUT1.VB AGAR TIDAK BISA DIKLIK
            JAWABANPERTAMA.Lanjut2ToolStripMenuItem.Enabled = False

            'TAMPILKAN FORM LANJUT1.VB
            JAWABANPERTAMA.Show()

            'SEMBUNYIKAN FORM PERTEMUANPERTAMA.VB
            Me.Hide()
        Else
            MsgBox("Anda Bukan Siapa Siapa", MsgBoxStyle.Information, "WARNING!!!")

        End If

    End Sub

    Private Sub Jawaban_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class