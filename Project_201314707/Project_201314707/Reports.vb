
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class Reports
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Admin.Visible = True
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim sqlstr As String
        If rbtn_sngartist.Checked = True Then
            sqlstr = "Select Artist.name, count(Song.ID) As Songs From Artist left join Song on Artist.ID = Song.artist_id Group by Artist.name Order by Artist.name"
        ElseIf rbtn_playlistscreated.Checked = True Then
            sqlstr = "Select Count(Playlist.name) As 'Numero de Playlist' From Playlist"
        ElseIf rbtn_timesinplaylist.Checked = True Then
            sqlstr = "SELECT Song.name, count(Playlist.name) As Playlists FROM  Playlist INNER JOIN PlaylistDetails ON Playlist.ID = PlaylistDetails.playlist_id INNER JOIN Song ON PlaylistDetails.song_id = Song.ID Group by song.name Order by song.name"
        ElseIf rbtn_top3artists.Checked = True Then
            sqlstr = "Select Top 3 Artist.name From Artist Order by name ASC"
        ElseIf rbtn_top3genre.Checked = True Then
            sqlstr = "Select Top 3 Song.genre From Song Group by song.genre Order by genre ASC"
        ElseIf rbtn_top3songs.Checked = True Then
            sqlstr = "Select Top 3 Song.name From Song Order by name ASC"
        Else
            MsgBox("Select a report to generate !", vbExclamation, "Error")
        End If
        GenerateReport(sqlstr)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sfd.ShowDialog()
        If sfd.FileName = "" Then
            MsgBox("Error saving, enter name", vbExclamation, "Error")
        Else
            ExportPDF()
            MsgBox("PDF Saved !", vbInformation, "Done !")
        End If
    End Sub


    'REPORTING SECTION

    Sub ExportPDF()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName + ".pdf", FileMode.Create))
        Dim font12B As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12N As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim p1 As New Phrase
        Dim chunk As Chunk = New Chunk("REPORTE GENERADO EN " + Now.ToString("yyyy/MM/dd/"))
        p1 = New Phrase("", chunk.ToString, font12B)
        doc.Open()
        doc.Add(p1)
        Dim PdfTable As New PdfPTable(8)
        PdfTable.TotalWidth = 490.0F
        PdfTable.LockedWidth = True

        Dim widths As Single() = New Single() {0.3F, 1.0F, 2.0F, 1.0F, 1.0F, 0.5F, 1.0F, 1.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1
        PdfTable.SpacingBefore = 2.0F

        Dim PdfCell As PdfPCell = Nothing

        PdfCell = New PdfPCell(New Phrase(New Chunk("#", font12B)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Center
        PdfTable.AddCell(PdfCell)

        Dim dt As DataTable = getDTr1(1)


    End Sub

    Function getDTr1(colums As Integer) As DataTable

        Dim DT As New DataTable("MyDT")
        Dim Col1 As New DataColumn(DataGridView1.Columns(0).HeaderText.ToString, GetType(String))

    End Function

End Class