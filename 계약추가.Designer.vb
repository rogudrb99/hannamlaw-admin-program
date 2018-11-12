<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 계약추가
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
        Me.계추의뢰인 = New System.Windows.Forms.ComboBox()
        Me.계추1 = New System.Windows.Forms.MonthCalendar()
        Me.법률 = New System.Windows.Forms.RadioButton()
        Me.사건 = New System.Windows.Forms.RadioButton()
        Me.정액 = New System.Windows.Forms.RadioButton()
        Me.요율 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.수1 = New System.Windows.Forms.ComboBox()
        Me.수1비 = New System.Windows.Forms.TextBox()
        Me.수2비 = New System.Windows.Forms.TextBox()
        Me.수2 = New System.Windows.Forms.ComboBox()
        Me.수3비 = New System.Windows.Forms.TextBox()
        Me.수3 = New System.Windows.Forms.ComboBox()
        Me.수4비 = New System.Windows.Forms.TextBox()
        Me.수4 = New System.Windows.Forms.ComboBox()
        Me.수5비 = New System.Windows.Forms.TextBox()
        Me.수5 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.계약비고 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '계추의뢰인
        '
        Me.계추의뢰인.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.계추의뢰인.FormattingEnabled = True
        Me.계추의뢰인.Location = New System.Drawing.Point(23, 121)
        Me.계추의뢰인.Name = "계추의뢰인"
        Me.계추의뢰인.Size = New System.Drawing.Size(220, 33)
        Me.계추의뢰인.TabIndex = 0
        Me.계추의뢰인.Text = "의뢰인 선택"
        '
        '계추1
        '
        Me.계추1.Location = New System.Drawing.Point(23, 197)
        Me.계추1.Name = "계추1"
        Me.계추1.TabIndex = 1
        '
        '법률
        '
        Me.법률.AutoSize = True
        Me.법률.Checked = True
        Me.법률.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.법률.Location = New System.Drawing.Point(27, 38)
        Me.법률.Name = "법률"
        Me.법률.Size = New System.Drawing.Size(98, 25)
        Me.법률.TabIndex = 2
        Me.법률.TabStop = True
        Me.법률.Text = "법률 자문"
        Me.법률.UseVisualStyleBackColor = True
        '
        '사건
        '
        Me.사건.AutoSize = True
        Me.사건.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.사건.Location = New System.Drawing.Point(27, 70)
        Me.사건.Name = "사건"
        Me.사건.Size = New System.Drawing.Size(98, 25)
        Me.사건.TabIndex = 3
        Me.사건.Text = "사건 위임"
        Me.사건.UseVisualStyleBackColor = True
        '
        '정액
        '
        Me.정액.AutoSize = True
        Me.정액.Checked = True
        Me.정액.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.정액.Location = New System.Drawing.Point(27, 32)
        Me.정액.Name = "정액"
        Me.정액.Size = New System.Drawing.Size(60, 25)
        Me.정액.TabIndex = 5
        Me.정액.TabStop = True
        Me.정액.Text = "정액"
        Me.정액.UseVisualStyleBackColor = True
        '
        '요율
        '
        Me.요율.AutoSize = True
        Me.요율.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.요율.Location = New System.Drawing.Point(27, 64)
        Me.요율.Name = "요율"
        Me.요율.Size = New System.Drawing.Size(60, 25)
        Me.요율.TabIndex = 6
        Me.요율.Text = "요율"
        Me.요율.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.법률)
        Me.GroupBox1.Controls.Add(Me.사건)
        Me.GroupBox1.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 115)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "계약 형태"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.요율)
        Me.GroupBox2.Controls.Add(Me.정액)
        Me.GroupBox2.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 108)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "청구 방법"
        '
        '수1
        '
        Me.수1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.수1.FormattingEnabled = True
        Me.수1.Location = New System.Drawing.Point(478, 90)
        Me.수1.Name = "수1"
        Me.수1.Size = New System.Drawing.Size(141, 29)
        Me.수1.TabIndex = 9
        Me.수1.Text = "제1 수임관여인"
        '
        '수1비
        '
        Me.수1비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.수1비.Location = New System.Drawing.Point(639, 90)
        Me.수1비.Name = "수1비"
        Me.수1비.Size = New System.Drawing.Size(52, 29)
        Me.수1비.TabIndex = 10
        Me.수1비.Text = "100"
        Me.수1비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '수2비
        '
        Me.수2비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.수2비.Location = New System.Drawing.Point(639, 151)
        Me.수2비.Name = "수2비"
        Me.수2비.Size = New System.Drawing.Size(52, 29)
        Me.수2비.TabIndex = 12
        Me.수2비.Text = "0"
        Me.수2비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '수2
        '
        Me.수2.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.수2.FormattingEnabled = True
        Me.수2.Location = New System.Drawing.Point(478, 152)
        Me.수2.Name = "수2"
        Me.수2.Size = New System.Drawing.Size(141, 29)
        Me.수2.TabIndex = 11
        Me.수2.Text = "제2 수임관여인"
        '
        '수3비
        '
        Me.수3비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.수3비.Location = New System.Drawing.Point(639, 213)
        Me.수3비.Name = "수3비"
        Me.수3비.Size = New System.Drawing.Size(52, 29)
        Me.수3비.TabIndex = 14
        Me.수3비.Text = "0"
        Me.수3비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '수3
        '
        Me.수3.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.수3.FormattingEnabled = True
        Me.수3.Location = New System.Drawing.Point(478, 214)
        Me.수3.Name = "수3"
        Me.수3.Size = New System.Drawing.Size(141, 29)
        Me.수3.TabIndex = 13
        Me.수3.Text = "제3 수임관여인"
        '
        '수4비
        '
        Me.수4비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.수4비.Location = New System.Drawing.Point(639, 273)
        Me.수4비.Name = "수4비"
        Me.수4비.Size = New System.Drawing.Size(52, 29)
        Me.수4비.TabIndex = 16
        Me.수4비.Text = "0"
        Me.수4비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '수4
        '
        Me.수4.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.수4.FormattingEnabled = True
        Me.수4.Location = New System.Drawing.Point(478, 273)
        Me.수4.Name = "수4"
        Me.수4.Size = New System.Drawing.Size(141, 29)
        Me.수4.TabIndex = 15
        Me.수4.Text = "제4 수임관여인"
        '
        '수5비
        '
        Me.수5비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.수5비.Location = New System.Drawing.Point(639, 338)
        Me.수5비.Name = "수5비"
        Me.수5비.Size = New System.Drawing.Size(52, 29)
        Me.수5비.TabIndex = 18
        Me.수5비.Text = "0"
        Me.수5비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '수5
        '
        Me.수5.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.수5.FormattingEnabled = True
        Me.수5.Location = New System.Drawing.Point(478, 338)
        Me.수5.Name = "수5"
        Me.수5.Size = New System.Drawing.Size(141, 29)
        Me.수5.TabIndex = 17
        Me.수5.Text = "제5 수임관여인"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.Button1.Location = New System.Drawing.Point(748, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 389)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "계약 추가하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(322, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 54)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "계약 추가하기"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "계약할 의뢰인 선택"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "계약 체결일 선택"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("휴먼편지체", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(697, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("휴먼편지체", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(697, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 26)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("휴먼편지체", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(697, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 26)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("휴먼편지체", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(697, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 26)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("휴먼편지체", 16.0!)
        Me.Label8.Location = New System.Drawing.Point(697, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 26)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "%"
        '
        '계약비고
        '
        Me.계약비고.Location = New System.Drawing.Point(23, 415)
        Me.계약비고.Multiline = True
        Me.계약비고.Name = "계약비고"
        Me.계약비고.Size = New System.Drawing.Size(670, 60)
        Me.계약비고.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(18, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "비고"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.hannamlaw.My.Resources.Resources.hannam_CI
        Me.PictureBox1.Location = New System.Drawing.Point(764, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        '계약추가
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(938, 504)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.계약비고)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.수5비)
        Me.Controls.Add(Me.수5)
        Me.Controls.Add(Me.수4비)
        Me.Controls.Add(Me.수4)
        Me.Controls.Add(Me.수3비)
        Me.Controls.Add(Me.수3)
        Me.Controls.Add(Me.수2비)
        Me.Controls.Add(Me.수2)
        Me.Controls.Add(Me.수1비)
        Me.Controls.Add(Me.수1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.계추1)
        Me.Controls.Add(Me.계추의뢰인)
        Me.Name = "계약추가"
        Me.Text = "계약추가"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 계추의뢰인 As System.Windows.Forms.ComboBox
    Friend WithEvents 계추1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents 법률 As System.Windows.Forms.RadioButton
    Friend WithEvents 사건 As System.Windows.Forms.RadioButton
    Friend WithEvents 정액 As System.Windows.Forms.RadioButton
    Friend WithEvents 요율 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents 수1 As System.Windows.Forms.ComboBox
    Friend WithEvents 수1비 As System.Windows.Forms.TextBox
    Friend WithEvents 수2비 As System.Windows.Forms.TextBox
    Friend WithEvents 수2 As System.Windows.Forms.ComboBox
    Friend WithEvents 수3비 As System.Windows.Forms.TextBox
    Friend WithEvents 수3 As System.Windows.Forms.ComboBox
    Friend WithEvents 수4비 As System.Windows.Forms.TextBox
    Friend WithEvents 수4 As System.Windows.Forms.ComboBox
    Friend WithEvents 수5비 As System.Windows.Forms.TextBox
    Friend WithEvents 수5 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents 계약비고 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
