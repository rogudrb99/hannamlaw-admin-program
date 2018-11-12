Public Class 입금배분추가
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Dim rsq As ADODB.Recordset

    Dim sql1 As String '삭제용 sql문
    Dim sql2 As String
    Dim strsql As String
    Dim sqlgo As String '입금배분추가 sql문저장
    Dim sqlchu As String
    Dim gye As Date '계약체결일
    Dim w As Integer
    Dim sqlreal As String ''입금배분추가 레알
    Dim totsu As Integer '총수임관여비율'
    Dim s1, s2, s3, s4, s5 As Double '수임관여비율 돈'
    Dim s1n, s2n, s3n, s4n, s5n As String '수임관여인별 이름'
    Dim s1b, s2b, s3b, s4b, s5b As Double '수임관여인 비율'
    Dim u1, u2, u3, u4, u5 As Double '업무수행인 돈'
    Dim u1n, u2n, u3n, u4n, u5n As String '업무수행인 이름'
    Dim u1b, u2b, u3b, u4b, u5b As Double '업무수행인 비율'

    Dim money As Integer


    Dim ip As Date '입금일

    Private Sub 입금배분_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        '    cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn

        sql2 = "select 변호사 from 변호사리스트 order by 변호사"

        rs.Open(sql2)

        Do Until rs.EOF
            업1.Items.Add(rs.Fields!변호사.Value)
            업2.Items.Add(rs.Fields!변호사.Value)
            업3.Items.Add(rs.Fields!변호사.Value)
            업4.Items.Add(rs.Fields!변호사.Value)
            업5.Items.Add(rs.Fields!변호사.Value)
            rs.MoveNext()
        Loop

        rs.Close()


        strsql = " select * from 계약리스트"

        rs.Open(strsql)

        Do Until rs.EOF
            계약목록뷰.Rows.Add(rs.Fields!의뢰인.Value, rs.Fields!계약체결일.Value, rs.Fields!계약형태.Value, rs.Fields!청구방법.Value, rs.Fields!제1관여인.Value, rs.Fields!제1관여인비율.Value, rs.Fields!제2관여인.Value, rs.Fields!제2관여인비율.Value, rs.Fields!제3관여인.Value, rs.Fields!제3관여인비율.Value, rs.Fields!제4관여인.Value, rs.Fields!제4관여인비율.Value, rs.Fields!제5관여인.Value, rs.Fields!제5관여인비율.Value, rs.Fields!최초계약일.Value, rs.Fields!ReferenceNo.Value)
            rs.MoveNext()
        Loop
        rs.Close()

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim 계약이름 As String
        Dim 비 As Integer
        Dim 입 As Integer

        비 = CInt(비용텍스트박스.Text)
        입 = CInt(입2.Text)
        rsq = New ADODB.Recordset
        rsq.ActiveConnection = cn

        money = 입 - 비

        계약이름 = 계약목록뷰.SelectedCells(0).Value
        Dim 삭 As String

        삭 = 계약목록뷰.SelectedCells(15).Value

        '   MsgBox(계약이름)

        sqlchu = " select * from 계약리스트 where 의뢰인='" & 계약이름 & "' and ReferenceNo = '" & 삭 & "'"
        rs.Open(sqlchu)

        ip = 입1.SelectionStart()
        gye = rs.Fields!계약체결일.Value()

        w = DateDiff(DateInterval.Day, ip, gye)  '계약체결일과 입금일의 차이 (단 day임 -> 나눠주어야함)
        w = w / 365  '일을 년으로 바꿈

        If w < 1 Then    'totsu 총수임관여비율

            totsu = 20
        ElseIf w < 2 Then
            totsu = 15
        ElseIf w < 3 Then
            totsu = 10
        Else
            totsu = 5

        End If

        s1n = rs.Fields!제1관여인.Value()
        s1b = (rs.Fields!제1관여인비율.Value() * totsu) / 100  's1n 이름, s1b 비율 s1 총받는돈
        s1 = money * s1b / 100
        s2n = rs.Fields!제2관여인.Value()
        s2b = (rs.Fields!제2관여인비율.Value() * totsu) / 100
        s2 = money * s2b / 100
        s3n = rs.Fields!제3관여인.Value()
        s3b = (rs.Fields!제3관여인비율.Value() * totsu) / 100
        s3 = money * s3b / 100
        s4n = rs.Fields!제4관여인.Value()
        s4b = (rs.Fields!제4관여인비율.Value() * totsu) / 100
        s4 = money * s4b / 100
        s5n = rs.Fields!제5관여인.Value()
        s5b = (rs.Fields!제5관여인비율.Value() * totsu) / 100
        s5 = money * s5b / 100

        '수임관여인별 비율을 고려하여 총수임관여비율 곱해서 계산하여 부여해야함.

        Dim gop As Integer '계약형태에 따른 곱한 값

        If rs.Fields!계약형태.Value = "법률자문" Then
            gop = 80
        Else
            gop = 40

        End If

        u1n = 업1.SelectedItem
        u1b = CDbl(업1비.Text)
        u1 = (money * u1b * gop) / 10000
        u2n = 업2.SelectedItem
        u2b = CDbl(업2비.Text)
        u2 = (money * u2b * gop) / 10000
        u3n = 업3.SelectedItem
        u3b = CDbl(업3비.Text)
        u3 = (money * u3b * gop) / 10000
        u4n = 업4.SelectedItem
        u4b = CDbl(업4비.Text)
        u4 = (money * u4b * gop) / 10000
        u5n = 업5.SelectedItem
        u5b = CDbl(업5비.Text)
        u5 = (money * u5b * gop) / 10000

        '  MsgBox("insert into 입금배분 values('" & rs.Fields!의뢰인.Value() & "', '" & rs.Fields!계약형태.Value() & "', '" & ip & "', '" & money & "', '" & totsu & "', '" & s1n & "', '" & s1b & "', '" & s1 & "', '" & s2n & "', '" & s2b & "', '" & s2 & "', '" & s3n & "', '" & s3b & "', '" & s3 & "', '" & s4n & "', '" & s4b & "', '" & s4 & "', '" & s5n & "', '" & s5b & "', '" & s5 & "', '" & u1n & "', '" & u1b & "', '" & u1 & "', '" & u2n & "', '" & u2b & "', '" & u2 & "', '" & u3n & "', '" & u3b & "', '" & u3 & "', '" & u4n & "', '" & u4b & "', '" & u4 & "', '" & u5n & "', '" & u5b & "', '" & u5 & "', '" & invo.Text & "', '" & rs.Fields!ReferenceNo.Value() & "')")
        sqlreal = "insert into 입금배분 values('" & rs.Fields!의뢰인.Value() & "', '" & rs.Fields!계약형태.Value() & "', '" & ip & "', '" & 입 & "', '" & 비 & "', '" & totsu & "', '" & s1n & "', '" & s1b & "', '" & s1 & "', '" & s2n & "', '" & s2b & "', '" & s2 & "', '" & s3n & "', '" & s3b & "', '" & s3 & "', '" & s4n & "', '" & s4b & "', '" & s4 & "', '" & s5n & "', '" & s5b & "', '" & s5 & "', '" & u1n & "', '" & u1b & "', '" & u1 & "', '" & u2n & "', '" & u2b & "', '" & u2 & "', '" & u3n & "', '" & u3b & "', '" & u3 & "', '" & u4n & "', '" & u4b & "', '" & u4 & "', '" & u5n & "', '" & u5b & "', '" & u5 & "', '" & invo.Text & "', '" & rs.Fields!ReferenceNo.Value() & "')"



        cn.Execute(sqlreal)




        MsgBox(rs.Fields!의뢰인.Value & " 의뢰인에 대한 입금/배분을 정상적으로 추가하였습니다.")
        rs.Close()
        System.Threading.Thread.Sleep(1000)
        입금배분.갱신a()

        Me.Close()

    End Sub

    Private Sub 계약목록뷰_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles 계약목록뷰.CellContentClick

    End Sub
End Class