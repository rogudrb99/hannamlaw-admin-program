Public Class 의뢰인수정
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Public qqr As String
    Dim sql1 As String '삭제용 sql문
    Dim strsql As String
    Private Sub 의뢰인수정_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(600)

        qqr = 의뢰인.의이

        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn


        strsql = " select * from 의뢰인리스트 Where 의뢰인 = '" & qqr & "'"

        rs.Open(strsql)

        의추1.Text = rs.Fields!의뢰인.Value
        If rs.Fields!주민번호.Value Is DBNull.Value Then
        Else
            의추2.Text = rs.Fields!주민번호.Value
        End If
        If rs.Fields!연락처.Value Is DBNull.Value Then
        Else
            의추3.Text = rs.Fields!연락처.Value
        End If

        의추4.Text = rs.Fields!이니셜.Value

        If rs.Fields!이메일주소.Value Is DBNull.Value Then
        Else
            의추5.Text = rs.Fields!이메일주소.Value
        End If

        If rs.Fields!주소.Value Is DBNull.Value Then
        Else
            의추6.Text = rs.Fields!주소.Value
        End If

        If rs.Fields!사업자번호.Value Is DBNull.Value Then
        Else
            의추7.Text = rs.Fields!사업자번호.Value
        End If

        If rs.Fields!실무담당자.Value Is DBNull.Value Then
        Else
            의추8.Text = rs.Fields!실무담당자.Value
        End If




        의추9.SetSelectionRange(rs.Fields!최초계약일.Value, rs.Fields!최초계약일.Value)




        '    Dim 의뢰인이름 As String
        '    Dim 삭 As String
        '    삭 = 의뢰인뷰.SelectedCells(1).Value
        '    의뢰인이름 = 의뢰인뷰.SelectedCells(0).Value
        '    '    의뢰인사업자번호 = 의뢰인뷰.SelectedCells(4).Value

        '    ' sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 사업자번호 = '" & 의뢰인사업자번호 & "'"

        '    If MsgBox(의뢰인이름 & " 의뢰인을 정말 삭제하시겠습니까? ", vbInformation + vbYesNo, "삭제 확인") = vbYes Then
        '        'MsgBox(의뢰인이름 & 삭)
        '        sql1 = "delete from 의뢰인리스트 where 의뢰인 = '" & 의뢰인이름 & "' and 이니셜 = '" & 삭 & "'"

        '        cn.Execute(sql1)
        '        MsgBox(의뢰인이름 & " 의뢰인을 정상적으로 삭제하였습니다.")
        '    End If





    End Sub




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn

        'strsql = "insert into 의뢰인리스트(의뢰인, 이니셜, 이메일주소, 주민번호, 주소, 사업자번호, 최초계약일, 연락처, 실무담당자)"
        'strsql = strsql & "values('" & 의추1.Text & "', '" & 의추4.Text & "', '" & 의추5.Text & "', '" & 의추2.Text & "', '" & 의추6.Text & "', '" & 의추7.Text & "', '" & 의추9.SelectionStart & "', '" & 의추3.Text & "', '" & 의추8.Text & "')"

        strsql = "update 의뢰인리스트 set 의뢰인 = '" & 의추1.Text & "', 이니셜 = '" & 의추4.Text & "', 이메일주소 = '" & 의추5.Text & "', 주민번호 = '" & 의추2.Text & "', 주소 = '" & 의추6.Text & "', 사업자번호 = '" & 의추7.Text & "', 최초계약일 = '" & 의추9.SelectionStart & "', 연락처 = '" & 의추3.Text & "', 실무담당자 = '" & 의추8.Text & "' Where 의뢰인 = '" & qqr & "'"


        cn.Execute(strsql)

        '   rs.Close()

        MsgBox(qqr & " 의뢰인의 수정내역을 데이터베이스에 정상적으로 반영하였습니다")
        System.Threading.Thread.Sleep(1000)
        의뢰인.갱신u()
        Me.Close()
    End Sub
End Class