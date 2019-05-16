' Class:        Matching Card
' Developer:    Timothy Ryals
' Date:         April 29, 2018
' Purpose:      This class for a matching card will create a matching card object and will also check if two cards match.

' This class will allow the program to create a Matching Card object.

Option Strict On

Public Class MatchingCard

    ' Class Variables
    Public _name As String
    Public _picImage As PictureBox
    Public _Cover As Button

    Public Sub New(ByRef cardNumber As Integer, ByRef imgImage As Image, ByVal location As Point)
        ' This is the constructor for the Matching Card object. It requires an image, an integer, and a point
        ' as parameters. These parameters will decide the number for the card, the image under the card, and
        ' the location of the card.

        Me._name = "MatchingCard_" & cardNumber

        Me._picImage = New PictureBox
        Me._picImage.Size = New Size(54, 54)
        Me._picImage.BackgroundImage = imgImage
        Me._picImage.BackgroundImageLayout = ImageLayout.Stretch
        frmDontForget.pnlCards.Controls.Add(_picImage)
        Me._picImage.Location = location
        Me._picImage.SendToBack()

        Me._Cover = New Button
        Me._Cover.Size = New Size(54, 74)
        Me._Cover.BackgroundImage = My.Resources.card
        Me._Cover.BackgroundImageLayout = ImageLayout.Stretch
        frmDontForget.pnlCards.Controls.Add(_Cover)
        Me._Cover.Location = location
        Me._Cover.BringToFront()

        AddHandler _Cover.Click, AddressOf CardIsClicked
    End Sub

    Public Sub CardIsClicked(ByVal sender As Object, ByVal e As EventArgs)
        ' This event handler fires when the user clicks a MatchingCard object.
        ' This will "flip" the card over and check if the next card the user clicks
        ' matches the first one.

        Dim btn As Button = DirectCast(sender, Button)

        btn.Visible = False
        If frmDontForget._crdCard1 Is Nothing Then
            frmDontForget._crdCard1 = Me
            frmDontForget.lblTime.Focus()
        ElseIf frmDontForget._crdCard2 Is Nothing Then
            frmDontForget._crdCard2 = Me
            frmDontForget.lblTime.Focus()
            Check(frmDontForget._crdCard1, frmDontForget._crdCard2)
        Else
            btn.Visible = True
        End If
    End Sub

    Public Sub Check(ByRef crdCard1 As MatchingCard, ByRef crdCard2 As MatchingCard)
        ' This Sub procedure will compare two cards to see if they match. If they do,
        ' the two card objects will be disposed and the total number of cards is reduced by two.

        If crdCard1._name = crdCard2._name Then
            frmDontForget._intTotalCards -= 2
            crdCard1._picImage.Dispose()
            crdCard1._Cover.Dispose()
            crdCard2._picImage.Dispose()
            crdCard2._Cover.Dispose()

            frmDontForget._crdCard1 = Nothing
            frmDontForget._crdCard2 = Nothing
            If frmDontForget._intTotalCards = 0 Then
                frmDontForget._blnGameInProgress = False
            End If
        Else
            crdCard1._Cover.Visible = True

            frmDontForget._crdCard1 = frmDontForget._crdCard2
            frmDontForget._crdCard2 = Nothing
        End If
    End Sub
End Class
