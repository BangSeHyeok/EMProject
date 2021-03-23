<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Main = New System.Windows.Forms.Label()
        Me.lbl_Calendar = New System.Windows.Forms.Label()
        Me.lbl_Information = New System.Windows.Forms.Label()
        Me.lbl_Notice = New System.Windows.Forms.Label()
        Me.lbl_Close = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EMProject.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(27, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_Main
        '
        Me.lbl_Main.AutoSize = True
        Me.lbl_Main.Location = New System.Drawing.Point(366, 107)
        Me.lbl_Main.Name = "lbl_Main"
        Me.lbl_Main.Size = New System.Drawing.Size(34, 15)
        Me.lbl_Main.TabIndex = 1
        Me.lbl_Main.Text = "Main"
        '
        'lbl_Calendar
        '
        Me.lbl_Calendar.AutoSize = True
        Me.lbl_Calendar.Location = New System.Drawing.Point(524, 107)
        Me.lbl_Calendar.Name = "lbl_Calendar"
        Me.lbl_Calendar.Size = New System.Drawing.Size(54, 15)
        Me.lbl_Calendar.TabIndex = 1
        Me.lbl_Calendar.Text = "Calendar"
        '
        'lbl_Information
        '
        Me.lbl_Information.AutoSize = True
        Me.lbl_Information.Location = New System.Drawing.Point(653, 107)
        Me.lbl_Information.Name = "lbl_Information"
        Me.lbl_Information.Size = New System.Drawing.Size(70, 15)
        Me.lbl_Information.TabIndex = 1
        Me.lbl_Information.Text = "Information"
        '
        'lbl_Notice
        '
        Me.lbl_Notice.AutoSize = True
        Me.lbl_Notice.Location = New System.Drawing.Point(827, 107)
        Me.lbl_Notice.Name = "lbl_Notice"
        Me.lbl_Notice.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Notice.TabIndex = 1
        Me.lbl_Notice.Text = "Notice"
        '
        'lbl_Close
        '
        Me.lbl_Close.AutoSize = True
        Me.lbl_Close.Location = New System.Drawing.Point(980, 107)
        Me.lbl_Close.Name = "lbl_Close"
        Me.lbl_Close.Size = New System.Drawing.Size(36, 15)
        Me.lbl_Close.TabIndex = 1
        Me.lbl_Close.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 626)
        Me.Panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_Close)
        Me.Controls.Add(Me.lbl_Notice)
        Me.Controls.Add(Me.lbl_Information)
        Me.Controls.Add(Me.lbl_Calendar)
        Me.Controls.Add(Me.lbl_Main)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Main As Label
    Friend WithEvents lbl_Calendar As Label
    Friend WithEvents lbl_Information As Label
    Friend WithEvents lbl_Notice As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents Panel1 As Panel
End Class
