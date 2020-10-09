<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy = New System.Windows.Forms.Timer(Me.components)
        Me.picShip = New System.Windows.Forms.PictureBox()
        Me.tmrTrigger = New System.Windows.Forms.Timer(Me.components)
        Me.picSprite1 = New System.Windows.Forms.PictureBox()
        Me.picSprite2 = New System.Windows.Forms.PictureBox()
        Me.picSprite3 = New System.Windows.Forms.PictureBox()
        Me.picSprite4 = New System.Windows.Forms.PictureBox()
        Me.picSprite0 = New System.Windows.Forms.PictureBox()
        Me.picSprite5 = New System.Windows.Forms.PictureBox()
        Me.picSprite6 = New System.Windows.Forms.PictureBox()
        Me.picSprite7 = New System.Windows.Forms.PictureBox()
        Me.picSprite8 = New System.Windows.Forms.PictureBox()
        Me.picSprite9 = New System.Windows.Forms.PictureBox()
        Me.picSprite10 = New System.Windows.Forms.PictureBox()
        Me.picSprite11 = New System.Windows.Forms.PictureBox()
        Me.picSprite12 = New System.Windows.Forms.PictureBox()
        Me.picSprite13 = New System.Windows.Forms.PictureBox()
        Me.picSprite14 = New System.Windows.Forms.PictureBox()
        Me.picSprite15 = New System.Windows.Forms.PictureBox()
        Me.picSprite17 = New System.Windows.Forms.PictureBox()
        Me.picSprite18 = New System.Windows.Forms.PictureBox()
        Me.picSprite19 = New System.Windows.Forms.PictureBox()
        Me.picSprite20 = New System.Windows.Forms.PictureBox()
        Me.picSprite21 = New System.Windows.Forms.PictureBox()
        Me.picSprite22 = New System.Windows.Forms.PictureBox()
        Me.picSprite16 = New System.Windows.Forms.PictureBox()
        Me.picSprite23 = New System.Windows.Forms.PictureBox()
        Me.picSprite24 = New System.Windows.Forms.PictureBox()
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.lblAmmo = New System.Windows.Forms.Label()
        Me.tmrSpawner = New System.Windows.Forms.Timer(Me.components)
        Me.lblReloading = New System.Windows.Forms.Label()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 500
        '
        'tmrMovement
        '
        '
        'tmrEnemy
        '
        '
        'picShip
        '
        Me.picShip.Image = CType(resources.GetObject("picShip.Image"), System.Drawing.Image)
        Me.picShip.Location = New System.Drawing.Point(12, 12)
        Me.picShip.Name = "picShip"
        Me.picShip.Size = New System.Drawing.Size(95, 160)
        Me.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip.TabIndex = 0
        Me.picShip.TabStop = False
        '
        'tmrTrigger
        '
        '
        'picSprite1
        '
        Me.picSprite1.Image = CType(resources.GetObject("picSprite1.Image"), System.Drawing.Image)
        Me.picSprite1.Location = New System.Drawing.Point(842, 46)
        Me.picSprite1.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite1.Name = "picSprite1"
        Me.picSprite1.Size = New System.Drawing.Size(5, 5)
        Me.picSprite1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite1.TabIndex = 1
        Me.picSprite1.TabStop = False
        Me.picSprite1.Visible = False
        '
        'picSprite2
        '
        Me.picSprite2.Image = CType(resources.GetObject("picSprite2.Image"), System.Drawing.Image)
        Me.picSprite2.Location = New System.Drawing.Point(439, 428)
        Me.picSprite2.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite2.Name = "picSprite2"
        Me.picSprite2.Size = New System.Drawing.Size(5, 5)
        Me.picSprite2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite2.TabIndex = 2
        Me.picSprite2.TabStop = False
        Me.picSprite2.Visible = False
        '
        'picSprite3
        '
        Me.picSprite3.Image = CType(resources.GetObject("picSprite3.Image"), System.Drawing.Image)
        Me.picSprite3.Location = New System.Drawing.Point(443, 432)
        Me.picSprite3.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite3.Name = "picSprite3"
        Me.picSprite3.Size = New System.Drawing.Size(5, 5)
        Me.picSprite3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite3.TabIndex = 3
        Me.picSprite3.TabStop = False
        Me.picSprite3.Visible = False
        '
        'picSprite4
        '
        Me.picSprite4.Image = CType(resources.GetObject("picSprite4.Image"), System.Drawing.Image)
        Me.picSprite4.Location = New System.Drawing.Point(448, 437)
        Me.picSprite4.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite4.Name = "picSprite4"
        Me.picSprite4.Size = New System.Drawing.Size(5, 5)
        Me.picSprite4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite4.TabIndex = 4
        Me.picSprite4.TabStop = False
        Me.picSprite4.Visible = False
        '
        'picSprite0
        '
        Me.picSprite0.Image = CType(resources.GetObject("picSprite0.Image"), System.Drawing.Image)
        Me.picSprite0.Location = New System.Drawing.Point(452, 441)
        Me.picSprite0.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite0.Name = "picSprite0"
        Me.picSprite0.Size = New System.Drawing.Size(5, 5)
        Me.picSprite0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite0.TabIndex = 5
        Me.picSprite0.TabStop = False
        Me.picSprite0.Visible = False
        '
        'picSprite5
        '
        Me.picSprite5.Image = CType(resources.GetObject("picSprite5.Image"), System.Drawing.Image)
        Me.picSprite5.Location = New System.Drawing.Point(457, 445)
        Me.picSprite5.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite5.Name = "picSprite5"
        Me.picSprite5.Size = New System.Drawing.Size(5, 5)
        Me.picSprite5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite5.TabIndex = 6
        Me.picSprite5.TabStop = False
        Me.picSprite5.Visible = False
        '
        'picSprite6
        '
        Me.picSprite6.Image = CType(resources.GetObject("picSprite6.Image"), System.Drawing.Image)
        Me.picSprite6.Location = New System.Drawing.Point(461, 450)
        Me.picSprite6.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite6.Name = "picSprite6"
        Me.picSprite6.Size = New System.Drawing.Size(5, 5)
        Me.picSprite6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite6.TabIndex = 7
        Me.picSprite6.TabStop = False
        Me.picSprite6.Visible = False
        '
        'picSprite7
        '
        Me.picSprite7.Image = CType(resources.GetObject("picSprite7.Image"), System.Drawing.Image)
        Me.picSprite7.Location = New System.Drawing.Point(465, 454)
        Me.picSprite7.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite7.Name = "picSprite7"
        Me.picSprite7.Size = New System.Drawing.Size(5, 5)
        Me.picSprite7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite7.TabIndex = 8
        Me.picSprite7.TabStop = False
        Me.picSprite7.Visible = False
        '
        'picSprite8
        '
        Me.picSprite8.Image = CType(resources.GetObject("picSprite8.Image"), System.Drawing.Image)
        Me.picSprite8.Location = New System.Drawing.Point(470, 458)
        Me.picSprite8.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite8.Name = "picSprite8"
        Me.picSprite8.Size = New System.Drawing.Size(5, 5)
        Me.picSprite8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite8.TabIndex = 9
        Me.picSprite8.TabStop = False
        Me.picSprite8.Visible = False
        '
        'picSprite9
        '
        Me.picSprite9.Image = CType(resources.GetObject("picSprite9.Image"), System.Drawing.Image)
        Me.picSprite9.Location = New System.Drawing.Point(474, 463)
        Me.picSprite9.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite9.Name = "picSprite9"
        Me.picSprite9.Size = New System.Drawing.Size(5, 5)
        Me.picSprite9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite9.TabIndex = 10
        Me.picSprite9.TabStop = False
        Me.picSprite9.Visible = False
        '
        'picSprite10
        '
        Me.picSprite10.Image = CType(resources.GetObject("picSprite10.Image"), System.Drawing.Image)
        Me.picSprite10.Location = New System.Drawing.Point(478, 467)
        Me.picSprite10.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite10.Name = "picSprite10"
        Me.picSprite10.Size = New System.Drawing.Size(5, 5)
        Me.picSprite10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite10.TabIndex = 11
        Me.picSprite10.TabStop = False
        Me.picSprite10.Visible = False
        '
        'picSprite11
        '
        Me.picSprite11.Image = CType(resources.GetObject("picSprite11.Image"), System.Drawing.Image)
        Me.picSprite11.Location = New System.Drawing.Point(483, 471)
        Me.picSprite11.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite11.Name = "picSprite11"
        Me.picSprite11.Size = New System.Drawing.Size(5, 5)
        Me.picSprite11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite11.TabIndex = 12
        Me.picSprite11.TabStop = False
        Me.picSprite11.Visible = False
        '
        'picSprite12
        '
        Me.picSprite12.Image = CType(resources.GetObject("picSprite12.Image"), System.Drawing.Image)
        Me.picSprite12.Location = New System.Drawing.Point(487, 476)
        Me.picSprite12.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite12.Name = "picSprite12"
        Me.picSprite12.Size = New System.Drawing.Size(5, 5)
        Me.picSprite12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite12.TabIndex = 13
        Me.picSprite12.TabStop = False
        Me.picSprite12.Visible = False
        '
        'picSprite13
        '
        Me.picSprite13.Image = CType(resources.GetObject("picSprite13.Image"), System.Drawing.Image)
        Me.picSprite13.Location = New System.Drawing.Point(491, 480)
        Me.picSprite13.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite13.Name = "picSprite13"
        Me.picSprite13.Size = New System.Drawing.Size(5, 5)
        Me.picSprite13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite13.TabIndex = 14
        Me.picSprite13.TabStop = False
        Me.picSprite13.Visible = False
        '
        'picSprite14
        '
        Me.picSprite14.Image = CType(resources.GetObject("picSprite14.Image"), System.Drawing.Image)
        Me.picSprite14.Location = New System.Drawing.Point(496, 484)
        Me.picSprite14.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite14.Name = "picSprite14"
        Me.picSprite14.Size = New System.Drawing.Size(5, 5)
        Me.picSprite14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite14.TabIndex = 15
        Me.picSprite14.TabStop = False
        Me.picSprite14.Visible = False
        '
        'picSprite15
        '
        Me.picSprite15.Image = CType(resources.GetObject("picSprite15.Image"), System.Drawing.Image)
        Me.picSprite15.Location = New System.Drawing.Point(500, 489)
        Me.picSprite15.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite15.Name = "picSprite15"
        Me.picSprite15.Size = New System.Drawing.Size(5, 5)
        Me.picSprite15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite15.TabIndex = 16
        Me.picSprite15.TabStop = False
        Me.picSprite15.Visible = False
        '
        'picSprite17
        '
        Me.picSprite17.Image = CType(resources.GetObject("picSprite17.Image"), System.Drawing.Image)
        Me.picSprite17.Location = New System.Drawing.Point(505, 493)
        Me.picSprite17.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite17.Name = "picSprite17"
        Me.picSprite17.Size = New System.Drawing.Size(5, 5)
        Me.picSprite17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite17.TabIndex = 17
        Me.picSprite17.TabStop = False
        Me.picSprite17.Visible = False
        '
        'picSprite18
        '
        Me.picSprite18.Image = CType(resources.GetObject("picSprite18.Image"), System.Drawing.Image)
        Me.picSprite18.Location = New System.Drawing.Point(509, 497)
        Me.picSprite18.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite18.Name = "picSprite18"
        Me.picSprite18.Size = New System.Drawing.Size(5, 5)
        Me.picSprite18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite18.TabIndex = 18
        Me.picSprite18.TabStop = False
        Me.picSprite18.Visible = False
        '
        'picSprite19
        '
        Me.picSprite19.Image = CType(resources.GetObject("picSprite19.Image"), System.Drawing.Image)
        Me.picSprite19.Location = New System.Drawing.Point(513, 502)
        Me.picSprite19.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite19.Name = "picSprite19"
        Me.picSprite19.Size = New System.Drawing.Size(5, 5)
        Me.picSprite19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite19.TabIndex = 19
        Me.picSprite19.TabStop = False
        Me.picSprite19.Visible = False
        '
        'picSprite20
        '
        Me.picSprite20.Image = CType(resources.GetObject("picSprite20.Image"), System.Drawing.Image)
        Me.picSprite20.Location = New System.Drawing.Point(518, 506)
        Me.picSprite20.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite20.Name = "picSprite20"
        Me.picSprite20.Size = New System.Drawing.Size(5, 5)
        Me.picSprite20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite20.TabIndex = 20
        Me.picSprite20.TabStop = False
        Me.picSprite20.Visible = False
        '
        'picSprite21
        '
        Me.picSprite21.Image = CType(resources.GetObject("picSprite21.Image"), System.Drawing.Image)
        Me.picSprite21.Location = New System.Drawing.Point(522, 510)
        Me.picSprite21.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite21.Name = "picSprite21"
        Me.picSprite21.Size = New System.Drawing.Size(5, 5)
        Me.picSprite21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite21.TabIndex = 21
        Me.picSprite21.TabStop = False
        Me.picSprite21.Visible = False
        '
        'picSprite22
        '
        Me.picSprite22.Image = CType(resources.GetObject("picSprite22.Image"), System.Drawing.Image)
        Me.picSprite22.Location = New System.Drawing.Point(526, 515)
        Me.picSprite22.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite22.Name = "picSprite22"
        Me.picSprite22.Size = New System.Drawing.Size(5, 5)
        Me.picSprite22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite22.TabIndex = 22
        Me.picSprite22.TabStop = False
        Me.picSprite22.Visible = False
        '
        'picSprite16
        '
        Me.picSprite16.Image = CType(resources.GetObject("picSprite16.Image"), System.Drawing.Image)
        Me.picSprite16.Location = New System.Drawing.Point(531, 519)
        Me.picSprite16.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite16.Name = "picSprite16"
        Me.picSprite16.Size = New System.Drawing.Size(5, 5)
        Me.picSprite16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite16.TabIndex = 23
        Me.picSprite16.TabStop = False
        Me.picSprite16.Visible = False
        '
        'picSprite23
        '
        Me.picSprite23.Image = CType(resources.GetObject("picSprite23.Image"), System.Drawing.Image)
        Me.picSprite23.Location = New System.Drawing.Point(535, 523)
        Me.picSprite23.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite23.Name = "picSprite23"
        Me.picSprite23.Size = New System.Drawing.Size(5, 5)
        Me.picSprite23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite23.TabIndex = 24
        Me.picSprite23.TabStop = False
        Me.picSprite23.Visible = False
        '
        'picSprite24
        '
        Me.picSprite24.Image = CType(resources.GetObject("picSprite24.Image"), System.Drawing.Image)
        Me.picSprite24.Location = New System.Drawing.Point(539, 528)
        Me.picSprite24.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite24.Name = "picSprite24"
        Me.picSprite24.Size = New System.Drawing.Size(5, 5)
        Me.picSprite24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite24.TabIndex = 25
        Me.picSprite24.TabStop = False
        Me.picSprite24.Visible = False
        '
        'tmrReload
        '
        Me.tmrReload.Interval = 500
        '
        'lblAmmo
        '
        Me.lblAmmo.AutoSize = True
        Me.lblAmmo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmo.ForeColor = System.Drawing.Color.White
        Me.lblAmmo.Location = New System.Drawing.Point(830, 12)
        Me.lblAmmo.Name = "lblAmmo"
        Me.lblAmmo.Size = New System.Drawing.Size(42, 14)
        Me.lblAmmo.TabIndex = 26
        Me.lblAmmo.Text = "25/25"
        '
        'tmrSpawner
        '
        Me.tmrSpawner.Interval = 1000
        '
        'lblReloading
        '
        Me.lblReloading.AutoSize = True
        Me.lblReloading.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloading.ForeColor = System.Drawing.Color.White
        Me.lblReloading.Location = New System.Drawing.Point(781, 37)
        Me.lblReloading.Name = "lblReloading"
        Me.lblReloading.Size = New System.Drawing.Size(91, 14)
        Me.lblReloading.TabIndex = 27
        Me.lblReloading.Text = "Reloading..."
        Me.lblReloading.Visible = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(884, 862)
        Me.Controls.Add(Me.lblReloading)
        Me.Controls.Add(Me.lblAmmo)
        Me.Controls.Add(Me.picSprite24)
        Me.Controls.Add(Me.picSprite23)
        Me.Controls.Add(Me.picSprite16)
        Me.Controls.Add(Me.picSprite22)
        Me.Controls.Add(Me.picSprite21)
        Me.Controls.Add(Me.picSprite20)
        Me.Controls.Add(Me.picSprite19)
        Me.Controls.Add(Me.picSprite18)
        Me.Controls.Add(Me.picSprite17)
        Me.Controls.Add(Me.picSprite15)
        Me.Controls.Add(Me.picSprite14)
        Me.Controls.Add(Me.picSprite13)
        Me.Controls.Add(Me.picSprite12)
        Me.Controls.Add(Me.picSprite11)
        Me.Controls.Add(Me.picSprite10)
        Me.Controls.Add(Me.picSprite9)
        Me.Controls.Add(Me.picSprite8)
        Me.Controls.Add(Me.picSprite7)
        Me.Controls.Add(Me.picSprite6)
        Me.Controls.Add(Me.picSprite5)
        Me.Controls.Add(Me.picSprite0)
        Me.Controls.Add(Me.picSprite4)
        Me.Controls.Add(Me.picSprite3)
        Me.Controls.Add(Me.picSprite2)
        Me.Controls.Add(Me.picSprite1)
        Me.Controls.Add(Me.picShip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGame"
        Me.Text = "Rocket War 2.0"
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrBullet As Timer
    Friend WithEvents tmrMovement As Timer
    Friend WithEvents tmrEnemy As Timer
    Friend WithEvents picShip As PictureBox
    Friend WithEvents tmrTrigger As Timer
    Friend WithEvents picSprite1 As PictureBox
    Friend WithEvents picSprite2 As PictureBox
    Friend WithEvents picSprite3 As PictureBox
    Friend WithEvents picSprite4 As PictureBox
    Friend WithEvents picSprite0 As PictureBox
    Friend WithEvents picSprite5 As PictureBox
    Friend WithEvents picSprite6 As PictureBox
    Friend WithEvents picSprite7 As PictureBox
    Friend WithEvents picSprite8 As PictureBox
    Friend WithEvents picSprite9 As PictureBox
    Friend WithEvents picSprite10 As PictureBox
    Friend WithEvents picSprite11 As PictureBox
    Friend WithEvents picSprite12 As PictureBox
    Friend WithEvents picSprite13 As PictureBox
    Friend WithEvents picSprite14 As PictureBox
    Friend WithEvents picSprite15 As PictureBox
    Friend WithEvents picSprite17 As PictureBox
    Friend WithEvents picSprite18 As PictureBox
    Friend WithEvents picSprite19 As PictureBox
    Friend WithEvents picSprite20 As PictureBox
    Friend WithEvents picSprite21 As PictureBox
    Friend WithEvents picSprite22 As PictureBox
    Friend WithEvents picSprite16 As PictureBox
    Friend WithEvents picSprite23 As PictureBox
    Friend WithEvents picSprite24 As PictureBox
    Friend WithEvents tmrReload As Timer
    Friend WithEvents lblAmmo As Label
    Friend WithEvents tmrSpawner As Timer
    Friend WithEvents lblReloading As Label
End Class
