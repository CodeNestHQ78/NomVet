<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Panel3 = New Panel()
        pnlHome1 = New FlowLayoutPanel()
        Label1 = New Label()
        Panel1 = New Panel()
        pnlBilling = New Panel()
        PnlAppointment = New Panel()
        Panel8 = New Panel()
        PnlPets = New Panel()
        pnlPetOwners = New Panel()
        pnlHome = New Panel()
        Button9 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        btnPetOwners = New Button()
        btnHome = New Button()
        Panel2 = New Panel()
        pnlOwners = New Panel()
        Label10 = New Label()
        Button13 = New Button()
        Button12 = New Button()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Button11 = New Button()
        DataGridView1 = New DataGridView()
        ComboBox2 = New ComboBox()
        TextBox2 = New TextBox()
        DataGridView2 = New DataGridView()
        GroupBox1 = New GroupBox()
        ComboBox3 = New ComboBox()
        Button5 = New Button()
        Label3 = New Label()
        ComboBox4 = New ComboBox()
        Label2 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox6 = New TextBox()
        Username = New Label()
        Label4 = New Label()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        PnlAppointment.SuspendLayout()
        Panel2.SuspendLayout()
        pnlOwners.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Panel3.Controls.Add(pnlHome1)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(958, 87)
        Panel3.TabIndex = 12
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
        Label1.Location = New Point(435, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 32)
        Label1.TabIndex = 0
        Label1.Text = "BILLING"
        Label1.TextAlign = ContentAlignment.TopCenter
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
        Panel1.Size = New Size(200, 563)
        Panel1.TabIndex = 11
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
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.Dock = DockStyle.Bottom
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.ForeColor = SystemColors.ControlLightLight
        Button9.Image = My.Resources.Resources.icons8_log_out_30
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(0, 508)
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = My.Resources.Resources._300b7530_1555_41b3_b69e_a8cbbbef9dd0
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(pnlOwners)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 87)
        Panel2.TabIndex = 1
        ' 
        ' pnlOwners
        ' 
        pnlOwners.BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector1
        pnlOwners.BackgroundImageLayout = ImageLayout.Stretch
        pnlOwners.Controls.Add(Label10)
        pnlOwners.Controls.Add(Button13)
        pnlOwners.Controls.Add(Button12)
        pnlOwners.Controls.Add(ComboBox1)
        pnlOwners.Controls.Add(TextBox1)
        pnlOwners.Controls.Add(Button11)
        pnlOwners.Controls.Add(DataGridView1)
        pnlOwners.Location = New Point(200, 87)
        pnlOwners.Name = "pnlOwners"
        pnlOwners.Size = New Size(1002, 481)
        pnlOwners.TabIndex = 9
        pnlOwners.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ActiveCaption
        Label10.Location = New Point(24, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(242, 32)
        Label10.TabIndex = 41
        Label10.Text = "Manage Pet Owners"
        Label10.TextAlign = ContentAlignment.TopCenter
        Label10.UseWaitCursor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = SystemColors.ActiveCaption
        Button13.Image = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector
        Button13.Location = New Point(795, 439)
        Button13.Name = "Button13"
        Button13.Size = New Size(99, 30)
        Button13.TabIndex = 40
        Button13.Text = "View"
        Button13.UseVisualStyleBackColor = True
        Button13.UseWaitCursor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ActiveCaption
        Button12.Image = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector
        Button12.Location = New Point(690, 439)
        Button12.Name = "Button12"
        Button12.Size = New Size(99, 30)
        Button12.TabIndex = 39
        Button12.Text = "Edit"
        Button12.UseVisualStyleBackColor = True
        Button12.UseWaitCursor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(266, 69)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 38
        ComboBox1.Text = "Feline"
        ComboBox1.UseWaitCursor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 69)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(236, 23)
        TextBox1.TabIndex = 37
        TextBox1.Text = "Search..."
        TextBox1.UseWaitCursor = True
        ' 
        ' Button11
        ' 
        Button11.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = SystemColors.ActiveCaption
        Button11.Image = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector
        Button11.Location = New Point(406, 66)
        Button11.Name = "Button11"
        Button11.Size = New Size(194, 30)
        Button11.TabIndex = 36
        Button11.Text = "+ Add New Owner"
        Button11.UseVisualStyleBackColor = True
        Button11.UseWaitCursor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 107)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(954, 326)
        DataGridView1.TabIndex = 35
        DataGridView1.UseWaitCursor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(840, 113)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(116, 23)
        ComboBox2.TabIndex = 107
        ComboBox2.Text = "Feline"
        ComboBox2.UseWaitCursor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(608, 113)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(226, 23)
        TextBox2.TabIndex = 106
        TextBox2.Text = "Search..."
        TextBox2.UseWaitCursor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(608, 142)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(538, 368)
        DataGridView2.TabIndex = 105
        DataGridView2.UseWaitCursor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImage = My.Resources.Resources.images6
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(ComboBox4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Username)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(220, 108)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(367, 423)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(126, 258)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(116, 23)
        ComboBox3.TabIndex = 131
        ComboBox3.Text = "500₱"
        ComboBox3.UseWaitCursor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Button5.Location = New Point(26, 316)
        Button5.Name = "Button5"
        Button5.Size = New Size(320, 41)
        Button5.TabIndex = 130
        Button5.Text = "Save"
        Button5.UseVisualStyleBackColor = True
        Button5.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(16, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 35)
        Label3.TabIndex = 129
        Label3.Text = "Bill:"
        Label3.UseWaitCursor = True
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(232, 183)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(79, 23)
        ComboBox4.TabIndex = 128
        ComboBox4.Text = "Fetile"
        ComboBox4.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(16, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 35)
        Label2.TabIndex = 127
        Label2.Text = "Procedure:"
        Label2.UseWaitCursor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Font = New Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.ForeColor = SystemColors.ControlLightLight
        RadioButton2.Location = New Point(254, 221)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(78, 27)
        RadioButton2.TabIndex = 126
        RadioButton2.TabStop = True
        RadioButton2.Text = "Vaccine"
        RadioButton2.UseVisualStyleBackColor = False
        RadioButton2.UseWaitCursor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Font = New Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.ForeColor = SystemColors.ControlLightLight
        RadioButton1.Location = New Point(155, 221)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(93, 27)
        RadioButton1.TabIndex = 125
        RadioButton1.TabStop = True
        RadioButton1.Text = "Check-Up"
        RadioButton1.UseVisualStyleBackColor = False
        RadioButton1.UseWaitCursor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(126, 183)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 124
        TextBox4.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(16, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 35)
        Label5.TabIndex = 123
        Label5.Text = "Pet:"
        Label5.UseWaitCursor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(126, 148)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(185, 23)
        TextBox6.TabIndex = 122
        TextBox6.UseWaitCursor = True
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Username.ForeColor = SystemColors.ControlLightLight
        Username.Location = New Point(16, 143)
        Username.Name = "Username"
        Username.Size = New Size(94, 35)
        Username.TabIndex = 121
        Username.Text = "Owner:"
        Username.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(16, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(263, 47)
        Label4.TabIndex = 120
        Label4.Text = "Payment Records"
        Label4.TextAlign = ContentAlignment.TopCenter
        Label4.UseWaitCursor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1158, 563)
        Controls.Add(GroupBox1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox2)
        Controls.Add(DataGridView2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "Form6"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        PnlAppointment.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        pnlOwners.ResumeLayout(False)
        pnlOwners.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlHome1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlBilling As Panel
    Friend WithEvents PnlAppointment As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PnlPets As Panel
    Friend WithEvents pnlPetOwners As Panel
    Friend WithEvents pnlHome As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPetOwners As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlOwners As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label4 As Label
End Class
