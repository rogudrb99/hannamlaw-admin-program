<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button5.Location = New System.Drawing.Point(66, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(179, 99)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "의뢰인 DB"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button6.Location = New System.Drawing.Point(263, 317)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 99)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "변호사 DB"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button7.Location = New System.Drawing.Point(468, 317)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(179, 99)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "계약 DB"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button8.Location = New System.Drawing.Point(666, 317)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(179, 99)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "입금/배분 DB"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(12, 446)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "V1.7"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button9.Location = New System.Drawing.Point(872, 317)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(179, 99)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "변호사         실적 리포트"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(480, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(613, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Microsoft Access가 설치되어 있고, 프로그램 경로에 HannamLaw.accdb 파일이 존재해야 합니다."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(978, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "DB 백업하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.hannamlaw.My.Resources.Resources.메인1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1105, 482)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Hannam Law"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
