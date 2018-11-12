

Public Class Form2


    Public Declare Sub Sleep Lib "kernel32.dll" (ByVal dwMilliseconds As Long)
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Me.Show()
        ' System.Threading.Thread.Sleep(2000)
        'Form1.Show()

        '  Sleep(200)

        ' Form1.Show()
        ' qq()



        ' System.Threading.Thread.Sleep(5000)
        '  Me.Hide()

    End Sub

    Public Sub qq()
        '   System.Threading.Thread.Sleep(2000)
        '  Form1.Show()
        '   '  Me.Hide()
        '  System.Threading.Thread.Sleep(2000)
        '  Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Form1.Show()
        '    System.Threading.Thread.Sleep(2000)
        'Me.Hide()
    End Sub

    
End Class