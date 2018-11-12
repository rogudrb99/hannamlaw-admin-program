Public Class 변호사추가
    Dim cnr As ADODB.Connection
    Dim rsr As ADODB.Recordset
    Dim q As String

    Dim strsql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cnr = New ADODB.Connection
        ' cnr.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cnr.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rsr = New ADODB.Recordset
        rsr.ActiveConnection = cnr

        strsql = "insert into 변호사리스트"
        strsql = strsql & " values('" & 변1.Text & "', '" & 변2.Text & "', '" & 변3.Text & "', '" & 변4.Text & "', '" & 변5.Text & "', '" & 변6.Text & "', '" & 변7.Text & "', '" & 변8.Text & "', '" & 변9.SelectionStart & "')"
        'MsgBox(strsql)

        'q = "insert into 변호사리스트 values('김f','밥','좀','주','세','요','알','았','2018-05-23')"
        ' q = "select * from 변호사리스트"
        cnr.Execute(strsql)

        '   rs.Close()

        MsgBox(변1.Text & " 변호사를 데이터베이스에 정상적으로 추가하였습니다")
        System.Threading.Thread.Sleep(1000)
        변호사.갱신q()
        Me.Close()

    End Sub

    Private Sub 변호사추가_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class