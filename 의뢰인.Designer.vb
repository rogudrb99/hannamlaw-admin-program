<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 의뢰인
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.의뢰인뷰 = New System.Windows.Forms.DataGridView()
        Me.의뢰인명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.이지 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.이지2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.주민번호명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.주소명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.사업자번호명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.최초계약일명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.연락처명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.실무담당자명 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.의뢰인뷰, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(390, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "의뢰인 DB 목록"
        '
        '의뢰인뷰
        '
        Me.의뢰인뷰.AllowUserToAddRows = False
        Me.의뢰인뷰.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.의뢰인뷰.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.의뢰인뷰.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.의뢰인뷰.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.의뢰인명, Me.이지, Me.이지2, Me.주민번호명, Me.주소명, Me.사업자번호명, Me.최초계약일명, Me.연락처명, Me.실무담당자명})
        Me.의뢰인뷰.Location = New System.Drawing.Point(33, 135)
        Me.의뢰인뷰.Name = "의뢰인뷰"
        Me.의뢰인뷰.RowTemplate.Height = 23
        Me.의뢰인뷰.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.의뢰인뷰.Size = New System.Drawing.Size(1035, 356)
        Me.의뢰인뷰.TabIndex = 1
        '
        '의뢰인명
        '
        Me.의뢰인명.Frozen = True
        Me.의뢰인명.HeaderText = "의뢰인"
        Me.의뢰인명.Name = "의뢰인명"
        '
        '이지
        '
        Me.이지.Frozen = True
        Me.이지.HeaderText = "이니셜"
        Me.이지.Name = "이지"
        '
        '이지2
        '
        Me.이지2.Frozen = True
        Me.이지2.HeaderText = "이메일"
        Me.이지2.Name = "이지2"
        '
        '주민번호명
        '
        Me.주민번호명.Frozen = True
        Me.주민번호명.HeaderText = "주민번호"
        Me.주민번호명.Name = "주민번호명"
        Me.주민번호명.Width = 120
        '
        '주소명
        '
        Me.주소명.HeaderText = "주소명"
        Me.주소명.Name = "주소명"
        Me.주소명.Width = 170
        '
        '사업자번호명
        '
        Me.사업자번호명.HeaderText = "사업자번호명"
        Me.사업자번호명.Name = "사업자번호명"
        '
        '최초계약일명
        '
        Me.최초계약일명.HeaderText = "최초계약일명"
        Me.최초계약일명.Name = "최초계약일명"
        '
        '연락처명
        '
        Me.연락처명.HeaderText = "연락처명"
        Me.연락처명.Name = "연락처명"
        Me.연락처명.Width = 120
        '
        '실무담당자명
        '
        Me.실무담당자명.HeaderText = "실무담당자명"
        Me.실무담당자명.Name = "실무담당자명"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(182, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 85)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "의뢰인 추가하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.Location = New System.Drawing.Point(733, 528)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 85)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "의뢰인 삭제하기"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button35.Location = New System.Drawing.Point(455, 528)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(204, 85)
        Me.Button35.TabIndex = 32
        Me.Button35.Text = "의뢰인 수정하기"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.hannamlaw.My.Resources.Resources.hannam_CI
        Me.PictureBox1.Location = New System.Drawing.Point(923, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        '의뢰인
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1108, 644)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.의뢰인뷰)
        Me.Controls.Add(Me.Label1)
        Me.Name = "의뢰인"
        Me.Text = "의뢰인"
        CType(Me.의뢰인뷰, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 의뢰인뷰 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents 의뢰인명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 이지 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 이지2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 주민번호명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 주소명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 사업자번호명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 최초계약일명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 연락처명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 실무담당자명 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button35 As System.Windows.Forms.Button
End Class
