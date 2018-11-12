<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 변호사
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.변호사뷰 = New System.Windows.Forms.DataGridView()
        Me.변호사1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.변호사9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button32 = New System.Windows.Forms.Button()
        CType(Me.변호사뷰, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '변호사뷰
        '
        Me.변호사뷰.AllowUserToAddRows = False
        Me.변호사뷰.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.변호사뷰.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.변호사뷰.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.변호사뷰.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.변호사1, Me.변호사2, Me.변호사3, Me.변호사4, Me.변호사5, Me.변호사6, Me.변호사7, Me.변호사8, Me.변호사9})
        Me.변호사뷰.Location = New System.Drawing.Point(61, 109)
        Me.변호사뷰.Name = "변호사뷰"
        Me.변호사뷰.RowTemplate.Height = 23
        Me.변호사뷰.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.변호사뷰.Size = New System.Drawing.Size(1083, 345)
        Me.변호사뷰.TabIndex = 0
        '
        '변호사1
        '
        Me.변호사1.HeaderText = "변호사"
        Me.변호사1.Name = "변호사1"
        '
        '변호사2
        '
        Me.변호사2.HeaderText = "직급"
        Me.변호사2.Name = "변호사2"
        Me.변호사2.Width = 120
        '
        '변호사3
        '
        Me.변호사3.HeaderText = "이니셜"
        Me.변호사3.Name = "변호사3"
        Me.변호사3.Width = 80
        '
        '변호사4
        '
        Me.변호사4.HeaderText = "주민번호"
        Me.변호사4.Name = "변호사4"
        Me.변호사4.Width = 120
        '
        '변호사5
        '
        Me.변호사5.HeaderText = "주소"
        Me.변호사5.Name = "변호사5"
        Me.변호사5.Width = 150
        '
        '변호사6
        '
        Me.변호사6.HeaderText = "변호사 등록번호"
        Me.변호사6.Name = "변호사6"
        '
        '변호사7
        '
        Me.변호사7.HeaderText = "연락처"
        Me.변호사7.Name = "변호사7"
        Me.변호사7.Width = 130
        '
        '변호사8
        '
        Me.변호사8.HeaderText = "이메일"
        Me.변호사8.Name = "변호사8"
        Me.변호사8.Width = 140
        '
        '변호사9
        '
        Me.변호사9.HeaderText = "근로계약/구성원가입일"
        Me.변호사9.Name = "변호사9"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(190, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 76)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "변호사 추가하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.Location = New System.Drawing.Point(786, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 76)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "변호사 삭제하기"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(437, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "변호사 DB 목록"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.hannamlaw.My.Resources.Resources.hannam_CI
        Me.PictureBox1.Location = New System.Drawing.Point(1017, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Button32
        '
        Me.Button32.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button32.Location = New System.Drawing.Point(494, 483)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(233, 76)
        Me.Button32.TabIndex = 32
        Me.Button32.Text = "변호사 수정하기"
        Me.Button32.UseVisualStyleBackColor = True
        '
        '변호사
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1191, 589)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.변호사뷰)
        Me.Name = "변호사"
        Me.Text = "변호사"
        CType(Me.변호사뷰, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 변호사뷰 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 변호사1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 변호사9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button32 As System.Windows.Forms.Button
End Class
