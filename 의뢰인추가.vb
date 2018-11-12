Public Class 의뢰인추가
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset

    Dim strsql As String


    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 의추8.TextChanged

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn

        strsql = "insert into 의뢰인리스트(의뢰인, 이니셜, 이메일주소, 주민번호, 주소, 사업자번호, 최초계약일, 연락처, 실무담당자)"
        strsql = strsql & "values('" & 의추1.Text & "', '" & 의추4.Text & "', '" & 의추5.Text & "', '" & 의추2.Text & "', '" & 의추6.Text & "', '" & 의추7.Text & "', '" & 의추9.SelectionStart & "', '" & 의추3.Text & "', '" & 의추8.Text & "')"



        cn.Execute(strsql)

        '   rs.Close()

        MsgBox(의추1.Text & " 의뢰인을 데이터베이스에 정상적으로 추가하였습니다")
        System.Threading.Thread.Sleep(1000)
        의뢰인.갱신u()
        Me.Close()
    End Sub

    Private Sub 의뢰인추가_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    

       




    End Sub
End Class