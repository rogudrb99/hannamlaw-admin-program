<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 계약목록
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
        Me.게게 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.계약목록뷰.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.계1, Me.게게, Me.계2, Me.계3, Me.계4, Me.계5, Me.계6, Me.계7, Me.계8, Me.계9, Me.계10, Me.계11, Me.계12, Me.계13, Me.계14, Me.계15, Me.계16})
        Me.계약목록뷰.Location = New System.Drawing.Point(12, 127)
        Me.계약목록뷰.Name = "계약목록뷰"
        Me.계약목록뷰.ReadOnly = True
        Me.계약목록뷰.RowTemplate.Height = 23
        Me.계약목록뷰.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.계약목록뷰.Size = New System.Drawing.Size(1500, 407)
        Me.계약목록뷰.TabIndex = 0
        '
        '계1
        '
        Me.계1.HeaderText = "의뢰인"
        Me.계1.Name = "계1"
        Me.계1.ReadOnly = True
        '
        '게게
        '
        Me.게게.HeaderText = "비고"
        Me.게게.Name = "게게"
        Me.게게.ReadOnly = True
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
        Me.계6.Width = 50
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
        Me.계8.Width = 50
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
        Me.계10.Width = 50
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
        Me.계12.Width = 50
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
        Me.계14.Width = 50
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(337, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 84)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "계약 추가하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 18.0!)
        Me.Button2.Location = New System.Drawing.Point(917, 578)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(274, 84)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "계약 삭제하기"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 35.0!)
        Me.Label1.Location = New System.Drawing.Point(601, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "계약 DB 목록"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.hannamlaw.My.Resources.Resources.hannam_CI
        Me.PictureBox1.Location = New System.Drawing.Point(1350, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        '계약목록
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1524, 689)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.계약목록뷰)
        Me.Name = "계약목록"
        Me.Text = "계약목록"
        CType(Me.계약목록뷰, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 계약목록뷰 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 계1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 게게 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
