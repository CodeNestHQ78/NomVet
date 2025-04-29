<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        pnlBilling = New Panel()
        PnlAppointment = New Panel()
        Panel8 = New Panel()
        PnlPets = New Panel()
        pnlPetOwners = New Panel()
        pnlHome = New Panel()
        Panel3 = New Panel()
        pnlHome1 = New FlowLayoutPanel()
        Label1 = New Label()
        Panel2 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Button9 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        btnPetOwners = New Button()
        btnHome = New Button()
        Panel1 = New Panel()
        pnlOwners = New Panel()
        GroupBox1 = New GroupBox()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Button12 = New Button()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Username = New Label()
        Label6 = New Label()
        Button6 = New Button()
        Button1 = New Button()
        Button5 = New Button()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        PnlAppointment.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        pnlOwners.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlBilling
        ' 
        pnlBilling.BackColor = SystemColors.ControlLightLight
        pnlBilling.Location = New Point(0, 313)
        pnlBilling.Name = "pnlBilling"
        pnlBilling.Size = New Size(10, 39)
        pnlBilling.TabIndex = 41
        ' 
        ' PnlAppointment
        ' 
        PnlAppointment.BackColor = SystemColors.ControlLightLight
        PnlAppointment.Controls.Add(Panel8)
        PnlAppointment.Location = New Point(0, 258)
        PnlAppointment.Name = "PnlAppointment"
        PnlAppointment.Size = New Size(10, 39)
        PnlAppointment.TabIndex = 40
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlLightLight
        Panel8.Location = New Point(0, 28)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(10, 39)
        Panel8.TabIndex = 40
        ' 
        ' PnlPets
        ' 
        PnlPets.BackColor = SystemColors.ControlLightLight
        PnlPets.Location = New Point(0, 203)
        PnlPets.Name = "PnlPets"
        PnlPets.Size = New Size(10, 39)
        PnlPets.TabIndex = 39
        ' 
        ' pnlPetOwners
        ' 
        pnlPetOwners.BackColor = SystemColors.ControlLightLight
        pnlPetOwners.Location = New Point(0, 148)
        pnlPetOwners.Name = "pnlPetOwners"
        pnlPetOwners.Size = New Size(10, 39)
        pnlPetOwners.TabIndex = 38
        ' 
        ' pnlHome
        ' 
        pnlHome.BackColor = SystemColors.ControlLightLight
        pnlHome.Location = New Point(0, 97)
        pnlHome.Name = "pnlHome"
        pnlHome.Size = New Size(10, 39)
        pnlHome.TabIndex = 37
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Panel3.Controls.Add(pnlHome1)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(989, 87)
        Panel3.TabIndex = 10
        ' 
        ' pnlHome1
        ' 
        pnlHome1.BackColor = Color.Transparent
        pnlHome1.Location = New Point(3, 87)
        pnlHome1.Name = "pnlHome1"
        pnlHome1.Size = New Size(994, 460)
        pnlHome1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(406, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 32)
        Label1.TabIndex = 0
        Label1.Text = "PET OWNERS"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = My.Resources.Resources._300b7530_1555_41b3_b69e_a8cbbbef9dd0
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 87)
        Panel2.TabIndex = 1
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.Dock = DockStyle.Bottom
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.ForeColor = SystemColors.ControlLightLight
        Button9.Image = My.Resources.Resources.icons8_log_out_30
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(0, 514)
        Button9.Name = "Button9"
        Button9.Padding = New Padding(12, 0, 0, 0)
        Button9.Size = New Size(200, 55)
        Button9.TabIndex = 36
        Button9.Text = "Log-Out"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.TextImageRelation = TextImageRelation.ImageBeforeText
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(0, 307)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(12, 0, 0, 0)
        Button4.Size = New Size(200, 55)
        Button4.TabIndex = 35
        Button4.Text = " Billing"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Image = My.Resources.Resources.icons8_calendar_24__1_
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(0, 252)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(12, 0, 0, 0)
        Button3.Size = New Size(200, 55)
        Button3.TabIndex = 34
        Button3.Text = " Appointment"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Image = My.Resources.Resources.icons8_paw_24
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 197)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(12, 0, 0, 0)
        Button2.Size = New Size(200, 55)
        Button2.TabIndex = 33
        Button2.Text = " Pets"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnPetOwners
        ' 
        btnPetOwners.BackColor = Color.Transparent
        btnPetOwners.Dock = DockStyle.Top
        btnPetOwners.FlatAppearance.BorderSize = 0
        btnPetOwners.FlatStyle = FlatStyle.Flat
        btnPetOwners.ForeColor = SystemColors.ControlLightLight
        btnPetOwners.Image = My.Resources.Resources.icons8_user_301
        btnPetOwners.ImageAlign = ContentAlignment.MiddleLeft
        btnPetOwners.Location = New Point(0, 142)
        btnPetOwners.Name = "btnPetOwners"
        btnPetOwners.Padding = New Padding(12, 0, 0, 0)
        btnPetOwners.Size = New Size(200, 55)
        btnPetOwners.TabIndex = 32
        btnPetOwners.Text = "Pet Owners"
        btnPetOwners.TextAlign = ContentAlignment.MiddleLeft
        btnPetOwners.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPetOwners.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Transparent
        btnHome.Dock = DockStyle.Top
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = SystemColors.ControlLightLight
        btnHome.Image = My.Resources.Resources.icons8_home_231
        btnHome.ImageAlign = ContentAlignment.MiddleLeft
        btnHome.Location = New Point(0, 87)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(12, 0, 0, 0)
        btnHome.Size = New Size(200, 55)
        btnHome.TabIndex = 31
        btnHome.Text = " Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.BlueViolet
        Panel1.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Panel1.Controls.Add(pnlBilling)
        Panel1.Controls.Add(PnlAppointment)
        Panel1.Controls.Add(PnlPets)
        Panel1.Controls.Add(pnlPetOwners)
        Panel1.Controls.Add(pnlHome)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnPetOwners)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 569)
        Panel1.TabIndex = 9
        ' 
        ' pnlOwners
        ' 
        pnlOwners.BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector1
        pnlOwners.BackgroundImageLayout = ImageLayout.Stretch
        pnlOwners.Controls.Add(GroupBox1)
        pnlOwners.Controls.Add(Button6)
        pnlOwners.Controls.Add(Button1)
        pnlOwners.Controls.Add(Button5)
        pnlOwners.Controls.Add(Label10)
        pnlOwners.Controls.Add(ComboBox1)
        pnlOwners.Controls.Add(TextBox1)
        pnlOwners.Controls.Add(DataGridView1)
        pnlOwners.Location = New Point(200, 87)
        pnlOwners.Name = "pnlOwners"
        pnlOwners.Size = New Size(1002, 481)
        pnlOwners.TabIndex = 9
        pnlOwners.UseWaitCursor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImage = My.Resources.Resources.images5
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Button12)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Username)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(23, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(391, 450)
        GroupBox1.TabIndex = 70
        GroupBox1.TabStop = False
        GroupBox1.UseWaitCursor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(153, 281)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(185, 23)
        TextBox5.TabIndex = 84
        TextBox5.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(31, 314)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 35)
        Label7.TabIndex = 83
        Label7.Text = "Pet Type:"
        Label7.UseWaitCursor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ControlLightLight
        Button12.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Button12.Location = New Point(32, 370)
        Button12.Name = "Button12"
        Button12.Size = New Size(320, 39)
        Button12.TabIndex = 82
        Button12.Text = "Add"
        Button12.UseVisualStyleBackColor = True
        Button12.UseWaitCursor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(153, 326)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(102, 23)
        ComboBox2.TabIndex = 81
        ComboBox2.Text = "Fetile"
        ComboBox2.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(31, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 35)
        Label4.TabIndex = 80
        Label4.Text = "Pet Name:"
        Label4.UseWaitCursor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(153, 235)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(185, 23)
        TextBox3.TabIndex = 79
        TextBox3.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(32, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 35)
        Label3.TabIndex = 78
        Label3.Text = "Address:"
        Label3.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(32, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 35)
        Label2.TabIndex = 77
        Label2.Text = "Sex:"
        Label2.UseWaitCursor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Font = New Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.ForeColor = SystemColors.ControlLightLight
        RadioButton2.Location = New Point(240, 191)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(75, 27)
        RadioButton2.TabIndex = 76
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = False
        RadioButton2.UseWaitCursor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Font = New Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.ForeColor = SystemColors.ControlLightLight
        RadioButton1.Location = New Point(153, 191)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(60, 27)
        RadioButton1.TabIndex = 75
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = False
        RadioButton1.UseWaitCursor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(153, 153)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(59, 23)
        TextBox2.TabIndex = 74
        TextBox2.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(31, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 35)
        Label5.TabIndex = 73
        Label5.Text = "Age:"
        Label5.UseWaitCursor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(153, 117)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(185, 23)
        TextBox4.TabIndex = 72
        TextBox4.UseWaitCursor = True
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Username.ForeColor = SystemColors.ControlLightLight
        Username.Location = New Point(31, 105)
        Username.Name = "Username"
        Username.Size = New Size(84, 35)
        Username.TabIndex = 71
        Username.Text = "Name:"
        Username.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(22, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(221, 47)
        Label6.TabIndex = 70
        Label6.Text = "Owner Details"
        Label6.TextAlign = ContentAlignment.TopCenter
        Label6.UseWaitCursor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ControlLightLight
        Button6.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Button6.Location = New Point(875, 440)
        Button6.Name = "Button6"
        Button6.Size = New Size(99, 30)
        Button6.TabIndex = 53
        Button6.Text = "Delete"
        Button6.UseVisualStyleBackColor = True
        Button6.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Button1.Location = New Point(770, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 30)
        Button1.TabIndex = 52
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Button5.Location = New Point(669, 440)
        Button5.Name = "Button5"
        Button5.Size = New Size(99, 30)
        Button5.TabIndex = 51
        Button5.Text = "Edit"
        Button5.UseVisualStyleBackColor = True
        Button5.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ActiveCaption
        Label10.Location = New Point(431, 30)
        Label10.Name = "Label10"
        Label10.Size = New Size(189, 25)
        Label10.TabIndex = 41
        Label10.Text = "Manage Pet Owners"
        Label10.TextAlign = ContentAlignment.TopCenter
        Label10.UseWaitCursor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(858, 32)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(116, 23)
        ComboBox1.TabIndex = 38
        ComboBox1.Text = "Feline"
        ComboBox1.UseWaitCursor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(626, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(226, 23)
        TextBox1.TabIndex = 37
        TextBox1.Text = "Search..."
        TextBox1.UseWaitCursor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(436, 65)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(538, 368)
        DataGridView1.TabIndex = 35
        DataGridView1.UseWaitCursor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1189, 569)
        Controls.Add(pnlOwners)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Location = New Point(200, 87)
        Name = "Form4"
        Text = "Form4"
        PnlAppointment.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        pnlOwners.ResumeLayout(False)
        pnlOwners.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBilling As Panel
    Friend WithEvents PnlAppointment As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PnlPets As Panel
    Friend WithEvents pnlPetOwners As Panel
    Friend WithEvents pnlHome As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlHome1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPetOwners As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlOwners As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label6 As Label
End Class
