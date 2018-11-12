<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 입금배분추가
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.계약목록뷰 = New System.Windows.Forms.DataGridView()
        Me.계1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.계16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.입1 = New System.Windows.Forms.MonthCalendar()
        Me.입2 = New System.Windows.Forms.TextBox()
        Me.업5비 = New System.Windows.Forms.TextBox()
        Me.업5 = New System.Windows.Forms.ComboBox()
        Me.업4비 = New System.Windows.Forms.TextBox()
        Me.업4 = New System.Windows.Forms.ComboBox()
        Me.업3비 = New System.Windows.Forms.TextBox()
        Me.업3 = New System.Windows.Forms.ComboBox()
        Me.업2비 = New System.Windows.Forms.TextBox()
        Me.업2 = New System.Windows.Forms.ComboBox()
        Me.업1비 = New System.Windows.Forms.TextBox()
        Me.업1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.invo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.비용텍스트박스 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.계약목록뷰, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '계약목록뷰
        '
        Me.계약목록뷰.AllowUserToAddRows = False
        Me.계약목록뷰.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.계약목록뷰.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.계약목록뷰.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.계약목록뷰.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.계1, Me.계2, Me.계3, Me.계4, Me.계5, Me.계6, Me.계7, Me.계8, Me.계9, Me.계10, Me.계11, Me.계12, Me.계13, Me.계14, Me.계15, Me.계16})
        Me.계약목록뷰.Location = New System.Drawing.Point(35, 158)
        Me.계약목록뷰.Name = "계약목록뷰"
        Me.계약목록뷰.ReadOnly = True
        Me.계약목록뷰.RowTemplate.Height = 23
        Me.계약목록뷰.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.계약목록뷰.Size = New System.Drawing.Size(1595, 250)
        Me.계약목록뷰.TabIndex = 1
        '
        '계1
        '
        Me.계1.HeaderText = "의뢰인"
        Me.계1.Name = "계1"
        Me.계1.ReadOnly = True
        '
        '계2
        '
        Me.계2.HeaderText = "계약체결일"
        Me.계2.Name = "계2"
        Me.계2.ReadOnly = True
        '
        '계3
        '
        Me.계3.HeaderText = "계약 형태"
        Me.계3.Name = "계3"
        Me.계3.ReadOnly = True
        '
        '계4
        '
        Me.계4.HeaderText = "청구 방법"
        Me.계4.Name = "계4"
        Me.계4.ReadOnly = True
        '
        '계5
        '
        Me.계5.HeaderText = "제1 관여인"
        Me.계5.Name = "계5"
        Me.계5.ReadOnly = True
        '
        '계6
        '
        Me.계6.HeaderText = "제1 관여인 비율"
        Me.계6.Name = "계6"
        Me.계6.ReadOnly = True
        '
        '계7
        '
        Me.계7.HeaderText = "제2 관여인"
        Me.계7.Name = "계7"
        Me.계7.ReadOnly = True
        '
        '계8
        '
        Me.계8.HeaderText = "제2 관여인 비율"
        Me.계8.Name = "계8"
        Me.계8.ReadOnly = True
        '
        '계9
        '
        Me.계9.HeaderText = "제3 관여인"
        Me.계9.Name = "계9"
        Me.계9.ReadOnly = True
        '
        '계10
        '
        Me.계10.HeaderText = "제3 관여인 비율"
        Me.계10.Name = "계10"
        Me.계10.ReadOnly = True
        '
        '계11
        '
        Me.계11.HeaderText = "제4 관여인"
        Me.계11.Name = "계11"
        Me.계11.ReadOnly = True
        '
        '계12
        '
        Me.계12.HeaderText = "제4 관여인 비율"
        Me.계12.Name = "계12"
        Me.계12.ReadOnly = True
        '
        '계13
        '
        Me.계13.HeaderText = "제5 관여인"
        Me.계13.Name = "계13"
        Me.계13.ReadOnly = True
        '
        '계14
        '
        Me.계14.HeaderText = "제5 관여인 비율"
        Me.계14.Name = "계14"
        Me.계14.ReadOnly = True
        '
        '계15
        '
        Me.계15.HeaderText = "최초계약일"
        Me.계15.Name = "계15"
        Me.계15.ReadOnly = True
        '
        '계16
        '
        Me.계16.HeaderText = "Ref No"
        Me.계16.Name = "계16"
        Me.계16.ReadOnly = True
        '
        '입1
        '
        Me.입1.Location = New System.Drawing.Point(45, 457)
        Me.입1.Name = "입1"
        Me.입1.TabIndex = 2
        '
        '입2
        '
        Me.입2.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.입2.Location = New System.Drawing.Point(295, 474)
        Me.입2.Name = "입2"
        Me.입2.Size = New System.Drawing.Size(195, 29)
        Me.입2.TabIndex = 3
        Me.입2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '업5비
        '
        Me.업5비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.업5비.Location = New System.Drawing.Point(1199, 588)
        Me.업5비.Name = "업5비"
        Me.업5비.Size = New System.Drawing.Size(51, 29)
        Me.업5비.TabIndex = 28
        Me.업5비.Text = "0"
        Me.업5비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '업5
        '
        Me.업5.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.업5.FormattingEnabled = True
        Me.업5.Location = New System.Drawing.Point(945, 588)
        Me.업5.Name = "업5"
        Me.업5.Size = New System.Drawing.Size(233, 36)
        Me.업5.TabIndex = 27
        Me.업5.Text = "제5 업무수행인"
        '
        '업4비
        '
        Me.업4비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.업4비.Location = New System.Drawing.Point(1199, 524)
        Me.업4비.Name = "업4비"
        Me.업4비.Size = New System.Drawing.Size(51, 29)
        Me.업4비.TabIndex = 26
        Me.업4비.Text = "0"
        Me.업4비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '업4
        '
        Me.업4.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.업4.FormattingEnabled = True
        Me.업4.Location = New System.Drawing.Point(945, 524)
        Me.업4.Name = "업4"
        Me.업4.Size = New System.Drawing.Size(233, 36)
        Me.업4.TabIndex = 25
        Me.업4.Text = "제4 업무수행인"
        '
        '업3비
        '
        Me.업3비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.업3비.Location = New System.Drawing.Point(1199, 462)
        Me.업3비.Name = "업3비"
        Me.업3비.Size = New System.Drawing.Size(51, 29)
        Me.업3비.TabIndex = 24
        Me.업3비.Text = "0"
        Me.업3비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '업3
        '
        Me.업3.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.업3.FormattingEnabled = True
        Me.업3.Location = New System.Drawing.Point(945, 461)
        Me.업3.Name = "업3"
        Me.업3.Size = New System.Drawing.Size(233, 36)
        Me.업3.TabIndex = 23
        Me.업3.Text = "제3 업무수행인"
        '
        '업2비
        '
        Me.업2비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.업2비.Location = New System.Drawing.Point(824, 589)
        Me.업2비.Name = "업2비"
        Me.업2비.Size = New System.Drawing.Size(51, 29)
        Me.업2비.TabIndex = 22
        Me.업2비.Text = "0"
        Me.업2비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '업2
        '
        Me.업2.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.업2.FormattingEnabled = True
        Me.업2.Location = New System.Drawing.Point(567, 589)
        Me.업2.Name = "업2"
        Me.업2.Size = New System.Drawing.Size(233, 36)
        Me.업2.TabIndex = 21
        Me.업2.Text = "제2 업무수행인"
        '
        '업1비
        '
        Me.업1비.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.업1비.Location = New System.Drawing.Point(824, 514)
        Me.업1비.Name = "업1비"
        Me.업1비.Size = New System.Drawing.Size(51, 29)
        Me.업1비.TabIndex = 20
        Me.업1비.Text = "100"
        Me.업1비.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '업1
        '
        Me.업1.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.업1.FormattingEnabled = True
        Me.업1.Location = New System.Drawing.Point(567, 514)
        Me.업1.Name = "업1"
        Me.업1.Size = New System.Drawing.Size(233, 36)
        Me.업1.TabIndex = 19
        Me.업1.Text = "제1 업무수행인"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(1329, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 154)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "입금 / 배분 등록하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'invo
        '
        Me.invo.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.invo.Location = New System.Drawing.Point(295, 596)
        Me.invo.Name = "invo"
        Me.invo.Size = New System.Drawing.Size(224, 29)
        Me.invo.TabIndex = 30
        Me.invo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(606, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 54)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "입금 / 배분 추가하기"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(31, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 28)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "추가할 입금 / 배분과 관련된 계약 선택"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(41, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 28)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "입금 날짜 선택"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 13.0!)
        Me.Label4.Location = New System.Drawing.Point(291, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "입금액 입력 (단위 : 원)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 13.0!)
        Me.Label5.Location = New System.Drawing.Point(291, 571)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Invoice Number (필요시)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(562, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 28)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "업무 수행인 및 비율 입력"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(881, 514)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 28)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(881, 591)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 28)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(1256, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 28)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(1256, 525)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 28)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(1256, 588)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 28)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label12.Location = New System.Drawing.Point(496, 475)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 28)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "원"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(496, 538)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 28)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "원"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("맑은 고딕", 13.0!)
        Me.Label14.Location = New System.Drawing.Point(291, 512)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 25)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "비용 입력 (단위 : 원)"
        '
        '비용텍스트박스
        '
        Me.비용텍스트박스.Font = New System.Drawing.Font("휴먼편지체", 14.0!)
        Me.비용텍스트박스.Location = New System.Drawing.Point(295, 537)
        Me.비용텍스트박스.Name = "비용텍스트박스"
        Me.비용텍스트박스.Size = New System.Drawing.Size(195, 29)
        Me.비용텍스트박스.TabIndex = 43
        Me.비용텍스트박스.Text = "0"
        Me.비용텍스트박스.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.hannamlaw.My.Resources.Resources.hannam_CI
        Me.PictureBox1.Location = New System.Drawing.Point(1494, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        '입금배분추가
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1680, 637)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.비용텍스트박스)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.invo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.업5비)
        Me.Controls.Add(Me.업5)
        Me.Controls.Add(Me.업4비)
        Me.Controls.Add(Me.업4)
        Me.Controls.Add(Me.업3비)
        Me.Controls.Add(Me.업3)
        Me.Controls.Add(Me.업2비)
        Me.Controls.Add(Me.업2)
        Me.Controls.Add(Me.업1비)
        Me.Controls.Add(Me.업1)
        Me.Controls.Add(Me.입2)
        Me.Controls.Add(Me.입1)
        Me.Controls.Add(Me.계약목록뷰)
        Me.Name = "입금배분추가"
        Me.Text = "입금배분"
        CType(Me.계약목록뷰, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 계약목록뷰 As System.Windows.Forms.DataGridView
    Friend WithEvents 계1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 계16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 입1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents 입2 As System.Windows.Forms.TextBox
    Friend WithEvents 업5비 As System.Windows.Forms.TextBox
    Friend WithEvents 업5 As System.Windows.Forms.ComboBox
    Friend WithEvents 업4비 As System.Windows.Forms.TextBox
    Friend WithEvents 업4 As System.Windows.Forms.ComboBox
    Friend WithEvents 업3비 As System.Windows.Forms.TextBox
    Friend WithEvents 업3 As System.Windows.Forms.ComboBox
    Friend WithEvents 업2비 As System.Windows.Forms.TextBox
    Friend WithEvents 업2 As System.Windows.Forms.ComboBox
    Friend WithEvents 업1비 As System.Windows.Forms.TextBox
    Friend WithEvents 업1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents invo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents 비용텍스트박스 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
