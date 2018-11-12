Public Class 변호사
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Public 삭q As String
    Public 변호사이름q As String
    Dim sql1 As String '삭제용 sql문
    Dim strsql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        변호사추가.Show()
        '갱신q() ?????

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim 변호사이름 As String

        Dim 삭 As String
        삭 = 변호사뷰.SelectedCells(2).Value
        변호사이름 = 변호사뷰.SelectedCells(0).Value
        '    의뢰인사업자번호 = 의뢰인뷰.SelectedCells(4).Value
        If MsgBox(변호사이름 & " 변호사를 정말 삭제하시겠습니까? ", vbInformation + vbYesNo, "삭제 확인") = vbYes Then
            ' sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 사업자번호 = '" & 의뢰인사업자번호 & "'"
            sql1 = "delete from 변호사리스트 where 변호사 = '" & 변호사이름 & "' and 이니셜 = '" & 삭 & "'"

            cn.Execute(sql1)
            MsgBox(변호사이름 & " 변호사를 정상적으로 삭제하였습니다.")
        End If
        System.Threading.Thread.Sleep(1000)
        갱신q()
    End Sub

    Private Sub 변호사_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 변호사리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            변호사뷰.Rows.Add(rs.Fields!변호사.Value, rs.Fields!직급.Value, rs.Fields!이니셜.Value, rs.Fields!주민번호.Value, rs.Fields!주소.Value, rs.Fields!변호사등록번호.Value, rs.Fields!전화번호.Value, rs.Fields!이메일.Value, rs.Fields!계약일.Value)

            rs.MoveNext()
        Loop
    End Sub

    Public Sub 갱신q()
        변호사뷰.Rows.Clear()
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 변호사리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            변호사뷰.Rows.Add(rs.Fields!변호사.Value, rs.Fields!직급.Value, rs.Fields!이니셜.Value, rs.Fields!주민번호.Value, rs.Fields!주소.Value, rs.Fields!변호사등록번호.Value, rs.Fields!전화번호.Value, rs.Fields!이메일.Value, rs.Fields!계약일.Value)
            rs.MoveNext()
        Loop
        rs.Close()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click


        변호사이름q = 변호사뷰.SelectedCells(0).Value
        변호사수정.Show()

    End Sub
End Class