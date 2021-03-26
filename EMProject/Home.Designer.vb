<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-1, 303)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1293, 324)
        Me.TableLayoutPanel1.TabIndex = 5
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
End Class
