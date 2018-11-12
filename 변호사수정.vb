Public Class 변호사수정
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Public qqrw As String
    Dim sql1 As String '삭제용 sql문
    Dim strsql As String
    Private Sub 변호사수정_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(600)

        qqrw = 변호사.변호사이름q

        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 변호사리스트 Where 변호사 = '" & qqrw & "'"

        rs.Open(strsql)

        변1.Text = rs.Fields!변호사.Value

        If rs.Fields!직급.Value Is DBNull.Value Then
        Else
            변2.Text = rs.Fields!직급.Value
        End If

        If rs.Fields!이니셜.Value Is DBNull.Value Then
        Else
            변3.Text = rs.Fields!이니셜.Value
        End If

        If rs.Fields!주민번호.Value Is DBNull.Value Then
        Else
            변4.Text = rs.Fields!주민번호.Value
        End If

        If rs.Fields!전화번호.Value Is DBNull.Value Then
        Else
            변7.Text = rs.Fields!전화번호.Value
        End If

        If rs.Fields!변호사등록번호.Value Is DBNull.Value Then
        Else
            변6.Text = rs.Fields!변호사등록번호.Value
        End If

        If rs.Fields!주소.Value Is DBNull.Value Then
        Else
            변5.Text = rs.Fields!주소.Value
        End If

        If rs.Fields!이메일.Value Is DBNull.Value Then
        Else
            변8.Text = rs.Fields!이메일.Value
        End If


        If rs.Fields!계약일.Value Is DBNull.Value Then
        Else
            변9.SetSelectionRange(rs.Fields!계약일.Value, rs.Fields!계약일.Value)
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn

       
        strsql = "update 변호사리스트 set 변호사 = '" & 변1.Text & "', 직급 = '" & 변2.Text & "', 이니셜 = '" & 변3.Text & "', 주민번호 = '" & 변4.Text & "', 전화번호 = '" & 변7.Text & "', 변호사등록번호 = '" & 변6.Text & "', 계약일 = '" & 변9.SelectionStart & "', 주소 = '" & 변5.Text & "', 이메일 = '" & 변8.Text & "' Where 변호사 = '" & qqrw & "'"


        cn.Execute(strsql)

        '   rs.Close()

        MsgBox(qqrw & " 변호사의 수정내역을 데이터베이스에 정상적으로 반영하였습니다")
        System.Threading.Thread.Sleep(1000)
        변호사.갱신q()
        Me.Close()
    End Sub
End Class