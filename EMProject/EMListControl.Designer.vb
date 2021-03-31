<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMListControl
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
        Me.lbl_Controlgtn = New System.Windows.Forms.Label()
        Me.lbl_Controlgtw = New System.Windows.Forms.Label()
        Me.lbl_ControlPosition = New System.Windows.Forms.Label()
        Me.lbl_ControlName = New System.Windows.Forms.Label()
        Me.lbl_ControlNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Controlgtn
        '
        Me.lbl_Controlgtn.AutoSize = True
        Me.lbl_Controlgtn.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Controlgtn.Location = New System.Drawing.Point(1019, 2)
        Me.lbl_Controlgtn.Name = "lbl_Controlgtn"
        Me.lbl_Controlgtn.Size = New System.Drawing.Size(84, 25)
        Me.lbl_Controlgtn.TabIndex = 9
        Me.lbl_Controlgtn.Text = "退勤時間"
        '
        'lbl_Controlgtw
        '
        Me.lbl_Controlgtw.AutoSize = True
        Me.lbl_Controlgtw.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Controlgtw.Location = New System.Drawing.Point(711, 2)
        Me.lbl_Controlgtw.Name = "lbl_Controlgtw"
        Me.lbl_Controlgtw.Size = New System.Drawing.Size(84, 25)
        Me.lbl_Controlgtw.TabIndex = 8
        Me.lbl_Controlgtw.Text = "出勤時間"
        '
        'lbl_ControlPosition
        '
        Me.lbl_ControlPosition.AutoSize = True
        Me.lbl_ControlPosition.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ControlPosition.Location = New System.Drawing.Point(438, 2)
        Me.lbl_ControlPosition.Name = "lbl_ControlPosition"
        Me.lbl_ControlPosition.Size = New System.Drawing.Size(48, 25)
        Me.lbl_ControlPosition.TabIndex = 7
        Me.lbl_ControlPosition.Text = "職給"
        '
        'lbl_ControlName
        '
        Me.lbl_ControlName.AutoSize = True
        Me.lbl_ControlName.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ControlName.Location = New System.Drawing.Point(250, 2)
        Me.lbl_ControlName.Name = "lbl_ControlName"
        Me.lbl_ControlName.Size = New System.Drawing.Size(66, 25)
        Me.lbl_ControlName.TabIndex = 6
        Me.lbl_ControlName.Text = "社員名"
        '
        'lbl_ControlNumber
        '
        Me.lbl_ControlNumber.AutoSize = True
        Me.lbl_ControlNumber.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ControlNumber.Location = New System.Drawing.Point(51, 2)
        Me.lbl_ControlNumber.Name = "lbl_ControlNumber"
        Me.lbl_ControlNumber.Size = New System.Drawing.Size(85, 25)
        Me.lbl_ControlNumber.TabIndex = 5
        Me.lbl_ControlNumber.Text = "社員番号"
        '
        'EMListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_Controlgtn)
        Me.Controls.Add(Me.lbl_Controlgtw)
        Me.Controls.Add(Me.lbl_ControlPosition)
        Me.Controls.Add(Me.lbl_ControlName)
        Me.Controls.Add(Me.lbl_ControlNumber)
        Me.Name = "EMListControl"
        Me.Size = New System.Drawing.Size(1287, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Controlgtn As Label
    Friend WithEvents lbl_Controlgtw As Label
    Friend WithEvents lbl_ControlPosition As Label
    Friend WithEvents lbl_ControlName As Label
    Friend WithEvents lbl_ControlNumber As Label
End Class
