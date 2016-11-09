Public Class Jawaban_2

    Private Sub Jawaban_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Detil barang yang anda pilih :" & vbCrLf & _
        "KODE BARANG" & Space(4) & ":" & ComboBox1.Text & vbCrLf & _
        "NAMA BARANG" & Space(2) & ":" & TextBox2.Text & vbCrLf & _
        "SATUAN" & Space(15) & ":" & TextBox3.Text & vbCrLf & _
        "STOK" & Space(21) & ":" & TextBox4.Text & vbCrLf & _
        "HARGA" & Space(17) & ":" & TextBox5.Text & vbCrLf, MsgBoxStyle.Information, "PERINGATAN!")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'buat kondisi jika textbox1 jumlah lengthnya(digit) mau itu huruf atau angka lebih dari 4 maka
        'If TextBox1.TextLength > 4 Then
        '    'buat kondisi lagi jika textbox1="BRG01" maka
        If ComboBox1.Text = "BRG01" Then

            'isikan textbox2 dengan "Mouse"
            TextBox2.Text = "Mouse"

            'isikan textbox3 dengan "Pcs"
            TextBox3.Text = "Pcs"

            'isikan textbox4 dengan "20"
            TextBox4.Text = "20"

            'isikan textbox5 dengan "500000"
            TextBox5.Text = "500000"

            'selain itu jika textbox1="BRG02" maka
        ElseIf ComboBox1.Text = "BRG02" Then

            'isikan textbox2 dengan "Laptop"
            TextBox2.Text = "Laptop"

            'isikan textbox3 dengan "Pcs"
            TextBox3.Text = "Pcs"

            'isikan textbox4 dengan "2"
            TextBox4.Text = "2"

            'isikan textbox5 dengan "8000000"
            TextBox5.Text = "8000000"

            'selain itu jika textbox1="BRG03" maka
        ElseIf ComboBox1.Text = "BRG03" Then

            'isikan textbox2 dengan "Bantal" 
            TextBox2.Text = "Bantal"

            'isikan textbox3 dengan "Pcs" 
            TextBox3.Text = "Pcs"

            'isikan textbox4 dengan "22" 
            TextBox4.Text = "22"

            'isikan textbox5 dengan "60000" 
            TextBox5.Text = "60000"

            'selain itu jika textbox1="BRG04" maka
        ElseIf ComboBox1.Text = "BRG04" Then

            'isikan textbox5 dengan "Guling" 
            TextBox2.Text = "Guling"

            'isikan textbox5 dengan "Pcs" 
            TextBox3.Text = "Pcs"

            'isikan textbox5 dengan "5" 
            TextBox4.Text = "5"

            'isikan textbox5 dengan "35000" 
            TextBox5.Text = "35000"


            'selain kondisi diatas maka
        ElseIf ComboBox1.Text = "BRG05" Then

            'isikan textbox5 dengan "Guling" 
            TextBox2.Text = "ADE"

            'isikan textbox5 dengan "Pcs" 
            TextBox3.Text = "DIANTI"

            'isikan textbox5 dengan "5" 
            TextBox4.Text = "ADE"

            'isikan textbox5 dengan "35000" 
            TextBox5.Text = "DIANTI"


            'selain kondisi diatas maka
        Else
            'textbox2,3,4,5 dikosongkan
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
        End If
    End Sub
End Class