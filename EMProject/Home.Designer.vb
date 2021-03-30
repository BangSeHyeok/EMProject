<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Number = New System.Windows.Forms.Label()
        Me.txt_Number = New System.Windows.Forms.TextBox()
        Me.lbl_Position = New System.Windows.Forms.Label()
        Me.txt_Position = New System.Windows.Forms.TextBox()
        Me.lbl_Aname = New System.Windows.Forms.Label()
        Me.txt_Aname = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_IntroDuction = New System.Windows.Forms.Label()
        Me.txt_IntroDuction = New System.Windows.Forms.RichTextBox()
        Me.btn_gtw = New System.Windows.Forms.Button()
        Me.btn_gth = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pl_Crawling = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Today = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_gtw = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_gth = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EMProject.My.Resources.Resources.imo
        Me.PictureBox1.Location = New System.Drawing.Point(54, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_Number
        '
        Me.lbl_Number.AutoSize = True
        Me.lbl_Number.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Number.Location = New System.Drawing.Point(264, 36)
        Me.lbl_Number.Name = "lbl_Number"
        Me.lbl_Number.Size = New System.Drawing.Size(75, 21)
        Me.lbl_Number.TabIndex = 1
        Me.lbl_Number.Text = "社員番号"
        '
        'txt_Number
        '
        Me.txt_Number.Location = New System.Drawing.Point(373, 36)
        Me.txt_Number.Name = "txt_Number"
        Me.txt_Number.ReadOnly = True
        Me.txt_Number.Size = New System.Drawing.Size(134, 23)
        Me.txt_Number.TabIndex = 2
        '
        'lbl_Position
        '
        Me.lbl_Position.AutoSize = True
        Me.lbl_Position.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Position.Location = New System.Drawing.Point(591, 34)
        Me.lbl_Position.Name = "lbl_Position"
        Me.lbl_Position.Size = New System.Drawing.Size(42, 21)
        Me.lbl_Position.TabIndex = 1
        Me.lbl_Position.Text = "職給"
        '
        'txt_Position
        '
        Me.txt_Position.Location = New System.Drawing.Point(700, 34)
        Me.txt_Position.Name = "txt_Position"
        Me.txt_Position.ReadOnly = True
        Me.txt_Position.Size = New System.Drawing.Size(134, 23)
        Me.txt_Position.TabIndex = 2
        '
        'lbl_Aname
        '
        Me.lbl_Aname.AutoSize = True
        Me.lbl_Aname.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Aname.Location = New System.Drawing.Point(591, 95)
        Me.lbl_Aname.Name = "lbl_Aname"
        Me.lbl_Aname.Size = New System.Drawing.Size(74, 21)
        Me.lbl_Aname.TabIndex = 1
        Me.lbl_Aname.Text = "現場名前"
        '
        'txt_Aname
        '
        Me.txt_Aname.Location = New System.Drawing.Point(700, 95)
        Me.txt_Aname.Name = "txt_Aname"
        Me.txt_Aname.ReadOnly = True
        Me.txt_Aname.Size = New System.Drawing.Size(134, 23)
        Me.txt_Aname.TabIndex = 2
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Name.Location = New System.Drawing.Point(264, 93)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(42, 21)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "名前"
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(373, 93)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.ReadOnly = True
        Me.txt_Name.Size = New System.Drawing.Size(134, 23)
        Me.txt_Name.TabIndex = 2
        '
        'lbl_IntroDuction
        '
        Me.lbl_IntroDuction.AutoSize = True
        Me.lbl_IntroDuction.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_IntroDuction.Location = New System.Drawing.Point(264, 152)
        Me.lbl_IntroDuction.Name = "lbl_IntroDuction"
        Me.lbl_IntroDuction.Size = New System.Drawing.Size(74, 21)
        Me.lbl_IntroDuction.TabIndex = 1
        Me.lbl_IntroDuction.Text = "自己紹介"
        '
        'txt_IntroDuction
        '
        Me.txt_IntroDuction.Location = New System.Drawing.Point(373, 154)
        Me.txt_IntroDuction.Name = "txt_IntroDuction"
        Me.txt_IntroDuction.ReadOnly = True
        Me.txt_IntroDuction.Size = New System.Drawing.Size(858, 96)
        Me.txt_IntroDuction.TabIndex = 3
        Me.txt_IntroDuction.Text = ""
        '
        'btn_gtw
        '
        Me.btn_gtw.Enabled = False
        Me.btn_gtw.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_gtw.Location = New System.Drawing.Point(915, 52)
        Me.btn_gtw.Name = "btn_gtw"
        Me.btn_gtw.Size = New System.Drawing.Size(125, 54)
        Me.btn_gtw.TabIndex = 4
        Me.btn_gtw.Text = "出勤"
        Me.btn_gtw.UseVisualStyleBackColor = True
        '
        'btn_gth
        '
        Me.btn_gth.Enabled = False
        Me.btn_gth.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_gth.Location = New System.Drawing.Point(1081, 52)
        Me.btn_gth.Name = "btn_gth"
        Me.btn_gth.Size = New System.Drawing.Size(125, 54)
        Me.btn_gth.TabIndex = 4
        Me.btn_gth.Text = "退勤"
        Me.btn_gth.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pl_Crawling, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-1, 303)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1293, 324)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'pl_Crawling
        '
        Me.pl_Crawling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pl_Crawling.Location = New System.Drawing.Point(3, 161)
        Me.pl_Crawling.Name = "pl_Crawling"
        Me.pl_Crawling.Size = New System.Drawing.Size(1287, 160)
        Me.pl_Crawling.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "現在の情報"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 346.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Today, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_gtw, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_gth, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1287, 30)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "日付："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Today
        '
        Me.lbl_Today.AutoSize = True
        Me.lbl_Today.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Today.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Today.Location = New System.Drawing.Point(82, 0)
        Me.lbl_Today.Name = "lbl_Today"
        Me.lbl_Today.Size = New System.Drawing.Size(234, 30)
        Me.lbl_Today.TabIndex = 1
        Me.lbl_Today.Text = "Label3"
        Me.lbl_Today.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(322, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "出勤時間："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_gtw
        '
        Me.lbl_gtw.AutoSize = True
        Me.lbl_gtw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_gtw.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_gtw.Location = New System.Drawing.Point(471, 0)
        Me.lbl_gtw.Name = "lbl_gtw"
        Me.lbl_gtw.Size = New System.Drawing.Size(341, 30)
        Me.lbl_gtw.TabIndex = 3
        Me.lbl_gtw.Text = "Label4"
        Me.lbl_gtw.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(818, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "退勤時間："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_gth
        '
        Me.lbl_gth.AutoSize = True
        Me.lbl_gth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_gth.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_gth.Location = New System.Drawing.Point(944, 0)
        Me.lbl_gth.Name = "lbl_gth"
        Me.lbl_gth.Size = New System.Drawing.Size(340, 30)
        Me.lbl_gth.TabIndex = 5
        Me.lbl_gth.Text = "Label5"
        Me.lbl_gth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 627)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btn_gth)
        Me.Controls.Add(Me.btn_gtw)
        Me.Controls.Add(Me.txt_IntroDuction)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_IntroDuction)
        Me.Controls.Add(Me.txt_Aname)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.lbl_Aname)
        Me.Controls.Add(Me.txt_Position)
        Me.Controls.Add(Me.lbl_Position)
        Me.Controls.Add(Me.txt_Number)
        Me.Controls.Add(Me.lbl_Number)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Number As Label
    Friend WithEvents txt_Number As TextBox
    Friend WithEvents lbl_Position As Label
    Friend WithEvents txt_Position As TextBox
    Friend WithEvents lbl_Aname As Label
    Friend WithEvents txt_Aname As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_IntroDuction As Label
    Friend WithEvents txt_IntroDuction As RichTextBox
    Friend WithEvents btn_gtw As Button
    Friend WithEvents btn_gth As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents pl_Crawling As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Today As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_gtw As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_gth As Label
End Class
