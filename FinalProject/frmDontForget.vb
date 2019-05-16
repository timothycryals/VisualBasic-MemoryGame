' Program:  Don't Forget Memory Card Game
' Author:   Timothy Ryals
' Date:     April 29, 2018
' Purpose:  This program will simulate a memory card game based on certain settings selected by the user,
'           such as difficulty and game type. The program will also record the best time for each difficulty
'           so that the user can compare their scores.

Option Strict On

Imports System
Imports System.IO
Imports System.Text

Public Class frmDontForget

    ' Public Variables

    Public _crdCard1 As MatchingCard
    Public _crdCard2 As MatchingCard
    Public _intTotalCards As Integer = 12
    Public _intTime As Integer = 0
    Public _intTimeLimit As Integer = 60
    Public _blnGameInProgress As Boolean = False

    ' Class Variables

    Private _strGameType As String = "Normal"
    Private _strDifficulty As String = "Easy"

    Private _BasicImages As Image() = New Image(11) {My.Resources.Resource1.Arrow, My.Resources.Resource1.Circle, My.Resources.Resource1.Cone,
                                                My.Resources.Resource1.Tube, My.Resources.Resource1.Diamond, My.Resources.Resource1.Octagon,
                                                My.Resources.Resource1.Oval, My.Resources.Resource1.Pentagon, My.Resources.Resource1.Square,
                                                My.Resources.Resource1.Star, My.Resources.Resource1.Trapezoid, My.Resources.Resource1.Triangle}


    ' Lists of location data for each difficulty

    Private easyLocationsList As List(Of Point) = New List(Of Point)
    Private mediumLocationsList As List(Of Point) = New List(Of Point)
    Private hardLocationsList As List(Of Point) = New List(Of Point)
    Private expertLocationsList As List(Of Point) = New List(Of Point)

    Private basicList As List(Of Image) = New List(Of Image)

    ' Thread variables

    Private tStartTimer As Threading.Thread = New Threading.Thread(Sub() startTimer(Me))
    Private tStartCountdown As Threading.Thread = New Threading.Thread(Sub() startCountdown(Me))

    Private Sub frmDontForget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This Sub procedure will execute when the program is opened. It will load the title screen
        ' and instantiate the lists containing the locations for the matching cards

        'instantiateLists()
        AcceptButton = btnStart
        pnlGameType.Visible = False
        pnlDifficulty.Visible = False
        pnlGamePlay.Visible = False
        pnlResults.Visible = False
        pnlCards.Visible = False
        pnlRecords.Visible = False

    End Sub

    Private Sub frmDontForget_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' This event handler will fire when the user closes the program and will terminate all running threads.

        tStartTimer.Abort()
        tStartCountdown.Abort()
        Application.Exit()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' This event handler fires when the user clicks the Start Game button on the title screen.
        ' It will bring the user to the screen where they will selectr their game type.

        pnlTitle.Visible = False
        pnlGameType.Visible = True
        AcceptButton = btnSelectGameType
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        ' This event handler will fire when the user clicks the Records button on the title screen.
        ' It will bring the user to the Records screen where they can view their best times.

        Dim strList As List(Of String) = New List(Of String)
        Dim t1 As Integer
        Dim t2 As Integer

        lstNormalScores.Items.Clear()
        lstTimedScores.Items.Clear()

        For i = 1 To 8
            Select Case i
                Case 1
                    t1 = My.Settings.NormalEasy \ 60
                    t2 = My.Settings.NormalEasy Mod 60
                    lstNormalScores.Items.Add("Easy:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 2
                    t1 = My.Settings.NormalMedium \ 60
                    t2 = My.Settings.NormalMedium Mod 60
                    lstNormalScores.Items.Add("Medium:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 3
                    t1 = My.Settings.NormalHard \ 60
                    t2 = My.Settings.NormalHard Mod 60
                    lstNormalScores.Items.Add("Hard:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 4
                    t1 = My.Settings.NormalExpert \ 60
                    t2 = My.Settings.NormalExpert Mod 60
                    lstNormalScores.Items.Add("Expert:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 5
                    t1 = My.Settings.TimedEasy \ 60
                    t2 = My.Settings.TimedEasy Mod 60
                    lstTimedScores.Items.Add("Easy:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 6
                    t1 = My.Settings.TimedMedium \ 60
                    t2 = My.Settings.TimedMedium Mod 60
                    lstTimedScores.Items.Add("Medium:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 7
                    t1 = My.Settings.TimedHard \ 60
                    t2 = My.Settings.TimedHard Mod 60
                    lstTimedScores.Items.Add("Hard:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 8
                    t1 = My.Settings.TimedExpert \ 60
                    t2 = My.Settings.TimedExpert Mod 60
                    lstTimedScores.Items.Add("Expert:" & vbTab & t1.ToString() & ":" & t2.ToString())
            End Select
        Next

        pnlResults.Visible = False
        pnlTitle.Visible = False
        pnlRecords.Visible = True
        AcceptButton = btnRecordsBack

    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        ' This event handler will fire when the user clicks the Normal button on the difficulty page.
        ' It will set the difficulty to Normal.

        btnTimed.BackColor = Color.Gainsboro
        btnNormal.BackColor = Color.LightBlue
        _strGameType = "Normal"
        lblGameTypeInfo.Text = "Normal: The player will have unlimited time to match all cards"
    End Sub

    Private Sub btnTimed_Click(sender As Object, e As EventArgs) Handles btnTimed.Click
        ' This event handler will fire when the user clicks the Timed button on the Game Types screen.
        ' It will set the game type to the Timed mode.

        btnNormal.BackColor = Color.Gainsboro
        btnTimed.BackColor = Color.LightBlue
        _strGameType = "Timed"
        lblGameTypeInfo.Text = "Timed: The Player will have limited time to match all cards"
    End Sub

    Private Sub btnSelectGameType_Click(sender As Object, e As EventArgs) Handles btnSelectGameType.Click
        ' This event handler fires when the user clicks the Select Game Type button on the Game Type screen.
        ' It will bring the user to the screen where they will select their difficulty.

        pnlDifficulty.Visible = True
        pnlGameType.Visible = False
        AcceptButton = btnSelectDifficulty
    End Sub

    Private Sub btnGameTypeBack_Click(sender As Object, e As EventArgs) Handles btnGameTypeBack.Click
        ' This event handler will fire when the user clicks the Back button on the Game Type screen.
        ' It will bring the user back to the Title screen.

        pnlGameType.Visible = False
        pnlTitle.Visible = True
        AcceptButton = btnStart
    End Sub

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        ' This event handler will fire when the user clicks the Easy button on the Select Difficulty screen.
        ' It will set the difficulty to easy.

        btnEasy.BackColor = Color.LightBlue
        btnMedium.BackColor = Color.Gainsboro
        btnHard.BackColor = Color.Gainsboro
        btnExpert.BackColor = Color.Gainsboro
        _strDifficulty = "Easy"
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        ' This event handler will fire when the user clicks the Medium button on the Select Difficulty screen.
        ' It will set the difficulty to medium.

        btnEasy.BackColor = Color.Gainsboro
        btnMedium.BackColor = Color.LightBlue
        btnHard.BackColor = Color.Gainsboro
        btnExpert.BackColor = Color.Gainsboro
        _strDifficulty = "Medium"
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        ' This event handler will fire when the user clicks the Hard button on the Select Difficulty screen.
        ' It will set the difficulty to hard.

        btnEasy.BackColor = Color.Gainsboro
        btnMedium.BackColor = Color.Gainsboro
        btnHard.BackColor = Color.LightBlue
        btnExpert.BackColor = Color.Gainsboro
        _strDifficulty = "Hard"
    End Sub

    Private Sub btnExpert_Click(sender As Object, e As EventArgs) Handles btnExpert.Click
        ' This event handler will fire when the user clicks the Expert button on the Select Difficulty screen.
        ' It will set the difficulty to expert.

        btnEasy.BackColor = Color.Gainsboro
        btnMedium.BackColor = Color.Gainsboro
        btnHard.BackColor = Color.Gainsboro
        btnExpert.BackColor = Color.LightBlue
        _strDifficulty = "Expert"
    End Sub

    Private Sub btnSelectDifficulty_Click(sender As Object, e As EventArgs) Handles btnSelectDifficulty.Click
        ' This event handler will fire when the user clicks the Select Difficulty button on the Difficulty screen.
        ' It will bring the user to the Gameplay screen.

        instantiateLists()
        pnlDifficulty.Visible = False
        pnlGamePlay.Visible = True
        startGame()
        _blnGameInProgress = True
        lblGamePlayDifficulty.Text = "Difficulty: " & _strDifficulty
        lblGamePlayDifficulty.Parent = pnlGamePlay
    End Sub

    Private Sub btnSelectDifficultyBack_Click(sender As Object, e As EventArgs) Handles btnSelectDifficultyBack.Click
        ' This event handler will fire when the user clicks the Back button on the Difficulty screen.
        ' It will bring the user back to the Game Type screen.

        pnlDifficulty.Visible = False
        pnlGameType.Visible = True
        AcceptButton = btnSelectGameType
    End Sub

    Private Sub instantiateLists()
        ' This Sub procedure will fill all of the lists with location data for the cards

        ' Adds location data of cards for easy difficulty
        easyLocationsList.Add(New Point(173, 12))
        easyLocationsList.Add(New Point(293, 12))
        easyLocationsList.Add(New Point(413, 12))
        easyLocationsList.Add(New Point(173, 109))
        easyLocationsList.Add(New Point(293, 109))
        easyLocationsList.Add(New Point(413, 109))
        easyLocationsList.Add(New Point(173, 206))
        easyLocationsList.Add(New Point(293, 206))
        easyLocationsList.Add(New Point(413, 206))
        easyLocationsList.Add(New Point(173, 303))
        easyLocationsList.Add(New Point(293, 303))
        easyLocationsList.Add(New Point(413, 303))

        ' Adds location data of cards for medium difficulty
        mediumLocationsList.Add(New Point(113, 12))
        mediumLocationsList.Add(New Point(233, 12))
        mediumLocationsList.Add(New Point(353, 12))
        mediumLocationsList.Add(New Point(473, 12))
        mediumLocationsList.Add(New Point(113, 109))
        mediumLocationsList.Add(New Point(233, 109))
        mediumLocationsList.Add(New Point(353, 109))
        mediumLocationsList.Add(New Point(473, 109))
        mediumLocationsList.Add(New Point(113, 206))
        mediumLocationsList.Add(New Point(233, 206))
        mediumLocationsList.Add(New Point(353, 206))
        mediumLocationsList.Add(New Point(473, 206))
        mediumLocationsList.Add(New Point(113, 303))
        mediumLocationsList.Add(New Point(233, 303))
        mediumLocationsList.Add(New Point(353, 303))
        mediumLocationsList.Add(New Point(473, 303))

        ' Adds location data of cards for hard difficulty
        hardLocationsList.Add(New Point(53, 12))
        hardLocationsList.Add(New Point(173, 12))
        hardLocationsList.Add(New Point(293, 12))
        hardLocationsList.Add(New Point(413, 12))
        hardLocationsList.Add(New Point(533, 12))
        hardLocationsList.Add(New Point(53, 109))
        hardLocationsList.Add(New Point(173, 109))
        hardLocationsList.Add(New Point(293, 109))
        hardLocationsList.Add(New Point(413, 109))
        hardLocationsList.Add(New Point(533, 109))
        hardLocationsList.Add(New Point(53, 206))
        hardLocationsList.Add(New Point(173, 206))
        hardLocationsList.Add(New Point(293, 206))
        hardLocationsList.Add(New Point(413, 206))
        hardLocationsList.Add(New Point(533, 206))
        hardLocationsList.Add(New Point(53, 303))
        hardLocationsList.Add(New Point(173, 303))
        hardLocationsList.Add(New Point(293, 303))
        hardLocationsList.Add(New Point(413, 303))
        hardLocationsList.Add(New Point(533, 303))

        ' Adds location data of cards for expert difficulty
        expertLocationsList.Add(New Point(17, 27))
        expertLocationsList.Add(New Point(96, 27))
        expertLocationsList.Add(New Point(175, 27))
        expertLocationsList.Add(New Point(254, 27))
        expertLocationsList.Add(New Point(333, 27))
        expertLocationsList.Add(New Point(412, 27))
        expertLocationsList.Add(New Point(491, 27))
        expertLocationsList.Add(New Point(570, 27))
        expertLocationsList.Add(New Point(17, 150))
        expertLocationsList.Add(New Point(96, 150))
        expertLocationsList.Add(New Point(175, 150))
        expertLocationsList.Add(New Point(254, 150))
        expertLocationsList.Add(New Point(333, 150))
        expertLocationsList.Add(New Point(412, 150))
        expertLocationsList.Add(New Point(491, 150))
        expertLocationsList.Add(New Point(570, 150))
        expertLocationsList.Add(New Point(17, 273))
        expertLocationsList.Add(New Point(96, 273))
        expertLocationsList.Add(New Point(175, 273))
        expertLocationsList.Add(New Point(254, 273))
        expertLocationsList.Add(New Point(333, 273))
        expertLocationsList.Add(New Point(412, 273))
        expertLocationsList.Add(New Point(491, 273))
        expertLocationsList.Add(New Point(570, 273))

        For l = 0 To 11
            basicList.Add(_BasicImages(l))
        Next
    End Sub

    Public Sub SetTimeLabel(stringValue As String)
        ' This Sub procedure will update the time label on the Gameplay screen.
        ' It will be used in a separate thread so the thread can interact with the form's
        ' controls

        Me.BeginInvoke(Sub() Me.lblTime.Text = stringValue)
    End Sub

    Public Sub SetResultsTimeLabel(stringValue As String)
        ' This Sub procedure will update the time label on the Results screen.
        ' It will be used in a separate thread so the thread can interact with the form's
        ' controls

        Me.BeginInvoke(Sub() Me.lblResultsTime.Text = stringValue)
    End Sub

    Private Sub startTimer(frmMain As frmDontForget)
        ' This funtion will be called in a seperate thread and will increase the _intTime variable by 1 every second
        ' to keep track of time

        Dim t1 As Integer
        Dim t2 As Integer

        While _intTotalCards > 0
            Threading.Thread.Sleep(1000)
            _intTime += 1
            t1 = _intTime \ 60
            t2 = _intTime Mod 60

            If t2 > 9 Then
                frmMain.SetTimeLabel("Time: 0" & t1.ToString() & ":" & t2.ToString())
            ElseIf t2 < 10 Then
                frmMain.SetTimeLabel("Time: 0" & t1.ToString() & ":0" & t2.ToString())
            End If
        End While
        _intTime -= 1
        frmMain.showGameResults(frmMain)
    End Sub

    Private Sub startCountdown(frmMain As frmDontForget)
        ' This funtion will be called in a seperate thread and will decrease the _intTime variable by 1 every second
        ' to keep track of time

        _intTime = _intTimeLimit
        Dim t1 As Integer
        Dim t2 As Integer

        While _intTotalCards > 0 And _intTime > 0
            Threading.Thread.Sleep(1000)
            _intTime -= 1
            t1 = _intTime \ 60
            t2 = _intTime Mod 60

            If t2 > 9 Then
                frmMain.SetTimeLabel("Time: 0" & t1.ToString() & ":" & t2.ToString())
            ElseIf t2 < 10 Then
                frmMain.SetTimeLabel("Time: 0" & t1.ToString() & ":0" & t2.ToString())
            End If
        End While
        If (_intTotalCards = 0) Then
            _intTime += 1
        End If
        frmMain.showGameResults(frmMain)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        ' This event handler fires when the user clicks the Exit menu item in the Options menu.
        ' It will terminate all running threads and end the program.

        tStartTimer.Abort()
        tStartCountdown.Abort()
        Application.Exit()
    End Sub

    Private Sub startGame()
        tStartTimer.Abort()
        tStartCountdown.Abort()

        tStartTimer = New Threading.Thread(Sub() startTimer(Me))
        tStartCountdown = New Threading.Thread(Sub() startCountdown(Me))
        pnlCards.Controls.Clear()
        _intTime = 0
        Select Case _strDifficulty
            Case "Easy"

                Dim full As Boolean = False
                Dim cardIndex As Integer = 0
                Dim indexes As List(Of Integer) = New List(Of Integer)
                Dim cards As List(Of MatchingCard) = New List(Of MatchingCard)

                _intTotalCards = 12

                Dim random As New Random()
                Dim intIndex As Integer
                Dim cardLocation As New Point()

                For i As Integer = 0 To 5
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                Next

                While full = False
                    Try
                        intIndex = random.Next(0, easyLocationsList.Count - 1)
                    Catch e As ArgumentOutOfRangeException
                        full = True
                        Continue While
                    End Try

                    If easyLocationsList(intIndex) = Nothing Then
                        Continue While
                    ElseIf Not easyLocationsList(intIndex) = Nothing And cardIndex < 12 Then
                        cards(cardIndex)._picImage.Location = easyLocationsList(intIndex)
                        cards(cardIndex)._Cover.Location = easyLocationsList(intIndex)

                        easyLocationsList.RemoveAt(intIndex)
                        cardIndex += 1
                    Else
                        full = True
                    End If

                End While

                pnlCards.Visible = True
                If _strGameType = "Normal" Then
                    tStartTimer.Start()
                Else
                    tStartCountdown.Start()
                End If
                lblTime.Focus()
                easyLocationsList.Clear()
                easyLocationsList.TrimExcess()
                mediumLocationsList.Clear()
                mediumLocationsList.TrimExcess()
                hardLocationsList.Clear()
                hardLocationsList.TrimExcess()
                expertLocationsList.Clear()
                expertLocationsList.TrimExcess()

            Case "Medium"

                Dim full As Boolean = False
                Dim cardIndex As Integer = 0
                Dim indexes As List(Of Integer) = New List(Of Integer)
                Dim cards As List(Of MatchingCard) = New List(Of MatchingCard)

                _intTotalCards = 16

                Dim random As New Random()
                Dim intIndex As Integer
                Dim cardLocation As New Point()

                For i As Integer = 0 To 7
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                Next

                While full = False
                    Try
                        intIndex = random.Next(0, mediumLocationsList.Count - 1)
                    Catch e As ArgumentOutOfRangeException
                        full = True
                        Continue While
                    End Try

                    If mediumLocationsList(intIndex) = Nothing Then
                        Continue While
                    ElseIf Not mediumLocationsList(intIndex) = Nothing And cardIndex < 16 Then
                        cards(cardIndex)._picImage.Location = mediumLocationsList(intIndex)
                        cards(cardIndex)._Cover.Location = mediumLocationsList(intIndex)

                        mediumLocationsList.RemoveAt(intIndex)
                        cardIndex += 1
                    Else
                        full = True
                    End If

                End While

                pnlCards.Visible = True
                If _strGameType = "Normal" Then
                    tStartTimer.Start()
                Else
                    tStartCountdown.Start()
                End If
                lblTime.Focus()
                easyLocationsList.Clear()
                easyLocationsList.TrimExcess()
                mediumLocationsList.Clear()
                mediumLocationsList.TrimExcess()
                hardLocationsList.Clear()
                hardLocationsList.TrimExcess()
                expertLocationsList.Clear()
                expertLocationsList.TrimExcess()

            Case "Hard"

                Dim full As Boolean = False
                Dim cardIndex As Integer = 0
                Dim indexes As List(Of Integer) = New List(Of Integer)
                Dim cards As List(Of MatchingCard) = New List(Of MatchingCard)

                _intTotalCards = 20

                Dim random As New Random()
                Dim intIndex As Integer
                Dim cardLocation As New Point()

                For i As Integer = 0 To 9
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                Next

                While full = False
                    Try
                        intIndex = random.Next(0, hardLocationsList.Count - 1)
                    Catch e As ArgumentOutOfRangeException
                        full = True
                        Continue While
                    End Try

                    If hardLocationsList(intIndex) = Nothing Then
                        Continue While
                    ElseIf Not mediumLocationsList(intIndex) = Nothing And cardIndex < 20 Then
                        cards(cardIndex)._picImage.Location = hardLocationsList(intIndex)
                        cards(cardIndex)._Cover.Location = hardLocationsList(intIndex)

                        hardLocationsList.RemoveAt(intIndex)
                        cardIndex += 1
                    Else
                        full = True
                    End If

                End While

                pnlCards.Visible = True
                If _strGameType = "Normal" Then
                    tStartTimer.Start()
                Else
                    tStartCountdown.Start()
                End If
                lblTime.Focus()
                easyLocationsList.Clear()
                easyLocationsList.TrimExcess()
                mediumLocationsList.Clear()
                mediumLocationsList.TrimExcess()
                hardLocationsList.Clear()
                hardLocationsList.TrimExcess()
                expertLocationsList.Clear()
                expertLocationsList.TrimExcess()

            Case "Expert"

                Dim full As Boolean = False
                Dim cardIndex As Integer = 0
                Dim indexes As List(Of Integer) = New List(Of Integer)
                Dim cards As List(Of MatchingCard) = New List(Of MatchingCard)

                _intTotalCards = 24

                Dim random As New Random()
                Dim intIndex As Integer
                Dim cardLocation As New Point()

                For i As Integer = 0 To 11
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                    cards.Add(New MatchingCard(i, basicList(i), New Point(173, 12)))
                Next

                While full = False
                    Try
                        intIndex = random.Next(0, expertLocationsList.Count - 1)
                    Catch e As ArgumentOutOfRangeException
                        full = True
                        Continue While
                    End Try

                    If expertLocationsList(intIndex) = Nothing Then
                        Continue While
                    ElseIf Not expertLocationsList(intIndex) = Nothing And cardIndex < 24 Then
                        cards(cardIndex)._picImage.Location = expertLocationsList(intIndex)
                        cards(cardIndex)._Cover.Location = expertLocationsList(intIndex)

                        expertLocationsList.RemoveAt(intIndex)
                        cardIndex += 1
                    Else
                        full = True
                    End If

                End While

                pnlCards.Visible = True
                If _strGameType = "Normal" Then
                    tStartTimer.Start()
                Else
                    tStartCountdown.Start()
                End If
                lblTime.Focus()
                easyLocationsList.Clear()
                easyLocationsList.TrimExcess()
                mediumLocationsList.Clear()
                mediumLocationsList.TrimExcess()
                hardLocationsList.Clear()
                hardLocationsList.TrimExcess()
                expertLocationsList.Clear()
                expertLocationsList.TrimExcess()
        End Select
    End Sub

    Public Sub showGameResults(frmMain As frmDontForget)

        While _blnGameInProgress
            If (_strGameType = "Timed" And (_intTime = 0 Or _intTotalCards = 0)) Then
                _blnGameInProgress = False
            ElseIf (_strGameType = "Normal" And _intTotalCards = 0) Then
                _blnGameInProgress = False
            End If
        End While
        Me.BeginInvoke(
            Sub()
                Dim t1 As Integer
                Dim t2 As Integer

                Me.pnlGamePlay.Visible = False
                Me.pnlCards.Visible = False
                Me.pnlResults.Visible = True
                If _strGameType = "Normal" And _intTotalCards = 0 Then
                    Me.lblWin.Text = "You Win "
                ElseIf _strGameType = "Timed" And _intTotalCards = 0 Then
                    Me.lblWin.Text = "You Win "
                ElseIf _strGameType = "Timed" And _intTotalCards > 0 Then
                    Me.lblWin.Text = "You Lose"
                End If

                t1 = _intTime \ 60
                t2 = _intTime Mod 60

                If t2 > 9 Then
                    frmMain.SetResultsTimeLabel("Time: 0" & t1.ToString() & ":" & t2.ToString())
                ElseIf t2 < 10 Then
                    frmMain.SetResultsTimeLabel("Time: 0" & t1.ToString() & ":0" & t2.ToString())
                End If
                Me.lblGamePlayDifficulty.Parent = pnlResults
            End Sub)

        Select Case _strDifficulty
            Case "Easy"
                If _strGameType = "Normal" Then
                    Dim tempInt As Integer = My.Settings.NormalEasy
                    If _intTime < tempInt Or tempInt = 0 Then
                        My.Settings.NormalEasy = _intTime
                        My.Settings.Save()
                    End If
                Else
                    Dim tempInt As Integer = My.Settings.TimedEasy
                    If _intTime > tempInt Or tempInt = 0 Then
                        My.Settings.TimedEasy = _intTime
                        My.Settings.Save()
                    End If
                End If
            Case "Medium"
                If _strGameType = "Normal" Then
                    Dim tempInt As Integer = My.Settings.NormalMedium
                    If _intTime < tempInt Or tempInt = 0 Then
                        My.Settings.NormalMedium = _intTime
                        My.Settings.Save()
                    End If
                Else
                    Dim tempInt As Integer = My.Settings.TimedMedium
                    If _intTime > tempInt Or tempInt = 0 Then
                        My.Settings.TimedMedium = _intTime
                        My.Settings.Save()
                    End If
                End If
            Case "Hard"
                If _strGameType = "Normal" Then
                    Dim tempInt As Integer = My.Settings.NormalHard
                    If _intTime < tempInt Or tempInt = 0 Then
                        My.Settings.NormalHard = _intTime
                        My.Settings.Save()
                    End If
                Else
                    Dim tempInt As Integer = My.Settings.TimedHard
                    If _intTime > tempInt Or tempInt = 0 Then
                        My.Settings.TimedHard = _intTime
                        My.Settings.Save()
                    End If
                End If
            Case "Expert"
                If _strGameType = "Normal" Then
                    Dim tempInt As Integer = My.Settings.NormalExpert
                    If _intTime < tempInt Or tempInt = 0 Then
                        My.Settings.NormalExpert = _intTime
                        My.Settings.Save()
                    End If
                Else
                    Dim tempInt As Integer = My.Settings.TimedExpert
                    If _intTime > tempInt Or tempInt = 0 Then
                        My.Settings.TimedExpert = _intTime
                        My.Settings.Save()
                    End If
                End If
        End Select

    End Sub

    Private Sub btnQuitGame_Click(sender As Object, e As EventArgs) Handles btnQuitGame.Click
        tStartCountdown.Abort()
        tStartTimer.Abort()

        pnlCards.Controls.Clear()
        instantiateLists()
        pnlCards.Visible = False
        pnlRecords.Visible = False
        pnlDifficulty.Visible = False
        pnlGamePlay.Visible = False
        pnlGameType.Visible = False
        pnlResults.Visible = False
        pnlTitle.Visible = True

        Dim _strGameType As String = "Normal"
        Dim _strDifficulty As String = "Easy"

        tStartTimer = New Threading.Thread(Sub() startTimer(Me))
        tStartCountdown = New Threading.Thread(Sub() startCountdown(Me))

        AcceptButton = btnStart
    End Sub

    Private Sub btnRestartGame_Click(sender As Object, e As EventArgs) Handles btnRestartGame.Click
        tStartCountdown.Abort()
        tStartTimer.Abort()

        pnlCards.Controls.Clear()

        tStartTimer = New Threading.Thread(Sub() startTimer(Me))
        tStartCountdown = New Threading.Thread(Sub() startCountdown(Me))

        instantiateLists()

        startGame()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        pnlTitle.Visible = True
        pnlResults.Visible = False
        pnlGameType.Visible = False
        pnlGamePlay.Visible = False
        pnlCards.Visible = False
        pnlDifficulty.Visible = False

        instantiateLists()

        tStartTimer = New Threading.Thread(Sub() startTimer(Me))
        tStartCountdown = New Threading.Thread(Sub() startCountdown(Me))

        Dim _strGameType As String = "Normal"
        Dim _strDifficulty As String = "Easy"
        AcceptButton = btnStart
    End Sub

    Private Sub btnResultsRecords_Click(sender As Object, e As EventArgs) Handles btnResultsRecords.Click
        ' This event handler will fire when the user clicks the Records button on the Results screen.
        ' It will bring the user to the Records screen where they can view their best times.

        Dim strList As List(Of String) = New List(Of String)
        Dim t1 As Integer
        Dim t2 As Integer

        lstNormalScores.Items.Clear()
        lstTimedScores.Items.Clear()

        For i = 1 To 8
            Select Case i
                Case 1
                    t1 = My.Settings.NormalEasy \ 60
                    t2 = My.Settings.NormalEasy Mod 60
                    lstNormalScores.Items.Add("Easy:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 2
                    t1 = My.Settings.NormalMedium \ 60
                    t2 = My.Settings.NormalMedium Mod 60
                    lstNormalScores.Items.Add("Medium:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 3
                    t1 = My.Settings.NormalHard \ 60
                    t2 = My.Settings.NormalHard Mod 60
                    lstNormalScores.Items.Add("Hard:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 4
                    t1 = My.Settings.NormalExpert \ 60
                    t2 = My.Settings.NormalExpert Mod 60
                    lstNormalScores.Items.Add("Expert:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 5
                    t1 = My.Settings.TimedEasy \ 60
                    t2 = My.Settings.TimedEasy Mod 60
                    lstTimedScores.Items.Add("Easy:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 6
                    t1 = My.Settings.TimedMedium \ 60
                    t2 = My.Settings.TimedMedium Mod 60
                    lstTimedScores.Items.Add("Medium:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 7
                    t1 = My.Settings.TimedHard \ 60
                    t2 = My.Settings.TimedHard Mod 60
                    lstTimedScores.Items.Add("Hard:" & vbTab & t1.ToString() & ":" & t2.ToString())
                Case 8
                    t1 = My.Settings.TimedExpert \ 60
                    t2 = My.Settings.TimedExpert Mod 60
                    lstTimedScores.Items.Add("Expert:" & vbTab & t1.ToString() & ":" & t2.ToString())
            End Select
        Next

        pnlResults.Visible = False
        pnlTitle.Visible = False
        pnlRecords.Visible = True
        AcceptButton = btnRecordsBack

    End Sub

    Private Sub btnRecordsBack_Click(sender As Object, e As EventArgs) Handles btnRecordsBack.Click
        pnlTitle.Visible = True
        pnlRecords.Visible = False
        AcceptButton = btnStart
    End Sub

    Private Sub btnClearRecords_Click(sender As Object, e As EventArgs) Handles btnClearRecords.Click
        My.Settings.NormalEasy = 0
        My.Settings.NormalMedium = 0
        My.Settings.NormalHard = 0
        My.Settings.NormalExpert = 0
        My.Settings.TimedEasy = 0
        My.Settings.TimedMedium = 0
        My.Settings.TimedHard = 0
        My.Settings.TimedExpert = 0

        pnlTitle.Visible = True
        btnRecords.PerformClick()
    End Sub
End Class
