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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(58, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(58, 46)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(58, 95)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 23)
        Button1.TabIndex = 2
        Button1.Text = "計算"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(327, 9)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(327, 38)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(200, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(327, 67)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 23)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(327, 96)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(200, 23)
        TextBox6.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(292, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 15)
        Label1.TabIndex = 7
        Label1.Text = "和"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(292, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 15)
        Label2.TabIndex = 8
        Label2.Text = "差"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(292, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 15)
        Label3.TabIndex = 9
        Label3.Text = "積"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(292, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 15)
        Label4.TabIndex = 10
        Label4.Text = "商"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(327, 125)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(200, 23)
        TextBox7.TabIndex = 11
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(327, 154)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(200, 23)
        TextBox8.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(290, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 13
        Label5.Text = "点数"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(290, 157)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 14
        Label6.Text = "判定"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "計算アプリ"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
