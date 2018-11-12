Public Class 계약추가
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset

    Dim cnr As ADODB.Connection
    Dim rsr As ADODB.Recordset
    Dim q As String
    Dim 계약형태 As String
    Dim 청구방법 As String
    Dim 관여인수 As Integer
    Dim refnum As String '레퍼런스넘버 개발해야함'
    Dim 최계일 As Date
    Dim strsql As String
    Dim sql3 As String
    Dim sql1 As String
    Dim sql2 As String

    Private Sub 계약추가_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        'cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")


        rs = New ADODB.Recordset
        rs.ActiveConnection = cn

        sql1 = "select 의뢰인 from 의뢰인리스트 order by 의뢰인"

        rs.Open(sql1)

        Do Until rs.EOF

            계추의뢰인.Items.Add(rs.Fields!의뢰인.Value)
            rs.MoveNext()
        Loop

        sql2 = "select 변호사 from 변호사리스트 order by 변호사"
        rs.Close()

        rs.Open(sql2)

        Do Until rs.EOF
            수1.Items.Add(rs.Fields!변호사.Value)
            수2.Items.Add(rs.Fields!변호사.Value)
            수3.Items.Add(rs.Fields!변호사.Value)
            수4.Items.Add(rs.Fields!변호사.Value)
            수5.Items.Add(rs.Fields!변호사.Value)
            rs.MoveNext()
        Loop


    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 수4.SelectedIndexChanged

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 수5.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cnr = New ADODB.Connection
        Dim q As String
        ' cnr.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cnr.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")
        If 법률.Checked = True Then
            계약형태 = "법률자문"
            q = "C"
        Else
            계약형태 = "사건위임"
            q = "L"

        End If

        If 정액.Checked = True Then
            청구방법 = "정액"
        Else
            청구방법 = "요율"


        End If

        'If 수5.SelectedItem <> "" Then
        '관여인수 = 5
        '
        'MsgBox("아무선택안함")
        'End Iffref

        'MsgBox(수1.SelectedItem)

        rsr = New ADODB.Recordset
        rsr.ActiveConnection = cnr

        sql3 = "select 최초계약일, 이니셜 from 의뢰인리스트 where 의뢰인 = '" & 계추의뢰인.SelectedItem & "'"
        rsr.Open(sql3)
        Dim 의뢰이니셜 As String
        최계일 = rsr.Fields!최초계약일.Value
        의뢰이니셜 = rsr.Fields!이니셜.Value
        Dim 년 As String
        rsr.Close()
        년 = 최계일.Year
        계약목록.cnt += 1

        Dim nalw As String
        nalw = Format(계추1.SelectionStart, "yy")
        ' MsgBox(nalw)

        Dim 수임이니셜 As String

        Dim sql4 As String '수임관여인 이니셜위함.
        sql4 = "select 이니셜 from 변호사리스트 where 변호사 = '" & 수1.SelectedItem & "'"
        rsr.Open(sql4)
        수임이니셜 = rsr.Fields!이니셜.Value
        rsr.Close()


        Dim qq As String
        Dim cntr As Integer
        cntr = 계약목록.refup + 1


        If cntr < 10 Then
            qq = "00" & CStr(cntr)
        ElseIf cntr < 100 Then
            qq = "0" & CStr(cntr)
        Else
            qq = CStr(cntr)

        End If


        refnum = qq & q & nalw & 수임이니셜 & 의뢰이니셜

        strsql = "insert into 계약리스트"
        strsql = strsql & " values('" & 계추의뢰인.SelectedItem & "', '" & 계약비고.Text & "', '" & 계추1.SelectionStart & "', '" & 계약형태 & "', '" & 청구방법 & "', '" & 수1.SelectedItem & "', '" & 수1비.Text & "', '" & 수2.SelectedItem & "', '" & 수2비.Text & "', '" & 수3.SelectedItem & "', '" & 수3비.Text & "', '" & 수4.SelectedItem & "', '" & 수4비.Text & "', '" & 수5.SelectedItem & "', '" & 수5비.Text & "', '" & 최계일 & "', '" & refnum & "')"

        ' MsgBox(strsql)

        cnr.Execute(strsql)

        rs.Close()

        MsgBox(계추의뢰인.Text & " 의 계약을 데이터베이스에 정상적으로 추가하였습니다")
        System.Threading.Thread.Sleep(1000)
        계약목록.갱신w()
        Me.Close()


    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub 수5비_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 수5비.TextChanged

    End Sub

    Private Sub 수2비_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 수2비.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class