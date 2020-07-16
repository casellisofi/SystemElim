Imports Microsoft.Office.Interop

Public Class CantCelulas
    Dim objcelula As New ECelulas
    Private Sub CantCelulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total.Text = objcelula.CantTotal
        sol.Text = objcelula.CantPorCede("Sol de Mayo")
        molina.Text = objcelula.CantPorCede("Molina Punta")
        mujeres.Text = objcelula.CantPorSexo("Mujer")
        hombre.Text = objcelula.CantPorSexo("Hombre")
        mixta.Text = objcelula.CantPorSexo("Hombre y Mujer")
        jovenes.Text = objcelula.CantPorDirigido("Jovenes")
        adolesc.Text = objcelula.CantPorDirigido("Adolescentes")
        matri.Text = objcelula.CantPorDirigido("Matrimonios")
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
            Dim total As String = CStr(objcelula.CantTotal())
            para3.Range.Text = "Total de Personas: " + total + vbCrLf

            Dim para4 As Word.Paragraph = doc.Paragraphs.Add()
            para4.Range.Text = "__________________________________________________________________________" + vbCrLf

            Dim para5 As Word.Paragraph = doc.Paragraphs.Add()
            para5.Range.Text = "Total en Sol de Mayo: " + CStr(objcelula.CantPorCede("Sol de Mayo")) + "                               " + "Total en Molina Punta: " + CStr(objcelula.CantPorCede("Molina Punta")) + vbCrLf
            Dim para6 As Word.Paragraph = doc.Paragraphs.Add()
            para6.Range.Text = "Total Celulas de Mujeres: " + CStr(objcelula.CantPorSexo("Mujer")) + "            " + "Total Celulas de Hombres: " + CStr(objcelula.CantPorSexo("Mujer")) + "            " + "Total de Celulas Mixtas: " + CStr(objcelula.CantPorSexo("Hombre y Mujer")) + vbCrLf
            Dim para7 As Word.Paragraph = doc.Paragraphs.Add()
            para7.Range.Text = "Total Celula de Jovenes: " + CStr(objcelula.CantPorDirigido("Jovenes")) + "            " + +"Total Celula de Adolescentes: " + CStr(objcelula.CantPorDirigido("Adolescentes")) + "          " + "Total Celula de Matrimonios: " + CStr(objcelula.CantPorDirigido("Matrimonios")) + vbCrLf

            Dim para8 As Word.Paragraph = doc.Paragraphs.Add()
            para8.Range.Text = "__________________________________________________________________________" + vbCrLf

            Dim save As New SaveFileDialog With {
                .FileName = "Listado de Celulas"
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