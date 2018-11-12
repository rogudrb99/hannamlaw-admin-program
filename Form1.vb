

Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '   Dim a As Date
        '   Dim b As Date
        '   a = 2018 - 5 - 23
        '     b()
        의뢰인.Show()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        의뢰인.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


        Form2.Show()
        System.Threading.Thread.Sleep(1000)
        Form2.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        변호사.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        계약목록.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        입금배분.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        실적리포트.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nalw As String
        nalw = Format(Now, "yyMMdd-HH-mm-DBbackup")
        nalw = "\Backup\" & nalw & ".accdb"


        My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\HannamLaw.accdb", My.Application.Info.DirectoryPath & nalw)
        MsgBox("데이터베이스 백업 완료")

    End Sub
End Class
