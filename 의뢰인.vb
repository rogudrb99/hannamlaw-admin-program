Public Class 의뢰인

    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset

    Dim sql1 As String '삭제용 sql문
    Dim strsql As String

    Public 의이 As String
    Public 삭제 As String


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub 의뢰인_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 의뢰인리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            의뢰인뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!이니셜.Value, rs.Fields!이메일주소.Value, rs.Fields!주민번호.Value, rs.Fields!주소.Value, rs.Fields!사업자번호.Value, rs.Fields!최초계약일.Value, rs.Fields!연락처.Value, rs.Fields!실무담당자.Value)
            rs.MoveNext()
        Loop





    End Sub
    Public Sub 갱신u()
        의뢰인뷰.Rows.Clear()
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 의뢰인리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            의뢰인뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!이니셜.Value, rs.Fields!이메일주소.Value, rs.Fields!주민번호.Value, rs.Fields!주소.Value, rs.Fields!사업자번호.Value, rs.Fields!최초계약일.Value, rs.Fields!연락처.Value, rs.Fields!실무담당자.Value)
            rs.MoveNext()
        Loop

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        의뢰인추가.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click




        Dim 의뢰인이름 As String
        Dim 삭 As String
        삭 = 의뢰인뷰.SelectedCells(1).Value
        의뢰인이름 = 의뢰인뷰.SelectedCells(0).Value
        '    의뢰인사업자번호 = 의뢰인뷰.SelectedCells(4).Value

        ' sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 사업자번호 = '" & 의뢰인사업자번호 & "'"

        If MsgBox(의뢰인이름 & " 의뢰인을 정말 삭제하시겠습니까? ", vbInformation + vbYesNo, "삭제 확인") = vbYes Then
            'MsgBox(의뢰인이름 & 삭)
            sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 이니셜 = '" & 삭 & "'"

            cn.Execute(sql1)
            MsgBox(의뢰인이름 & " 의뢰인을 정상적으로 삭제하였습니다.")
        End If

        System.Threading.Thread.Sleep(1000)
        갱신u()



    End Sub

    Private Sub 의뢰인뷰_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles 의뢰인뷰.CellContentClick

    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click


       
        삭제 = 의뢰인뷰.SelectedCells(1).Value
        의이 = 의뢰인뷰.SelectedCells(0).Value
        의뢰인수정.Show()
        '    의뢰인사업자번호 = 의뢰인뷰.SelectedCells(4).Value

        ' sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 사업자번호 = '" & 의뢰인사업자번호 & "'"


        
    End Sub
End Class