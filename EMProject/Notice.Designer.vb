<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notice
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.題目 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.作成者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_Find = New System.Windows.Forms.ComboBox()
        Me.txt_Find = New System.Windows.Forms.TextBox()
        Me.btn_Find = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_Page = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(567, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "新着情報"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.番号, Me.題目, Me.作成者, Me.時間})
        Me.DataGridView1.Location = New System.Drawing.Point(50, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1185, 401)
        Me.DataGridView1.TabIndex = 1
        '
        '番号
        '
        Me.番号.HeaderText = "番号"
        Me.番号.Name = "番号"
        '
        '題目
        '
        Me.題目.HeaderText = "題目"
        Me.題目.Name = "題目"
        Me.題目.Width = 600
        '
        '作成者
        '
        Me.作成者.HeaderText = "作成者"
        Me.作成者.Name = "作成者"
        Me.作成者.Width = 200
        '
        '時間
        '
        Me.時間.HeaderText = "時間"
        Me.時間.Name = "時間"
        Me.時間.Width = 242
        '
        'cb_Find
        '
        Me.cb_Find.FormattingEnabled = True
        Me.cb_Find.Items.AddRange(New Object() {"作成者", "内容", "作成者＋内容"})
        Me.cb_Find.Location = New System.Drawing.Point(406, 564)
        Me.cb_Find.Name = "cb_Find"
        Me.cb_Find.Size = New System.Drawing.Size(121, 23)
        Me.cb_Find.TabIndex = 2
        '
        'txt_Find
        '
        Me.txt_Find.Location = New System.Drawing.Point(533, 564)
        Me.txt_Find.Name = "txt_Find"
        Me.txt_Find.Size = New System.Drawing.Size(226, 23)
        Me.txt_Find.TabIndex = 3
        '
        'btn_Find
        '
        Me.btn_Find.Location = New System.Drawing.Point(765, 563)
        Me.btn_Find.Name = "btn_Find"
        Me.btn_Find.Size = New System.Drawing.Size(75, 23)
        Me.btn_Find.TabIndex = 4
        Me.btn_Find.Text = "検索"
        Me.btn_Find.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "左"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(722, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "右"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_Page
        '
        Me.lbl_Page.AutoSize = True
        Me.lbl_Page.Location = New System.Drawing.Point(616, 495)
        Me.lbl_Page.Name = "lbl_Page"
        Me.lbl_Page.Size = New System.Drawing.Size(33, 15)
        Me.lbl_Page.TabIndex = 6
        Me.lbl_Page.Text = "Page"
        '
        'Notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 627)
        Me.Controls.Add(Me.lbl_Page)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Find)
        Me.Controls.Add(Me.txt_Find)
        Me.Controls.Add(Me.cb_Find)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notice"
        Me.Text = "Notice"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 番号 As DataGridViewTextBoxColumn
    Friend WithEvents 題目 As DataGridViewTextBoxColumn
    Friend WithEvents 作成者 As DataGridViewTextBoxColumn
    Friend WithEvents 時間 As DataGridViewTextBoxColumn
    Friend WithEvents cb_Find As ComboBox
    Friend WithEvents txt_Find As TextBox
    Friend WithEvents btn_Find As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_Page As Label
End Class
