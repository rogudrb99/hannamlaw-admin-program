


Public Class 실적리포트
    Dim cn As ADODB.Connection
    Dim rs As ADODB.Recordset
    Dim sql2 As String
    Dim 변 As String
    Dim sql As String ' 실적리포트
    Dim bungi As Integer
    Dim wol As Integer
    Dim year As Integer
    Dim cnr As ADODB.Connection
    Dim rsr As ADODB.Recordset



    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 실적리포트_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nalw As String
        nalw = Format(Now, "yyyy")
        년도텍스트.Text = nalw

        cn = New ADODB.Connection
        ' cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\rogud\Documents\의뢰인.accdb")
        cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\HannamLaw.accdb")

        rs = New ADODB.Recordset
        rs.ActiveConnection = cn




        sql2 = "select 변호사 from 변호사리스트 order by 변호사"


        rs.Open(sql2)

        Do Until rs.EOF
            변호사선.Items.Add(rs.Fields!변호사.Value)

            rs.MoveNext()
        Loop
        rs.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        변 = 변호사선.SelectedItem
        Dim Ymoney, Wmoney, Bmoney, Fmoney, Amoney As Integer
        Ymoney = 0
        Wmoney = 0
        Bmoney = 0
        Fmoney = 0
        Amoney = 0


        year = CInt(년도텍스트.Text())
        '  bungi = CInt(분기텍스트.Text())
        ' wol = CInt(월텍스트.Text())



        '!!!!!!!!!!!!!!!!!!각 연도별 배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-01-01# and 입금날짜 <= #" & year & "-12-31# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        '''''''''''''''''''''''''''''''''''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@2현재 무한루프 돌고있음@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제1업무수행인배분액.Value)

            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Ymoney = Ymoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()

        ''!!!!!!!!!!!!!!!!!    1월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-01-01# and 입금날짜 < #" & year & "-02-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월1.Text = Format(Wmoney, "Currency")
        Wmoney = 0

        ''!!!!!!!!!!!!!!!!!    2월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-02-01# and 입금날짜 < #" & year & "-03-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월2.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    3월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-03-01# and 입금날짜 < #" & year & "-04-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월3.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    4월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-04-01# and 입금날짜 < #" & year & "-05-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월4.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    5월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-05-01# and 입금날짜 < #" & year & "-06-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월5.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    6월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-06-01# and 입금날짜 < #" & year & "-07-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월6.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    7월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-07-01# and 입금날짜 < #" & year & "-08-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월7.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    8월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-08-01# and 입금날짜 < #" & year & "-09-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월8.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    9월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-09-01# and 입금날짜 < #" & year & "-10-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월9.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    10월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-10-01# and 입금날짜 < #" & year & "-11-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월10.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    11월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-11-01# and 입금날짜 < #" & year & "-12-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월11.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!    12월  배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-12-01# and 입금날짜 < #" & year + 1 & "-01-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If
            rs.MoveNext()

        Loop
        rs.Close()
        월12.Text = Format(Wmoney, "Currency")
        Wmoney = 0
        ''!!!!!!!!!!!!!!!!!!각 월별 배분액 합계
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and 입금날짜 <= #" & year & "-" & wol & "-30# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        '' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ' ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"
        ''sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & wol & "-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"

        'rs.Open(sql)
        'Do Until rs.EOF
        '    If rs.Fields!제1관여인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제1관여인배분액.Value)
        '    End If
        '    If rs.Fields!제2관여인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제2관여인배분액.Value)
        '    End If
        '    If rs.Fields!제3관여인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제3관여인배분액.Value)
        '    End If
        '    If rs.Fields!제4관여인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제4관여인배분액.Value)
        '    End If
        '    If rs.Fields!제5관여인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제5관여인배분액.Value)
        '    End If
        '    If rs.Fields!제1업무수행인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제2업무수행인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제3업무수행인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제4업무수행인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제5업무수행인.Value = 변 Then
        '        Wmoney = Wmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
        '    End If
        '    rs.MoveNext()

        'Loop
        'rs.Close()

        ''!!!!!!!!!!!!!!!!!!각 분기별 배분액 합계

        'Dim a, b As String '분기 달의 처음과 끝
        'If bungi = 1 Then
        '    a = "01"
        '    b = "03"
        'ElseIf bungi = 2 Then
        '    a = "04"
        '    b = "06"
        'ElseIf bungi = 3 Then
        '    a = "07"
        '    b = "09"
        'Else
        '    a = "10"
        '    b = "12"
        'End If
        'sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & a & "-01# and 입금날짜 <= #" & year & "-" & b & "-30# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        '' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ' ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        'rs.Open(sql)
        'Do Until rs.EOF
        '    If rs.Fields!제1관여인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제1관여인배분액.Value)
        '    End If
        '    If rs.Fields!제2관여인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제2관여인배분액.Value)
        '    End If
        '    If rs.Fields!제3관여인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제3관여인배분액.Value)
        '    End If
        '    If rs.Fields!제4관여인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제4관여인배분액.Value)
        '    End If
        '    If rs.Fields!제5관여인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제5관여인배분액.Value)
        '    End If
        '    If rs.Fields!제1업무수행인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제2업무수행인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제3업무수행인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제4업무수행인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
        '    End If
        '    If rs.Fields!제5업무수행인.Value = 변 Then
        '        Bmoney = Bmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
        '    End If

        '    rs.MoveNext()

        'Loop
        'rs.Close()


        '''''''''''''''1분기 합

        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-01-01# and 입금날짜 < #" & year & "-04-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If

            rs.MoveNext()

        Loop
        rs.Close()
        분1.Text = Format(Bmoney, "Currency")

        Bmoney = 0
        '''''''''''''''2분기 합

        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-04-01# and 입금날짜 < #" & year & "-07-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If

            rs.MoveNext()

        Loop
        rs.Close()
        분2.Text = Format(Bmoney, "Currency")
        Bmoney = 0
        '''''''''''''''3분기 합

        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-07-01# and 입금날짜 < #" & year & "-10-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If

            rs.MoveNext()

        Loop
        rs.Close()
        분3.Text = Format(Bmoney, "Currency")
        Bmoney = 0

        '''''''''''''''4분기 합

        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-10-01# and 입금날짜 < #" & year + 1 & "-01-01# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Bmoney = Bmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If

            rs.MoveNext()

        Loop
        rs.Close()
        분4.Text = Format(Bmoney, "Currency")

        Bmoney = 0

        ' sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-" & a & "-01# and 입금날짜 <= #" & year & "-" & b & "-31# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        '!!!!!!!!!!!!!!!!!!전반기 배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-01-01# and 입금날짜 <= #" & year & "-06-30# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"



        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Fmoney = Fmoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If

            rs.MoveNext()

        Loop
        rs.Close()

        '!!!!!!!!!!!!!!!!! 후반기 배분액 합계
        sql = "select * from 입금배분 where 입금날짜 >= #" & year & "-07-01# and 입금날짜 <= #" & year & "-12-31# and ( 제1관여인 = '" & 변 & "' or 제2관여인 = '" & 변 & "'or 제3관여인 = '" & 변 & "' or 제4관여인 = '" & 변 & "' or 제5관여인 = '" & 변 & "' or 제1업무수행인 = '" & 변 & "' or 제2업무수행인 = '" & 변 & "' or 제3업무수행인 = '" & 변 & "' or 제4업무수행인 = '" & 변 & "' or 제5업무수행인 = '" & 변 & "')"
        ' sql = "select * from 입금배분 where ((제1관여인 = '배승열' or 제2관여인 = '배승열') and 입금날짜 = #2018-01-01#)"
        ''''''sql = "select * from 입금배분 where 입금날짜 = #2018-01-01# and (제2관여인 = '배승열' or 제1관여인 = '배승열')"


        rs.Open(sql)
        Do Until rs.EOF
            If rs.Fields!제1관여인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제1관여인배분액.Value)
            End If
            If rs.Fields!제2관여인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제2관여인배분액.Value)
            End If
            If rs.Fields!제3관여인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제3관여인배분액.Value)
            End If
            If rs.Fields!제4관여인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제4관여인배분액.Value)
            End If
            If rs.Fields!제5관여인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제5관여인배분액.Value)
            End If
            If rs.Fields!제1업무수행인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제1업무수행인배분액.Value)
            End If
            If rs.Fields!제2업무수행인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제2업무수행인배분액.Value)
            End If
            If rs.Fields!제3업무수행인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제3업무수행인배분액.Value)
            End If
            If rs.Fields!제4업무수행인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제4업무수행인배분액.Value)
            End If
            If rs.Fields!제5업무수행인.Value = 변 Then
                Amoney = Amoney + CInt(rs.Fields!제5업무수행인배분액.Value)
            End If

            rs.MoveNext()

        Loop
        rs.Close()

        '실1.Text = Format(Wmoney, "Currency")
        ' 실2.Text = Format(Bmoney, "Currency")
        실3.Text = Format(Fmoney, "Currency")
        실4.Text = Format(Amoney, "Currency")
        실5.Text = Format(Ymoney, "Currency")



        'MsgBox(rs.Fields!의뢰인.Value())
        ' MsgBox(sql)
        '   rs.Open(sql)
        'Do Until rs.EOF

        'Loop

    End Sub
















    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   

        ' 실적리포트.PrintForm()

    End Sub






    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Me.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 100)
        'Me.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)

        'Try
        '    Me.PrintForm1.PrinterSettings = Me.PrintDialog1.PrinterSettings
        '    Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        '    Me.PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        'Catch ex As Exception
        'End Try

      
        '  PrintDocument1.Print()
        ' Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)


        '  Dim pr As New Printer
        '  pr.PaintPicture(Me, 500, 500, 1000, 1000)
        ' pr.EndDoc()

        'PrintDocument1.Print()
        실적인쇄.Show()
        'PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
    End Sub
End Class