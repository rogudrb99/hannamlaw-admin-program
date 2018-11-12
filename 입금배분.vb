Public Class 입금배분
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset

    Dim sql1 As String '삭제용 sql문
    Dim strsql As String
    Private Sub 입금배분_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        'cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 입금배분"

        rs.Open(strsql)

        Do Until rs.EOF

            입금배분뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!계약형태.Value, rs.Fields!입금날짜.Value, Format(rs.Fields!입금액.Value, "Currency"), Format(rs.Fields!비용.Value, "Currency"), rs.Fields!총수임관여인배분비율.Value, rs.Fields!제1관여인.Value, rs.Fields!제1관여인배분비율.Value, Format(rs.Fields!제1관여인배분액.Value, "Currency"), rs.Fields!제2관여인.Value, rs.Fields!제2관여인배분비율.Value, Format(rs.Fields!제2관여인배분액.Value, "Currency"), rs.Fields!제3관여인.Value, rs.Fields!제3관여인배분비율.Value, Format(rs.Fields!제3관여인배분액.Value, "Currency"), rs.Fields!제4관여인.Value, rs.Fields!제4관여인배분비율.Value, Format(rs.Fields!제4관여인배분액.Value, "Currency"), rs.Fields!제5관여인.Value, rs.Fields!제5관여인배분비율.Value, Format(rs.Fields!제5관여인배분액.Value, "Currency"), rs.Fields!제1업무수행인.Value, rs.Fields!제1업무수행인배분비율.Value, Format(rs.Fields!제1업무수행인배분액.Value, "Currency"), rs.Fields!제2업무수행인.Value, rs.Fields!제2업무수행인배분비율.Value, Format(rs.Fields!제2업무수행인배분액.Value, "Currency"), rs.Fields!제3업무수행인.Value, rs.Fields!제3업무수행인배분비율.Value, Format(rs.Fields!제3업무수행인배분액.Value, "Currency"), rs.Fields!제4업무수행인.Value, rs.Fields!제4업무수행인배분비율.Value, Format(rs.Fields!제4업무수행인배분액.Value, "Currency"), rs.Fields!제5업무수행인.Value, rs.Fields!제5업무수행인배분비율.Value, Format(rs.Fields!제5업무수행인배분액.Value, "Currency"), rs.Fields!InvoiceNo.Value, rs.Fields!RefNo.Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        입금배분추가.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim 입금이름 As String
        Dim 삭 As String
        Dim 삭1 As String '입금날짜
        Dim 삭2 As String '입금액
        삭 = 입금배분뷰.SelectedCells(37).Value
        삭1 = 입금배분뷰.SelectedCells(2).Value
        삭2 = 입금배분뷰.SelectedCells(3).Value
        입금이름 = 입금배분뷰.SelectedCells(0).Value
        '    의뢰인사업자번호 = 의뢰인뷰.SelectedCells(4).Value
        삭2 = CInt(삭2)
        ' sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 사업자번호 = '" & 의뢰인사업자번호 & "'"

        'sql1 = "delete from 입금배분 where 의뢰인 = '" & 입금이름 & "' and 입금액 = " & 삭2 & " and 입금날짜 = " & 삭1

        If MsgBox(입금이름 & " 의 입금배분을 정말 삭제하시겠습니까? ", vbInformation + vbYesNo, "삭제 확인") = vbYes Then
            sql1 = "delete from 입금배분 where 의뢰인 = '" & 입금이름 & "' and 입금액 = " & 삭2


            'sql1 = "delete from 입금배분 where 의뢰인 = '" & 입금이름 & "'"

            ' MsgBox(sql1)
            cn.Execute(sql1)

            MsgBox(입금이름 & "의 입금배분을 정상적으로 삭제하였습니다")

        End If
        System.Threading.Thread.Sleep(1000)
        갱신a()


    End Sub

    Public Sub 갱신a()
        입금배분뷰.Rows.Clear()
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 입금배분"

        rs.Open(strsql)

        Do Until rs.EOF
            'MsgBox(rs.Fields!입금액.Value)
            'MsgBox(Format(rs.Fields!입금액.Value, "Currency"))
            '원래 입금배분뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!계약형태.Value, rs.Fields!입금날짜.Value, Format(rs.Fields!입금액.Value, "Currency"), rs.Fields!비용.Value, rs.Fields!총수임관여인배분비율.Value, rs.Fields!제1관여인.Value, rs.Fields!제1관여인배분비율.Value, rs.Fields!제1관여인배분액.Value, rs.Fields!제2관여인.Value, rs.Fields!제2관여인배분비율.Value, rs.Fields!제2관여인배분액.Value, rs.Fields!제3관여인.Value, rs.Fields!제3관여인배분비율.Value, rs.Fields!제3관여인배분액.Value, rs.Fields!제4관여인.Value, rs.Fields!제4관여인배분비율.Value, rs.Fields!제4관여인배분액.Value, rs.Fields!제5관여인.Value, rs.Fields!제5관여인배분비율.Value, rs.Fields!제5관여인배분액.Value, rs.Fields!제1업무수행인.Value, rs.Fields!제1업무수행인배분비율.Value, rs.Fields!제1업무수행인배분액.Value, rs.Fields!제2업무수행인.Value, rs.Fields!제2업무수행인배분비율.Value, rs.Fields!제2업무수행인배분액.Value, rs.Fields!제3업무수행인.Value, rs.Fields!제3업무수행인배분비율.Value, rs.Fields!제3업무수행인배분액.Value, rs.Fields!제4업무수행인.Value, rs.Fields!제4업무수행인배분비율.Value, rs.Fields!제4업무수행인배분액.Value, rs.Fields!제5업무수행인.Value, rs.Fields!제5업무수행인배분비율.Value, rs.Fields!제5업무수행인배분액.Value, rs.Fields!InvoiceNo.Value, rs.Fields!RefNo.Value)
            입금배분뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!계약형태.Value, rs.Fields!입금날짜.Value, Format(rs.Fields!입금액.Value, "Currency"), Format(rs.Fields!비용.Value, "Currency"), rs.Fields!총수임관여인배분비율.Value, rs.Fields!제1관여인.Value, rs.Fields!제1관여인배분비율.Value, Format(rs.Fields!제1관여인배분액.Value, "Currency"), rs.Fields!제2관여인.Value, rs.Fields!제2관여인배분비율.Value, Format(rs.Fields!제2관여인배분액.Value, "Currency"), rs.Fields!제3관여인.Value, rs.Fields!제3관여인배분비율.Value, Format(rs.Fields!제3관여인배분액.Value, "Currency"), rs.Fields!제4관여인.Value, rs.Fields!제4관여인배분비율.Value, Format(rs.Fields!제4관여인배분액.Value, "Currency"), rs.Fields!제5관여인.Value, rs.Fields!제5관여인배분비율.Value, Format(rs.Fields!제5관여인배분액.Value, "Currency"), rs.Fields!제1업무수행인.Value, rs.Fields!제1업무수행인배분비율.Value, Format(rs.Fields!제1업무수행인배분액.Value, "Currency"), rs.Fields!제2업무수행인.Value, rs.Fields!제2업무수행인배분비율.Value, Format(rs.Fields!제2업무수행인배분액.Value, "Currency"), rs.Fields!제3업무수행인.Value, rs.Fields!제3업무수행인배분비율.Value, Format(rs.Fields!제3업무수행인배분액.Value, "Currency"), rs.Fields!제4업무수행인.Value, rs.Fields!제4업무수행인배분비율.Value, Format(rs.Fields!제4업무수행인배분액.Value, "Currency"), rs.Fields!제5업무수행인.Value, rs.Fields!제5업무수행인배분비율.Value, Format(rs.Fields!제5업무수행인배분액.Value, "Currency"), rs.Fields!InvoiceNo.Value, rs.Fields!RefNo.Value)
            rs.MoveNext()
        Loop


    End Sub

    Private Sub 입금배분뷰_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles 입금배분뷰.CellContentClick

    End Sub
End Class