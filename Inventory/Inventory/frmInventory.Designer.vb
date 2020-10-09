<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.comCPUManufacturer = New System.Windows.Forms.ComboBox()
        Me.lblCPUManufacturer = New System.Windows.Forms.Label()
        Me.lblCPUGeneration = New System.Windows.Forms.Label()
        Me.comCPUGeneration = New System.Windows.Forms.ComboBox()
        Me.comCPUModel = New System.Windows.Forms.ComboBox()
        Me.lblCPUModel = New System.Windows.Forms.Label()
        Me.comRAM = New System.Windows.Forms.ComboBox()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.gbxMotherboard = New System.Windows.Forms.GroupBox()
        Me.rbnMSIMobo = New System.Windows.Forms.RadioButton()
        Me.rbnASUSMobo = New System.Windows.Forms.RadioButton()
        Me.rbnGigabyteMobo = New System.Windows.Forms.RadioButton()
        Me.gbxVideoCard = New System.Windows.Forms.GroupBox()
        Me.rbnIntegratedVC = New System.Windows.Forms.RadioButton()
        Me.rbnRadeonVC = New System.Windows.Forms.RadioButton()
        Me.rbnGTXVC = New System.Windows.Forms.RadioButton()
        Me.gbxStorageType = New System.Windows.Forms.GroupBox()
        Me.rbnHardDriveST = New System.Windows.Forms.RadioButton()
        Me.rbnNVMeST = New System.Windows.Forms.RadioButton()
        Me.rbnSSDST = New System.Windows.Forms.RadioButton()
        Me.gbxPowerSupply = New System.Windows.Forms.GroupBox()
        Me.rbn800PSU = New System.Windows.Forms.RadioButton()
        Me.rbn600PSU = New System.Windows.Forms.RadioButton()
        Me.rbn400PSU = New System.Windows.Forms.RadioButton()
        Me.gbxOptions = New System.Windows.Forms.GroupBox()
        Me.cbxSpeakers = New System.Windows.Forms.CheckBox()
        Me.cbxHeadphones = New System.Windows.Forms.CheckBox()
        Me.cbxIEMs = New System.Windows.Forms.CheckBox()
        Me.cbx10Gb = New System.Windows.Forms.CheckBox()
        Me.cbxSound = New System.Windows.Forms.CheckBox()
        Me.cbxWireless = New System.Windows.Forms.CheckBox()
        Me.cbxCase = New System.Windows.Forms.CheckBox()
        Me.cbxRGB = New System.Windows.Forms.CheckBox()
        Me.cbxWaterCooling = New System.Windows.Forms.CheckBox()
        Me.cbxMouse = New System.Windows.Forms.CheckBox()
        Me.cbxKeyboard = New System.Windows.Forms.CheckBox()
        Me.cbxMonitor = New System.Windows.Forms.CheckBox()
        Me.lbxDatabase = New System.Windows.Forms.ListBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gbxMotherboard.SuspendLayout()
        Me.gbxVideoCard.SuspendLayout()
        Me.gbxStorageType.SuspendLayout()
        Me.gbxPowerSupply.SuspendLayout()
        Me.gbxOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'comCPUManufacturer
        '
        Me.comCPUManufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comCPUManufacturer.FormattingEnabled = True
        Me.comCPUManufacturer.Items.AddRange(New Object() {"Intel", "AMD"})
        Me.comCPUManufacturer.Location = New System.Drawing.Point(12, 29)
        Me.comCPUManufacturer.Name = "comCPUManufacturer"
        Me.comCPUManufacturer.Size = New System.Drawing.Size(140, 32)
        Me.comCPUManufacturer.TabIndex = 0
        '
        'lblCPUManufacturer
        '
        Me.lblCPUManufacturer.AutoSize = True
        Me.lblCPUManufacturer.Location = New System.Drawing.Point(12, 9)
        Me.lblCPUManufacturer.Name = "lblCPUManufacturer"
        Me.lblCPUManufacturer.Size = New System.Drawing.Size(224, 29)
        Me.lblCPUManufacturer.TabIndex = 1
        Me.lblCPUManufacturer.Text = "CPU Manufacturer"
        '
        'lblCPUGeneration
        '
        Me.lblCPUGeneration.AutoSize = True
        Me.lblCPUGeneration.Location = New System.Drawing.Point(164, 9)
        Me.lblCPUGeneration.Name = "lblCPUGeneration"
        Me.lblCPUGeneration.Size = New System.Drawing.Size(202, 29)
        Me.lblCPUGeneration.TabIndex = 2
        Me.lblCPUGeneration.Text = "CPU Generation"
        '
        'comCPUGeneration
        '
        Me.comCPUGeneration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comCPUGeneration.FormattingEnabled = True
        Me.comCPUGeneration.Location = New System.Drawing.Point(158, 29)
        Me.comCPUGeneration.Name = "comCPUGeneration"
        Me.comCPUGeneration.Size = New System.Drawing.Size(140, 32)
        Me.comCPUGeneration.TabIndex = 3
        '
        'comCPUModel
        '
        Me.comCPUModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comCPUModel.FormattingEnabled = True
        Me.comCPUModel.Location = New System.Drawing.Point(304, 29)
        Me.comCPUModel.Name = "comCPUModel"
        Me.comCPUModel.Size = New System.Drawing.Size(140, 32)
        Me.comCPUModel.TabIndex = 4
        '
        'lblCPUModel
        '
        Me.lblCPUModel.AutoSize = True
        Me.lblCPUModel.Location = New System.Drawing.Point(331, 9)
        Me.lblCPUModel.Name = "lblCPUModel"
        Me.lblCPUModel.Size = New System.Drawing.Size(146, 29)
        Me.lblCPUModel.TabIndex = 5
        Me.lblCPUModel.Text = "CPU Model"
        '
        'comRAM
        '
        Me.comRAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comRAM.FormattingEnabled = True
        Me.comRAM.Items.AddRange(New Object() {"4 GB", "8 GB", "16 GB", "32 GB", "64 GB"})
        Me.comRAM.Location = New System.Drawing.Point(450, 29)
        Me.comRAM.Name = "comRAM"
        Me.comRAM.Size = New System.Drawing.Size(140, 32)
        Me.comRAM.TabIndex = 6
        '
        'lblRAM
        '
        Me.lblRAM.AutoSize = True
        Me.lblRAM.Location = New System.Drawing.Point(500, 9)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(68, 29)
        Me.lblRAM.TabIndex = 7
        Me.lblRAM.Text = "RAM"
        '
        'gbxMotherboard
        '
        Me.gbxMotherboard.Controls.Add(Me.rbnMSIMobo)
        Me.gbxMotherboard.Controls.Add(Me.rbnASUSMobo)
        Me.gbxMotherboard.Controls.Add(Me.rbnGigabyteMobo)
        Me.gbxMotherboard.Location = New System.Drawing.Point(12, 56)
        Me.gbxMotherboard.Name = "gbxMotherboard"
        Me.gbxMotherboard.Size = New System.Drawing.Size(140, 92)
        Me.gbxMotherboard.TabIndex = 8
        Me.gbxMotherboard.TabStop = False
        Me.gbxMotherboard.Text = "Motherboard"
        '
        'rbnMSIMobo
        '
        Me.rbnMSIMobo.AutoSize = True
        Me.rbnMSIMobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnMSIMobo.Location = New System.Drawing.Point(6, 68)
        Me.rbnMSIMobo.Name = "rbnMSIMobo"
        Me.rbnMSIMobo.Size = New System.Drawing.Size(70, 28)
        Me.rbnMSIMobo.TabIndex = 2
        Me.rbnMSIMobo.TabStop = True
        Me.rbnMSIMobo.Text = "MSI"
        Me.rbnMSIMobo.UseVisualStyleBackColor = True
        '
        'rbnASUSMobo
        '
        Me.rbnASUSMobo.AutoSize = True
        Me.rbnASUSMobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnASUSMobo.Location = New System.Drawing.Point(6, 45)
        Me.rbnASUSMobo.Name = "rbnASUSMobo"
        Me.rbnASUSMobo.Size = New System.Drawing.Size(89, 28)
        Me.rbnASUSMobo.TabIndex = 1
        Me.rbnASUSMobo.TabStop = True
        Me.rbnASUSMobo.Text = "ASUS"
        Me.rbnASUSMobo.UseVisualStyleBackColor = True
        '
        'rbnGigabyteMobo
        '
        Me.rbnGigabyteMobo.AutoSize = True
        Me.rbnGigabyteMobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnGigabyteMobo.Location = New System.Drawing.Point(6, 22)
        Me.rbnGigabyteMobo.Name = "rbnGigabyteMobo"
        Me.rbnGigabyteMobo.Size = New System.Drawing.Size(117, 28)
        Me.rbnGigabyteMobo.TabIndex = 0
        Me.rbnGigabyteMobo.TabStop = True
        Me.rbnGigabyteMobo.Text = "Gigabyte"
        Me.rbnGigabyteMobo.UseVisualStyleBackColor = True
        '
        'gbxVideoCard
        '
        Me.gbxVideoCard.Controls.Add(Me.rbnIntegratedVC)
        Me.gbxVideoCard.Controls.Add(Me.rbnRadeonVC)
        Me.gbxVideoCard.Controls.Add(Me.rbnGTXVC)
        Me.gbxVideoCard.Location = New System.Drawing.Point(158, 56)
        Me.gbxVideoCard.Name = "gbxVideoCard"
        Me.gbxVideoCard.Size = New System.Drawing.Size(140, 92)
        Me.gbxVideoCard.TabIndex = 9
        Me.gbxVideoCard.TabStop = False
        Me.gbxVideoCard.Text = "Video Card"
        '
        'rbnIntegratedVC
        '
        Me.rbnIntegratedVC.AutoSize = True
        Me.rbnIntegratedVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnIntegratedVC.Location = New System.Drawing.Point(6, 68)
        Me.rbnIntegratedVC.Name = "rbnIntegratedVC"
        Me.rbnIntegratedVC.Size = New System.Drawing.Size(173, 28)
        Me.rbnIntegratedVC.TabIndex = 3
        Me.rbnIntegratedVC.TabStop = True
        Me.rbnIntegratedVC.Text = "Intel Integrated"
        Me.rbnIntegratedVC.UseVisualStyleBackColor = True
        '
        'rbnRadeonVC
        '
        Me.rbnRadeonVC.AutoSize = True
        Me.rbnRadeonVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnRadeonVC.Location = New System.Drawing.Point(6, 45)
        Me.rbnRadeonVC.Name = "rbnRadeonVC"
        Me.rbnRadeonVC.Size = New System.Drawing.Size(108, 28)
        Me.rbnRadeonVC.TabIndex = 2
        Me.rbnRadeonVC.TabStop = True
        Me.rbnRadeonVC.Text = "Radeon"
        Me.rbnRadeonVC.UseVisualStyleBackColor = True
        '
        'rbnGTXVC
        '
        Me.rbnGTXVC.AutoSize = True
        Me.rbnGTXVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnGTXVC.Location = New System.Drawing.Point(6, 22)
        Me.rbnGTXVC.Name = "rbnGTXVC"
        Me.rbnGTXVC.Size = New System.Drawing.Size(78, 28)
        Me.rbnGTXVC.TabIndex = 1
        Me.rbnGTXVC.TabStop = True
        Me.rbnGTXVC.Text = "GTX"
        Me.rbnGTXVC.UseVisualStyleBackColor = True
        '
        'gbxStorageType
        '
        Me.gbxStorageType.Controls.Add(Me.rbnHardDriveST)
        Me.gbxStorageType.Controls.Add(Me.rbnNVMeST)
        Me.gbxStorageType.Controls.Add(Me.rbnSSDST)
        Me.gbxStorageType.Location = New System.Drawing.Point(304, 56)
        Me.gbxStorageType.Name = "gbxStorageType"
        Me.gbxStorageType.Size = New System.Drawing.Size(140, 92)
        Me.gbxStorageType.TabIndex = 10
        Me.gbxStorageType.TabStop = False
        Me.gbxStorageType.Text = "Storage Type"
        '
        'rbnHardDriveST
        '
        Me.rbnHardDriveST.AutoSize = True
        Me.rbnHardDriveST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnHardDriveST.Location = New System.Drawing.Point(6, 68)
        Me.rbnHardDriveST.Name = "rbnHardDriveST"
        Me.rbnHardDriveST.Size = New System.Drawing.Size(134, 28)
        Me.rbnHardDriveST.TabIndex = 4
        Me.rbnHardDriveST.TabStop = True
        Me.rbnHardDriveST.Text = "Hard Drive"
        Me.rbnHardDriveST.UseVisualStyleBackColor = True
        '
        'rbnNVMeST
        '
        Me.rbnNVMeST.AutoSize = True
        Me.rbnNVMeST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNVMeST.Location = New System.Drawing.Point(6, 45)
        Me.rbnNVMeST.Name = "rbnNVMeST"
        Me.rbnNVMeST.Size = New System.Drawing.Size(93, 28)
        Me.rbnNVMeST.TabIndex = 3
        Me.rbnNVMeST.TabStop = True
        Me.rbnNVMeST.Text = "NVMe"
        Me.rbnNVMeST.UseVisualStyleBackColor = True
        '
        'rbnSSDST
        '
        Me.rbnSSDST.AutoSize = True
        Me.rbnSSDST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSSDST.Location = New System.Drawing.Point(6, 22)
        Me.rbnSSDST.Name = "rbnSSDST"
        Me.rbnSSDST.Size = New System.Drawing.Size(75, 28)
        Me.rbnSSDST.TabIndex = 2
        Me.rbnSSDST.TabStop = True
        Me.rbnSSDST.Text = "SSD"
        Me.rbnSSDST.UseVisualStyleBackColor = True
        '
        'gbxPowerSupply
        '
        Me.gbxPowerSupply.Controls.Add(Me.rbn800PSU)
        Me.gbxPowerSupply.Controls.Add(Me.rbn600PSU)
        Me.gbxPowerSupply.Controls.Add(Me.rbn400PSU)
        Me.gbxPowerSupply.Location = New System.Drawing.Point(450, 56)
        Me.gbxPowerSupply.Name = "gbxPowerSupply"
        Me.gbxPowerSupply.Size = New System.Drawing.Size(140, 92)
        Me.gbxPowerSupply.TabIndex = 11
        Me.gbxPowerSupply.TabStop = False
        Me.gbxPowerSupply.Text = "Power Supply"
        '
        'rbn800PSU
        '
        Me.rbn800PSU.AutoSize = True
        Me.rbn800PSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn800PSU.Location = New System.Drawing.Point(6, 68)
        Me.rbn800PSU.Name = "rbn800PSU"
        Me.rbn800PSU.Size = New System.Drawing.Size(83, 28)
        Me.rbn800PSU.TabIndex = 5
        Me.rbn800PSU.TabStop = True
        Me.rbn800PSU.Text = "800w"
        Me.rbn800PSU.UseVisualStyleBackColor = True
        '
        'rbn600PSU
        '
        Me.rbn600PSU.AutoSize = True
        Me.rbn600PSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn600PSU.Location = New System.Drawing.Point(6, 45)
        Me.rbn600PSU.Name = "rbn600PSU"
        Me.rbn600PSU.Size = New System.Drawing.Size(83, 28)
        Me.rbn600PSU.TabIndex = 4
        Me.rbn600PSU.TabStop = True
        Me.rbn600PSU.Text = "600w"
        Me.rbn600PSU.UseVisualStyleBackColor = True
        '
        'rbn400PSU
        '
        Me.rbn400PSU.AutoSize = True
        Me.rbn400PSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn400PSU.Location = New System.Drawing.Point(6, 22)
        Me.rbn400PSU.Name = "rbn400PSU"
        Me.rbn400PSU.Size = New System.Drawing.Size(83, 28)
        Me.rbn400PSU.TabIndex = 3
        Me.rbn400PSU.TabStop = True
        Me.rbn400PSU.Text = "400w"
        Me.rbn400PSU.UseVisualStyleBackColor = True
        '
        'gbxOptions
        '
        Me.gbxOptions.Controls.Add(Me.cbxSpeakers)
        Me.gbxOptions.Controls.Add(Me.cbxHeadphones)
        Me.gbxOptions.Controls.Add(Me.cbxIEMs)
        Me.gbxOptions.Controls.Add(Me.cbx10Gb)
        Me.gbxOptions.Controls.Add(Me.cbxSound)
        Me.gbxOptions.Controls.Add(Me.cbxWireless)
        Me.gbxOptions.Controls.Add(Me.cbxCase)
        Me.gbxOptions.Controls.Add(Me.cbxRGB)
        Me.gbxOptions.Controls.Add(Me.cbxWaterCooling)
        Me.gbxOptions.Controls.Add(Me.cbxMouse)
        Me.gbxOptions.Controls.Add(Me.cbxKeyboard)
        Me.gbxOptions.Controls.Add(Me.cbxMonitor)
        Me.gbxOptions.Location = New System.Drawing.Point(12, 154)
        Me.gbxOptions.Name = "gbxOptions"
        Me.gbxOptions.Size = New System.Drawing.Size(578, 90)
        Me.gbxOptions.TabIndex = 12
        Me.gbxOptions.TabStop = False
        Me.gbxOptions.Text = "Options"
        '
        'cbxSpeakers
        '
        Me.cbxSpeakers.AutoSize = True
        Me.cbxSpeakers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSpeakers.Location = New System.Drawing.Point(444, 68)
        Me.cbxSpeakers.Name = "cbxSpeakers"
        Me.cbxSpeakers.Size = New System.Drawing.Size(123, 28)
        Me.cbxSpeakers.TabIndex = 11
        Me.cbxSpeakers.Text = "Speakers"
        Me.cbxSpeakers.UseVisualStyleBackColor = True
        '
        'cbxHeadphones
        '
        Me.cbxHeadphones.AutoSize = True
        Me.cbxHeadphones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxHeadphones.Location = New System.Drawing.Point(444, 45)
        Me.cbxHeadphones.Name = "cbxHeadphones"
        Me.cbxHeadphones.Size = New System.Drawing.Size(156, 28)
        Me.cbxHeadphones.TabIndex = 10
        Me.cbxHeadphones.Text = "Headphones"
        Me.cbxHeadphones.UseVisualStyleBackColor = True
        '
        'cbxIEMs
        '
        Me.cbxIEMs.AutoSize = True
        Me.cbxIEMs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIEMs.Location = New System.Drawing.Point(444, 22)
        Me.cbxIEMs.Name = "cbxIEMs"
        Me.cbxIEMs.Size = New System.Drawing.Size(82, 28)
        Me.cbxIEMs.TabIndex = 9
        Me.cbxIEMs.Text = "IEMs"
        Me.cbxIEMs.UseVisualStyleBackColor = True
        '
        'cbx10Gb
        '
        Me.cbx10Gb.AutoSize = True
        Me.cbx10Gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx10Gb.Location = New System.Drawing.Point(298, 45)
        Me.cbx10Gb.Name = "cbx10Gb"
        Me.cbx10Gb.Size = New System.Drawing.Size(233, 28)
        Me.cbx10Gb.TabIndex = 8
        Me.cbx10Gb.Text = "10 Gbs Network Card"
        Me.cbx10Gb.UseVisualStyleBackColor = True
        '
        'cbxSound
        '
        Me.cbxSound.AutoSize = True
        Me.cbxSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSound.Location = New System.Drawing.Point(298, 68)
        Me.cbxSound.Name = "cbxSound"
        Me.cbxSound.Size = New System.Drawing.Size(147, 28)
        Me.cbxSound.TabIndex = 7
        Me.cbxSound.Text = "Sound Card"
        Me.cbxSound.UseVisualStyleBackColor = True
        '
        'cbxWireless
        '
        Me.cbxWireless.AutoSize = True
        Me.cbxWireless.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxWireless.Location = New System.Drawing.Point(298, 22)
        Me.cbxWireless.Name = "cbxWireless"
        Me.cbxWireless.Size = New System.Drawing.Size(166, 28)
        Me.cbxWireless.TabIndex = 6
        Me.cbxWireless.Text = "Wireless Card"
        Me.cbxWireless.UseVisualStyleBackColor = True
        '
        'cbxCase
        '
        Me.cbxCase.AutoSize = True
        Me.cbxCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCase.Location = New System.Drawing.Point(155, 68)
        Me.cbxCase.Name = "cbxCase"
        Me.cbxCase.Size = New System.Drawing.Size(178, 28)
        Me.cbxCase.TabIndex = 5
        Me.cbxCase.Text = "High-End Case"
        Me.cbxCase.UseVisualStyleBackColor = True
        '
        'cbxRGB
        '
        Me.cbxRGB.AutoSize = True
        Me.cbxRGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRGB.Location = New System.Drawing.Point(155, 45)
        Me.cbxRGB.Name = "cbxRGB"
        Me.cbxRGB.Size = New System.Drawing.Size(158, 28)
        Me.cbxRGB.TabIndex = 4
        Me.cbxRGB.Text = "RGB Lighting"
        Me.cbxRGB.UseVisualStyleBackColor = True
        '
        'cbxWaterCooling
        '
        Me.cbxWaterCooling.AutoSize = True
        Me.cbxWaterCooling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxWaterCooling.Location = New System.Drawing.Point(155, 22)
        Me.cbxWaterCooling.Name = "cbxWaterCooling"
        Me.cbxWaterCooling.Size = New System.Drawing.Size(168, 28)
        Me.cbxWaterCooling.TabIndex = 3
        Me.cbxWaterCooling.Text = "Water Cooling"
        Me.cbxWaterCooling.UseVisualStyleBackColor = True
        '
        'cbxMouse
        '
        Me.cbxMouse.AutoSize = True
        Me.cbxMouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMouse.Location = New System.Drawing.Point(6, 68)
        Me.cbxMouse.Name = "cbxMouse"
        Me.cbxMouse.Size = New System.Drawing.Size(99, 28)
        Me.cbxMouse.TabIndex = 2
        Me.cbxMouse.Text = "Mouse"
        Me.cbxMouse.UseVisualStyleBackColor = True
        '
        'cbxKeyboard
        '
        Me.cbxKeyboard.AutoSize = True
        Me.cbxKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxKeyboard.Location = New System.Drawing.Point(6, 45)
        Me.cbxKeyboard.Name = "cbxKeyboard"
        Me.cbxKeyboard.Size = New System.Drawing.Size(125, 28)
        Me.cbxKeyboard.TabIndex = 1
        Me.cbxKeyboard.Text = "Keyboard"
        Me.cbxKeyboard.UseVisualStyleBackColor = True
        '
        'cbxMonitor
        '
        Me.cbxMonitor.AutoSize = True
        Me.cbxMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMonitor.Location = New System.Drawing.Point(6, 22)
        Me.cbxMonitor.Name = "cbxMonitor"
        Me.cbxMonitor.Size = New System.Drawing.Size(106, 28)
        Me.cbxMonitor.TabIndex = 0
        Me.cbxMonitor.Text = "Monitor"
        Me.cbxMonitor.UseVisualStyleBackColor = True
        '
        'lbxDatabase
        '
        Me.lbxDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDatabase.FormattingEnabled = True
        Me.lbxDatabase.ItemHeight = 24
        Me.lbxDatabase.Location = New System.Drawing.Point(596, 29)
        Me.lbxDatabase.Name = "lbxDatabase"
        Me.lbxDatabase.Size = New System.Drawing.Size(140, 196)
        Me.lbxDatabase.TabIndex = 13
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(628, 9)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(123, 29)
        Me.lblDatabase.TabIndex = 14
        Me.lblDatabase.Text = "Database"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(596, 247)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(140, 25)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(596, 278)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 25)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(450, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 25)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAs.Location = New System.Drawing.Point(450, 278)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(140, 25)
        Me.btnSaveAs.TabIndex = 19
        Me.btnSaveAs.Text = "Save As"
        Me.btnSaveAs.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(450, 247)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(140, 25)
        Me.btnOpen.TabIndex = 20
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Title = "Save As"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 343)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSaveAs)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lbxDatabase)
        Me.Controls.Add(Me.gbxOptions)
        Me.Controls.Add(Me.gbxPowerSupply)
        Me.Controls.Add(Me.gbxStorageType)
        Me.Controls.Add(Me.gbxVideoCard)
        Me.Controls.Add(Me.gbxMotherboard)
        Me.Controls.Add(Me.lblRAM)
        Me.Controls.Add(Me.comRAM)
        Me.Controls.Add(Me.lblCPUModel)
        Me.Controls.Add(Me.comCPUModel)
        Me.Controls.Add(Me.comCPUGeneration)
        Me.Controls.Add(Me.lblCPUGeneration)
        Me.Controls.Add(Me.lblCPUManufacturer)
        Me.Controls.Add(Me.comCPUManufacturer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInventory"
        Me.Text = "Computer Inventory"
        Me.gbxMotherboard.ResumeLayout(False)
        Me.gbxMotherboard.PerformLayout()
        Me.gbxVideoCard.ResumeLayout(False)
        Me.gbxVideoCard.PerformLayout()
        Me.gbxStorageType.ResumeLayout(False)
        Me.gbxStorageType.PerformLayout()
        Me.gbxPowerSupply.ResumeLayout(False)
        Me.gbxPowerSupply.PerformLayout()
        Me.gbxOptions.ResumeLayout(False)
        Me.gbxOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comCPUManufacturer As ComboBox
    Friend WithEvents lblCPUManufacturer As Label
    Friend WithEvents lblCPUGeneration As Label
    Friend WithEvents comCPUGeneration As ComboBox
    Friend WithEvents comCPUModel As ComboBox
    Friend WithEvents lblCPUModel As Label
    Friend WithEvents comRAM As ComboBox
    Friend WithEvents lblRAM As Label
    Friend WithEvents gbxMotherboard As GroupBox
    Friend WithEvents rbnMSIMobo As RadioButton
    Friend WithEvents rbnASUSMobo As RadioButton
    Friend WithEvents rbnGigabyteMobo As RadioButton
    Friend WithEvents gbxVideoCard As GroupBox
    Friend WithEvents rbnRadeonVC As RadioButton
    Friend WithEvents rbnGTXVC As RadioButton
    Friend WithEvents gbxStorageType As GroupBox
    Friend WithEvents gbxPowerSupply As GroupBox
    Friend WithEvents gbxOptions As GroupBox
    Friend WithEvents rbnIntegratedVC As RadioButton
    Friend WithEvents rbnHardDriveST As RadioButton
    Friend WithEvents rbnNVMeST As RadioButton
    Friend WithEvents rbnSSDST As RadioButton
    Friend WithEvents rbn800PSU As RadioButton
    Friend WithEvents rbn600PSU As RadioButton
    Friend WithEvents rbn400PSU As RadioButton
    Friend WithEvents cbxSpeakers As CheckBox
    Friend WithEvents cbxHeadphones As CheckBox
    Friend WithEvents cbxIEMs As CheckBox
    Friend WithEvents cbx10Gb As CheckBox
    Friend WithEvents cbxSound As CheckBox
    Friend WithEvents cbxWireless As CheckBox
    Friend WithEvents cbxCase As CheckBox
    Friend WithEvents cbxRGB As CheckBox
    Friend WithEvents cbxWaterCooling As CheckBox
    Friend WithEvents cbxMouse As CheckBox
    Friend WithEvents cbxKeyboard As CheckBox
    Friend WithEvents cbxMonitor As CheckBox
    Friend WithEvents lbxDatabase As ListBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSaveAs As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
