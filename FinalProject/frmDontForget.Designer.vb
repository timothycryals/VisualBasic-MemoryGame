<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDontForget
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CosmicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.pnlGameType = New System.Windows.Forms.Panel()
        Me.btnGameTypeBack = New System.Windows.Forms.Button()
        Me.btnSelectGameType = New System.Windows.Forms.Button()
        Me.lblGameTypeInfo = New System.Windows.Forms.Label()
        Me.btnTimed = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.lblSelectGametype = New System.Windows.Forms.Label()
        Me.pnlDifficulty = New System.Windows.Forms.Panel()
        Me.btnSelectDifficultyBack = New System.Windows.Forms.Button()
        Me.btnSelectDifficulty = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnExpert = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.pnlGamePlay = New System.Windows.Forms.Panel()
        Me.lblGamePlayDifficulty = New System.Windows.Forms.Label()
        Me.btnRestartGame = New System.Windows.Forms.Button()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlCards = New System.Windows.Forms.Panel()
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.btnResultsRecords = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.lblResultsTime = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.pnlRecords = New System.Windows.Forms.Panel()
        Me.btnClearRecords = New System.Windows.Forms.Button()
        Me.btnRecordsBack = New System.Windows.Forms.Button()
        Me.lblTimed = New System.Windows.Forms.Label()
        Me.lstTimedScores = New System.Windows.Forms.ListBox()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.lstNormalScores = New System.Windows.Forms.ListBox()
        Me.lblRecordsTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlGameType.SuspendLayout()
        Me.pnlDifficulty.SuspendLayout()
        Me.pnlGamePlay.SuspendLayout()
        Me.pnlResults.SuspendLayout()
        Me.pnlRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ThemesToolStripMenuItem
        '
        Me.ThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CosmicToolStripMenuItem, Me.StandardToolStripMenuItem})
        Me.ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        Me.ThemesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ThemesToolStripMenuItem.Text = "&Themes"
        '
        'CosmicToolStripMenuItem
        '
        Me.CosmicToolStripMenuItem.Name = "CosmicToolStripMenuItem"
        Me.CosmicToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CosmicToolStripMenuItem.Text = "Cosmic"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Unispace", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(269, 163)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(373, 58)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Don't Forget"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.Location = New System.Drawing.Point(345, 238)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(220, 25)
        Me.lblSubtitle.TabIndex = 5
        Me.lblSubtitle.Text = "Memory Card Game"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Gainsboro
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(193, 319)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(183, 54)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.Location = New System.Drawing.Point(534, 319)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(183, 54)
        Me.btnRecords.TabIndex = 7
        Me.btnRecords.Text = "Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.btnRecords)
        Me.pnlTitle.Controls.Add(Me.btnStart)
        Me.pnlTitle.Controls.Add(Me.lblSubtitle)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 27)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(911, 537)
        Me.pnlTitle.TabIndex = 5
        '
        'pnlGameType
        '
        Me.pnlGameType.Controls.Add(Me.btnGameTypeBack)
        Me.pnlGameType.Controls.Add(Me.btnSelectGameType)
        Me.pnlGameType.Controls.Add(Me.lblGameTypeInfo)
        Me.pnlGameType.Controls.Add(Me.btnTimed)
        Me.pnlGameType.Controls.Add(Me.btnNormal)
        Me.pnlGameType.Controls.Add(Me.lblSelectGametype)
        Me.pnlGameType.Location = New System.Drawing.Point(0, 27)
        Me.pnlGameType.Name = "pnlGameType"
        Me.pnlGameType.Size = New System.Drawing.Size(911, 534)
        Me.pnlGameType.TabIndex = 8
        '
        'btnGameTypeBack
        '
        Me.btnGameTypeBack.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGameTypeBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGameTypeBack.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameTypeBack.Location = New System.Drawing.Point(617, 440)
        Me.btnGameTypeBack.Name = "btnGameTypeBack"
        Me.btnGameTypeBack.Size = New System.Drawing.Size(160, 49)
        Me.btnGameTypeBack.TabIndex = 5
        Me.btnGameTypeBack.Text = "Back"
        Me.btnGameTypeBack.UseVisualStyleBackColor = False
        '
        'btnSelectGameType
        '
        Me.btnSelectGameType.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSelectGameType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectGameType.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectGameType.Location = New System.Drawing.Point(134, 440)
        Me.btnSelectGameType.Name = "btnSelectGameType"
        Me.btnSelectGameType.Size = New System.Drawing.Size(160, 49)
        Me.btnSelectGameType.TabIndex = 4
        Me.btnSelectGameType.Text = "Select Game Type"
        Me.btnSelectGameType.UseVisualStyleBackColor = False
        '
        'lblGameTypeInfo
        '
        Me.lblGameTypeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGameTypeInfo.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTypeInfo.Location = New System.Drawing.Point(214, 319)
        Me.lblGameTypeInfo.Name = "lblGameTypeInfo"
        Me.lblGameTypeInfo.Size = New System.Drawing.Size(483, 54)
        Me.lblGameTypeInfo.TabIndex = 3
        Me.lblGameTypeInfo.Text = "Normal: The player will have unlimited time to match all cards"
        Me.lblGameTypeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTimed
        '
        Me.btnTimed.BackColor = System.Drawing.Color.Silver
        Me.btnTimed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimed.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimed.Location = New System.Drawing.Point(530, 163)
        Me.btnTimed.Name = "btnTimed"
        Me.btnTimed.Size = New System.Drawing.Size(167, 127)
        Me.btnTimed.TabIndex = 2
        Me.btnTimed.Text = "Timed"
        Me.btnTimed.UseVisualStyleBackColor = False
        '
        'btnNormal
        '
        Me.btnNormal.BackColor = System.Drawing.Color.Silver
        Me.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNormal.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNormal.Location = New System.Drawing.Point(214, 163)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(167, 127)
        Me.btnNormal.TabIndex = 1
        Me.btnNormal.Text = "Normal"
        Me.btnNormal.UseVisualStyleBackColor = False
        '
        'lblSelectGametype
        '
        Me.lblSelectGametype.AutoSize = True
        Me.lblSelectGametype.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectGametype.Location = New System.Drawing.Point(287, 72)
        Me.lblSelectGametype.Name = "lblSelectGametype"
        Me.lblSelectGametype.Size = New System.Drawing.Size(337, 39)
        Me.lblSelectGametype.TabIndex = 0
        Me.lblSelectGametype.Text = "Select Game Type"
        '
        'pnlDifficulty
        '
        Me.pnlDifficulty.Controls.Add(Me.btnSelectDifficultyBack)
        Me.pnlDifficulty.Controls.Add(Me.btnSelectDifficulty)
        Me.pnlDifficulty.Controls.Add(Me.btnMedium)
        Me.pnlDifficulty.Controls.Add(Me.btnExpert)
        Me.pnlDifficulty.Controls.Add(Me.btnHard)
        Me.pnlDifficulty.Controls.Add(Me.btnEasy)
        Me.pnlDifficulty.Controls.Add(Me.lblDifficulty)
        Me.pnlDifficulty.Location = New System.Drawing.Point(0, 27)
        Me.pnlDifficulty.Name = "pnlDifficulty"
        Me.pnlDifficulty.Size = New System.Drawing.Size(911, 537)
        Me.pnlDifficulty.TabIndex = 6
        '
        'btnSelectDifficultyBack
        '
        Me.btnSelectDifficultyBack.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSelectDifficultyBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectDifficultyBack.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDifficultyBack.Location = New System.Drawing.Point(617, 440)
        Me.btnSelectDifficultyBack.Name = "btnSelectDifficultyBack"
        Me.btnSelectDifficultyBack.Size = New System.Drawing.Size(160, 49)
        Me.btnSelectDifficultyBack.TabIndex = 6
        Me.btnSelectDifficultyBack.Text = "Back"
        Me.btnSelectDifficultyBack.UseVisualStyleBackColor = False
        '
        'btnSelectDifficulty
        '
        Me.btnSelectDifficulty.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSelectDifficulty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectDifficulty.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDifficulty.Location = New System.Drawing.Point(134, 440)
        Me.btnSelectDifficulty.Name = "btnSelectDifficulty"
        Me.btnSelectDifficulty.Size = New System.Drawing.Size(160, 49)
        Me.btnSelectDifficulty.TabIndex = 5
        Me.btnSelectDifficulty.Text = "Select Difficulty"
        Me.btnSelectDifficulty.UseVisualStyleBackColor = False
        '
        'btnMedium
        '
        Me.btnMedium.BackColor = System.Drawing.Color.Silver
        Me.btnMedium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedium.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedium.Location = New System.Drawing.Point(523, 87)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(183, 120)
        Me.btnMedium.TabIndex = 4
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = False
        '
        'btnExpert
        '
        Me.btnExpert.BackColor = System.Drawing.Color.Silver
        Me.btnExpert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpert.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpert.Location = New System.Drawing.Point(523, 253)
        Me.btnExpert.Name = "btnExpert"
        Me.btnExpert.Size = New System.Drawing.Size(183, 120)
        Me.btnExpert.TabIndex = 3
        Me.btnExpert.Text = "Expert"
        Me.btnExpert.UseVisualStyleBackColor = False
        '
        'btnHard
        '
        Me.btnHard.BackColor = System.Drawing.Color.Silver
        Me.btnHard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHard.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHard.Location = New System.Drawing.Point(205, 253)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(183, 120)
        Me.btnHard.TabIndex = 2
        Me.btnHard.Text = "Hard"
        Me.btnHard.UseVisualStyleBackColor = False
        '
        'btnEasy
        '
        Me.btnEasy.BackColor = System.Drawing.Color.Silver
        Me.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEasy.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEasy.Location = New System.Drawing.Point(205, 87)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(183, 120)
        Me.btnEasy.TabIndex = 1
        Me.btnEasy.Text = "Easy"
        Me.btnEasy.UseVisualStyleBackColor = False
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(217, 22)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(477, 39)
        Me.lblDifficulty.TabIndex = 0
        Me.lblDifficulty.Text = "Select Difficulty Level"
        '
        'pnlGamePlay
        '
        Me.pnlGamePlay.Controls.Add(Me.lblGamePlayDifficulty)
        Me.pnlGamePlay.Controls.Add(Me.btnRestartGame)
        Me.pnlGamePlay.Controls.Add(Me.btnQuitGame)
        Me.pnlGamePlay.Controls.Add(Me.lblTime)
        Me.pnlGamePlay.Controls.Add(Me.pnlCards)
        Me.pnlGamePlay.Location = New System.Drawing.Point(0, 27)
        Me.pnlGamePlay.Name = "pnlGamePlay"
        Me.pnlGamePlay.Size = New System.Drawing.Size(911, 537)
        Me.pnlGamePlay.TabIndex = 7
        '
        'lblGamePlayDifficulty
        '
        Me.lblGamePlayDifficulty.AutoSize = True
        Me.lblGamePlayDifficulty.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePlayDifficulty.Location = New System.Drawing.Point(29, 22)
        Me.lblGamePlayDifficulty.Name = "lblGamePlayDifficulty"
        Me.lblGamePlayDifficulty.Size = New System.Drawing.Size(129, 19)
        Me.lblGamePlayDifficulty.TabIndex = 5
        Me.lblGamePlayDifficulty.Text = "Difficulty: "
        '
        'btnRestartGame
        '
        Me.btnRestartGame.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestartGame.Location = New System.Drawing.Point(620, 485)
        Me.btnRestartGame.Name = "btnRestartGame"
        Me.btnRestartGame.Size = New System.Drawing.Size(157, 39)
        Me.btnRestartGame.TabIndex = 4
        Me.btnRestartGame.Text = "Restart"
        Me.btnRestartGame.UseVisualStyleBackColor = True
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitGame.Location = New System.Drawing.Point(134, 485)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(157, 39)
        Me.btnQuitGame.TabIndex = 3
        Me.btnQuitGame.Text = "Quit"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(765, 22)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(119, 19)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time: 00:00"
        '
        'pnlCards
        '
        Me.pnlCards.Location = New System.Drawing.Point(134, 74)
        Me.pnlCards.Name = "pnlCards"
        Me.pnlCards.Size = New System.Drawing.Size(643, 389)
        Me.pnlCards.TabIndex = 1
        '
        'pnlResults
        '
        Me.pnlResults.Controls.Add(Me.btnResultsRecords)
        Me.pnlResults.Controls.Add(Me.btnContinue)
        Me.pnlResults.Controls.Add(Me.lblRecord)
        Me.pnlResults.Controls.Add(Me.lblResultsTime)
        Me.pnlResults.Controls.Add(Me.lblWin)
        Me.pnlResults.Location = New System.Drawing.Point(0, 27)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(911, 537)
        Me.pnlResults.TabIndex = 3
        '
        'btnResultsRecords
        '
        Me.btnResultsRecords.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultsRecords.Location = New System.Drawing.Point(534, 339)
        Me.btnResultsRecords.Name = "btnResultsRecords"
        Me.btnResultsRecords.Size = New System.Drawing.Size(183, 62)
        Me.btnResultsRecords.TabIndex = 6
        Me.btnResultsRecords.Text = "Records"
        Me.btnResultsRecords.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(193, 339)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(183, 62)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.Location = New System.Drawing.Point(351, 253)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(208, 29)
        Me.lblRecord.TabIndex = 4
        Me.lblRecord.Text = "Record: 00:00"
        '
        'lblResultsTime
        '
        Me.lblResultsTime.AutoSize = True
        Me.lblResultsTime.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsTime.Location = New System.Drawing.Point(366, 209)
        Me.lblResultsTime.Name = "lblResultsTime"
        Me.lblResultsTime.Size = New System.Drawing.Size(178, 29)
        Me.lblResultsTime.TabIndex = 3
        Me.lblResultsTime.Text = "Time: 00:00"
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Unispace", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.Location = New System.Drawing.Point(327, 133)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(257, 58)
        Me.lblWin.TabIndex = 0
        Me.lblWin.Text = "You ----"
        '
        'pnlRecords
        '
        Me.pnlRecords.Controls.Add(Me.btnClearRecords)
        Me.pnlRecords.Controls.Add(Me.btnRecordsBack)
        Me.pnlRecords.Controls.Add(Me.lblTimed)
        Me.pnlRecords.Controls.Add(Me.lstTimedScores)
        Me.pnlRecords.Controls.Add(Me.lblNormal)
        Me.pnlRecords.Controls.Add(Me.lstNormalScores)
        Me.pnlRecords.Controls.Add(Me.lblRecordsTitle)
        Me.pnlRecords.Location = New System.Drawing.Point(0, 27)
        Me.pnlRecords.Name = "pnlRecords"
        Me.pnlRecords.Size = New System.Drawing.Size(911, 537)
        Me.pnlRecords.TabIndex = 7
        '
        'btnClearRecords
        '
        Me.btnClearRecords.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearRecords.Location = New System.Drawing.Point(551, 413)
        Me.btnClearRecords.Name = "btnClearRecords"
        Me.btnClearRecords.Size = New System.Drawing.Size(226, 50)
        Me.btnClearRecords.TabIndex = 6
        Me.btnClearRecords.Text = "Clear Records"
        Me.btnClearRecords.UseVisualStyleBackColor = True
        '
        'btnRecordsBack
        '
        Me.btnRecordsBack.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordsBack.Location = New System.Drawing.Point(134, 413)
        Me.btnRecordsBack.Name = "btnRecordsBack"
        Me.btnRecordsBack.Size = New System.Drawing.Size(226, 50)
        Me.btnRecordsBack.TabIndex = 5
        Me.btnRecordsBack.Text = "Back"
        Me.btnRecordsBack.UseVisualStyleBackColor = True
        '
        'lblTimed
        '
        Me.lblTimed.AutoSize = True
        Me.lblTimed.Font = New System.Drawing.Font("Unispace", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimed.Location = New System.Drawing.Point(614, 97)
        Me.lblTimed.Name = "lblTimed"
        Me.lblTimed.Size = New System.Drawing.Size(100, 33)
        Me.lblTimed.TabIndex = 4
        Me.lblTimed.Text = "Timed"
        '
        'lstTimedScores
        '
        Me.lstTimedScores.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTimedScores.FormattingEnabled = True
        Me.lstTimedScores.ItemHeight = 25
        Me.lstTimedScores.Location = New System.Drawing.Point(551, 133)
        Me.lstTimedScores.Name = "lstTimedScores"
        Me.lstTimedScores.Size = New System.Drawing.Size(226, 229)
        Me.lstTimedScores.TabIndex = 3
        '
        'lblNormal
        '
        Me.lblNormal.AutoSize = True
        Me.lblNormal.Font = New System.Drawing.Font("Unispace", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNormal.Location = New System.Drawing.Point(189, 97)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(117, 33)
        Me.lblNormal.TabIndex = 2
        Me.lblNormal.Text = "Normal"
        '
        'lstNormalScores
        '
        Me.lstNormalScores.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNormalScores.FormattingEnabled = True
        Me.lstNormalScores.ItemHeight = 25
        Me.lstNormalScores.Location = New System.Drawing.Point(134, 133)
        Me.lstNormalScores.Name = "lstNormalScores"
        Me.lstNormalScores.Size = New System.Drawing.Size(226, 229)
        Me.lstNormalScores.TabIndex = 1
        '
        'lblRecordsTitle
        '
        Me.lblRecordsTitle.AutoSize = True
        Me.lblRecordsTitle.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordsTitle.Location = New System.Drawing.Point(377, 32)
        Me.lblRecordsTitle.Name = "lblRecordsTitle"
        Me.lblRecordsTitle.Size = New System.Drawing.Size(157, 39)
        Me.lblRecordsTitle.TabIndex = 0
        Me.lblRecordsTitle.Text = "Records"
        '
        'frmDontForget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 563)
        Me.Controls.Add(Me.pnlRecords)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.pnlGamePlay)
        Me.Controls.Add(Me.pnlDifficulty)
        Me.Controls.Add(Me.pnlGameType)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(927, 602)
        Me.MinimumSize = New System.Drawing.Size(927, 602)
        Me.Name = "frmDontForget"
        Me.Text = "Don't Forget: Memory Card Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlGameType.ResumeLayout(False)
        Me.pnlGameType.PerformLayout()
        Me.pnlDifficulty.ResumeLayout(False)
        Me.pnlDifficulty.PerformLayout()
        Me.pnlGamePlay.ResumeLayout(False)
        Me.pnlGamePlay.PerformLayout()
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        Me.pnlRecords.ResumeLayout(False)
        Me.pnlRecords.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CosmicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlGameType As Panel
    Friend WithEvents btnTimed As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents lblSelectGametype As Label
    Friend WithEvents btnSelectGameType As Button
    Friend WithEvents lblGameTypeInfo As Label
    Friend WithEvents btnGameTypeBack As Button
    Friend WithEvents pnlDifficulty As Panel
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnExpert As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents btnEasy As Button
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents btnSelectDifficultyBack As Button
    Friend WithEvents btnSelectDifficulty As Button
    Friend WithEvents StandardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlGamePlay As Panel
    Friend WithEvents pnlCards As Panel
    Friend WithEvents OptionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlResults As Panel
    Friend WithEvents lblWin As Label
    Friend WithEvents btnRestartGame As Button
    Friend WithEvents btnQuitGame As Button
    Friend WithEvents lblGamePlayDifficulty As Label
    Friend WithEvents lblResultsTime As Label
    Friend WithEvents lblRecord As Label
    Friend WithEvents btnResultsRecords As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents pnlRecords As Panel
    Friend WithEvents lblTimed As Label
    Friend WithEvents lstTimedScores As ListBox
    Friend WithEvents lblNormal As Label
    Friend WithEvents lstNormalScores As ListBox
    Friend WithEvents lblRecordsTitle As Label
    Friend WithEvents btnClearRecords As Button
    Friend WithEvents btnRecordsBack As Button
End Class
