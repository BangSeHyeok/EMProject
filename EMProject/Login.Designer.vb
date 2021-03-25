<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Number = New System.Windows.Forms.TextBox()
        Me.txt_PW = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "サインイン"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "パスワード"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(117, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ログイン"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Number
        '
        Me.txt_Number.Location = New System.Drawing.Point(155, 184)
        Me.txt_Number.Name = "txt_Number"
        Me.txt_Number.Size = New System.Drawing.Size(162, 23)
        Me.txt_Number.TabIndex = 2
        '
        'txt_PW
        '
        Me.txt_PW.Location = New System.Drawing.Point(155, 259)
        Me.txt_PW.Name = "txt_PW"
        Me.txt_PW.Size = New System.Drawing.Size(162, 23)
        Me.txt_PW.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EMProject.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(67, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 433)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_PW)
        Me.Controls.Add(Me.txt_Number)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_Number As TextBox
    Friend WithEvents txt_PW As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
