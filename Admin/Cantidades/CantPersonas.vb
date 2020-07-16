Imports Microsoft.Office.Interop


Public Class CantPersona
    Dim objPersona As New EPersonas

    Private Sub CantPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total.Text = objPersona.CantTotal()
        sol.Text = objPersona.CantPorCede("Sol de Mayo")
        molina.Text = objPersona.CantPorCede("Molina Punta")
        mujeresmolina.Text = objPersona.CantPorSexo("Molina Punta", "Mujer")
        hombresmolina.Text = objPersona.CantPorSexo("Molina Punta", "Hombre")
        mujeressol.Text = objPersona.CantPorSexo("Sol de Mayo", "Mujer")
        hombressol.Text = objPersona.CantPorSexo("Sol de Mayo", "Hombre")
        estudian.Text = objPersona.CantPorOcupacion("Estudian")
        trabajan.Text = objPersona.CantPorOcupacion("Trabajan")
        trabyestud.Text = objPersona.CantPorOcupacion("Trabajan y Estudian")
        otro.Text = objPersona.CantPorOcupacion("otro")
        ctes.Text = objPersona.CantPorLugar("Ctes")
        otrolugar.Text = objPersona.CantPorLugar("otro")
    End Sub

    Private Sub BPDF_Click(sender As Object, e As EventArgs) Handles BPDF.Click
        Try
            Dim doc As Word.Document = New Word.Document()
            'doc.Content.Text = "Hello World1"

            Dim para As Word.Paragraph = doc.Paragraphs.Add()
            'para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            Dim path As String = My.Application.Info.DirectoryPath

            para.Range.InsertParagraphAfter()

            Dim fileReader As String
            Dim nombre As String = IO.Path.Combine(path, "personas.txt")
            fileReader = My.Computer.FileSystem.ReadAllText(nombre)
            Dim para2 As Word.Paragraph = doc.Paragraphs.Add()
            para2.Range.Text = fileReader + vbCrLf + "_______________________________________________"

            Dim para3 As Word.Paragraph = doc.Paragraphs.Add()
            Dim total As String = CStr(objPersona.CantTotal())
            para3.Range.Text = "Total de Personas: " + total + vbCrLf

            Dim para4 As Word.Paragraph = doc.Paragraphs.Add()
            para4.Range.Text = "__________________________________________________________________________" + vbCrLf

            Dim para5 As Word.Paragraph = doc.Paragraphs.Add()
            para5.Range.Text = "Total en Sol de Mayo: " + CStr(objPersona.CantPorCede("Sol de Mayo")) + "                               " + "Total en Molina Punta: " + CStr(objPersona.CantPorCede("Molina Punta")) + vbCrLf
            Dim para6 As Word.Paragraph = doc.Paragraphs.Add()
            para6.Range.Text = "Total de Mujeres en Sol de Mayo: " + CStr(objPersona.CantPorSexo("Sol de Mayo", "Mujer")) + "            " + "Total de Mujeres en Molina Punta: " + CStr(objPersona.CantPorSexo("Molina Punta", "Mujer")) + vbCrLf
            Dim para7 As Word.Paragraph = doc.Paragraphs.Add()
            para7.Range.Text = "Total de Hombres en Sol de Mayo: " + CStr(objPersona.CantPorSexo("Sol de Mayo", "Hombre")) + "          " + "Total de Hombres en Molina Punta: " + CStr(objPersona.CantPorSexo("Molina Punta", "Hombre")) + vbCrLf

            Dim para8 As Word.Paragraph = doc.Paragraphs.Add()
            para8.Range.Text = "__________________________________________________________________________" + vbCrLf

            Dim para9 As Word.Paragraph = doc.Paragraphs.Add()
            para9.Range.Text = "Ocupación: " + vbCrLf
            Dim para10 As Word.Paragraph = doc.Paragraphs.Add()
            para10.Range.Text = "Estudian: " + CStr(objPersona.CantPorOcupacion("Estudian")) + "      " + "Trabajan: " + CStr(objPersona.CantPorOcupacion("Trabajan")) + "      " + "Trabajan y Estudian: " + CStr(objPersona.CantPorOcupacion("Trabajan y Estudian")) + "      " + "Otro: " + CStr(objPersona.CantPorOcupacion("Otro")) + vbCrLf
            Dim para11 As Word.Paragraph = doc.Paragraphs.Add()
            para11.Range.Text = "__________________________________________________________________________" + vbCrLf
            Dim para12 As Word.Paragraph = doc.Paragraphs.Add()
            para12.Range.Text = "Nacidos en Corrientes: " + CStr(objPersona.CantPorLugar("Corrientes")) + "        " + "Nacidos en otro lugar: " + CStr(objPersona.CantPorLugar("otro")) + vbCrLf



            Dim para13 As Word.Paragraph = doc.Paragraphs.Add()
            para13.Range.Text = "__________________________________________________________________________" + vbCrLf

            Dim save As New SaveFileDialog With {
                .FileName = "Listado de Personas"
            }
            save.ShowDialog()
            Dim s As String
            s = save.FileName

            doc.ExportAsFixedFormat(s, Word.WdExportFormat.wdExportFormatPDF)
            doc.Close(False)
            MessageBox.Show("EXITO!", "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class