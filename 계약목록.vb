Public Class 계약목록
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Public cnt As Integer '계약개수 저장 ==> REf 넘버 위해
    Dim sql1 As String '삭제용 sql문
    Dim strsql As String
    Dim qq As String
    Dim imsi As String
    Public refup As Integer 'refno을위한 순서
    Dim qr As Integer




    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles 계약목록뷰.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        계약추가.Show()

    End Sub

    Public Sub 계약목록_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnt = 0
        refup = 0

        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 계약리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            계약목록뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!비고.Value, rs.Fields!계약체결일.Value, rs.Fields!계약형태.Value, rs.Fields!청구방법.Value, rs.Fields!제1관여인.Value, rs.Fields!제1관여인비율.Value, rs.Fields!제2관여인.Value, rs.Fields!제2관여인비율.Value, rs.Fields!제3관여인.Value, rs.Fields!제3관여인비율.Value, rs.Fields!제4관여인.Value, rs.Fields!제4관여인비율.Value, rs.Fields!제5관여인.Value, rs.Fields!제5관여인비율.Value, rs.Fields!최초계약일.Value, rs.Fields!ReferenceNo.Value)
            cnt += 1

            'qq = rs.Fields!ReferenceNo.Value
            qq = rs.Fields!ReferenceNo.Value

            imsi = Mid(qq, 1, 3)
            qr = CInt(imsi)
            If refup < qr Then
                refup = qr
            End If

            rs.MoveNext()

        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim 계약이름 As String
        Dim 삭 As String

        삭 = 계약목록뷰.SelectedCells(16).Value
        계약이름 = 계약목록뷰.SelectedCells(0).Value
        '    의뢰인사업자번호 = 의뢰인뷰.SelectedCells(4).Value

        If MsgBox(계약이름 & " 의 계약을 정말 삭제하시겠습니까? ", vbInformation + vbYesNo, "삭제 확인") = vbYes Then
            ' sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 사업자번호 = '" & 의뢰인사업자번호 & "'"
            sql1 = "delete from 계약리스트 where 의뢰인 = '" & 계약이름 & "' and ReferenceNo = '" & 삭 & "'"

            cn.Execute(sql1)

            MsgBox(계약이름 & "의 계약을 정상적으로 삭제하였습니다")
        End If

        System.Threading.Thread.Sleep(1000)

        갱신w()
    End Sub

    Public Sub 갱신w()
        계약목록뷰.Rows.Clear()
        cn = New ADODB.Connection
        '  cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 계약리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            계약목록뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!비고.Value, rs.Fields!계약체결일.Value, rs.Fields!계약형태.Value, rs.Fields!청구방법.Value, rs.Fields!제1관여인.Value, rs.Fields!제1관여인비율.Value, rs.Fields!제2관여인.Value, rs.Fields!제2관여인비율.Value, rs.Fields!제3관여인.Value, rs.Fields!제3관여인비율.Value, rs.Fields!제4관여인.Value, rs.Fields!제4관여인비율.Value, rs.Fields!제5관여인.Value, rs.Fields!제5관여인비율.Value, rs.Fields!최초계약일.Value, rs.Fields!ReferenceNo.Value)
            qq = rs.Fields!ReferenceNo.Value

            imsi = Mid(qq, 1, 3)


            qr = CInt(imsi)
            If refup < qr Then
                refup = qr
            End If

            rs.MoveNext()
        Loop
    End Sub


End Class