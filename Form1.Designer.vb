<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Username = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.d3c4258d_c11d_4104_9e1a_c33357ac6627
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(451, 464)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._300b7530_1555_41b3_b69e_a8cbbbef9dd0
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(542, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 85)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(542, 172)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(220, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(542, 225)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(220, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = SystemColors.ControlLightLight
        Username.Location = New Point(542, 148)
        Username.Name = "Username"
        Username.Size = New Size(78, 21)
        Username.TabIndex = 4
        Username.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(542, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 21)
        Label1.TabIndex = 5
        Label1.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaption
        Button1.Image = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector
        Button1.Location = New Point(601, 270)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 35)
        Button1.TabIndex = 6
        Button1.Text = "Log-In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(565, 421)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 21)
        Label2.TabIndex = 7
        Label2.Text = "Secured by NomVet Clinic"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        ClientSize = New Size(858, 464)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Username)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "LOGIN FORM"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label

End Class
