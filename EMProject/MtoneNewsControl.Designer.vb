<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MtoneNewsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.lbl_Control_Index = New System.Windows.Forms.Label()
        Me.lbl_Control_day = New System.Windows.Forms.Label()
        Me.lbl_Control_Title = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lbl_Control_Index
        '
        Me.lbl_Control_Index.AutoSize = True
        Me.lbl_Control_Index.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Control_Index.Location = New System.Drawing.Point(59, 4)
        Me.lbl_Control_Index.Name = "lbl_Control_Index"
        Me.lbl_Control_Index.Size = New System.Drawing.Size(49, 25)
        Me.lbl_Control_Index.TabIndex = 6
        Me.lbl_Control_Index.Text = "番号"
        '
        'lbl_Control_day
        '
        Me.lbl_Control_day.AutoSize = True
        Me.lbl_Control_day.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Control_day.Location = New System.Drawing.Point(300, 4)
        Me.lbl_Control_day.Name = "lbl_Control_day"
        Me.lbl_Control_day.Size = New System.Drawing.Size(48, 25)
        Me.lbl_Control_day.TabIndex = 8
        Me.lbl_Control_day.Text = "日付"
        '
        'lbl_Control_Title
        '
        Me.lbl_Control_Title.AutoSize = True
        Me.lbl_Control_Title.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Control_Title.LinkVisited = True
        Me.lbl_Control_Title.Location = New System.Drawing.Point(605, 4)
        Me.lbl_Control_Title.Name = "lbl_Control_Title"
        Me.lbl_Control_Title.Size = New System.Drawing.Size(84, 25)
        Me.lbl_Control_Title.TabIndex = 9
        Me.lbl_Control_Title.TabStop = True
        Me.lbl_Control_Title.Text = "タイトル"
        '
        'MtoneNewsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_Control_Title)
        Me.Controls.Add(Me.lbl_Control_day)
        Me.Controls.Add(Me.lbl_Control_Index)
        Me.Name = "MtoneNewsControl"
        Me.Size = New System.Drawing.Size(1287, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Control_Index As Label
    Friend WithEvents lbl_Control_day As Label
    Friend WithEvents lbl_Control_Title As LinkLabel
End Class
