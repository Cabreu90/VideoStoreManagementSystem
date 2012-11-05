Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class VideoGameForm

    Public objVideoGame As VideoGame

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub VideoGameForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        objVideoGameList.Save()
        dgVideoGameList.DataSource = Nothing
        objVideoGameList.Clear()
        objVideoGame = Nothing
    End Sub

    Private Sub VideoGameForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            objVideoGameList.Load("")

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        Try

            objVideoGame = objVideoGameList.Item(idNumberTextBox.Text.Trim)

            If objVideoGame Is Nothing Then
                MessageBox.Show("VideoGame Not Found")


                idNumberTextBox.Text = ""
                titleTextBox.Text = ""
                descriptionTextBox.Text = ""
                ratingComboBox.Text = ""
                salePriceTextBox.Text = ""
                rentalRateTextBox.Text = ""
                lateFeeTextBox.Text = ""
                categoryComboBox.Text = ""
                formatComboBox.Text = ""

                idNumberTextBox.Focus()
            Else


                With objVideoGame
                    idNumberTextBox.Text = .IDNumber
                    titleTextBox.Text = .Title
                    descriptionTextBox.Text = .Description
                    salePriceTextBox.Text = CStr(.SalePrice)
                    rentalRateTextBox.Text = CStr(.RentalRate)
                    lateFeeTextBox.Text = CStr(.LateFee)

                    Select Case .Rating

                        Case Rating.G

                            Me.ratingComboBox.SelectedIndex = Me.ratingComboBox.FindStringExact("G")

                        Case Rating.NC17

                            Me.ratingComboBox.SelectedIndex = Me.ratingComboBox.FindStringExact("NC-17")

                        Case Rating.NONE

                            Me.ratingComboBox.SelectedIndex = Me.ratingComboBox.FindStringExact("NONE")

                        Case Rating.PG

                            Me.ratingComboBox.SelectedIndex = Me.ratingComboBox.FindStringExact("PG")

                        Case Rating.PG13

                            Me.ratingComboBox.SelectedIndex = Me.ratingComboBox.FindStringExact("PG-13")

                        Case Rating.R

                            Me.ratingComboBox.SelectedIndex = Me.ratingComboBox.FindStringExact("R")

                    End Select

                    Select Case .Category

                        Case VideoGameCategory.Action

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Action")

                        Case VideoGameCategory.Fighting

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Fighting")

                        Case VideoGameCategory.FlightSimulators

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Flight Simulators")

                        Case VideoGameCategory.Horror

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Horror")

                        Case VideoGameCategory.None

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("None")

                        Case VideoGameCategory.Online

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Online")

                        Case VideoGameCategory.Racing

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Racing")

                        Case VideoGameCategory.Rhythm

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Rhythm")

                        Case VideoGameCategory.Roleplaying

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Roleplaying")

                        Case VideoGameCategory.Shooting

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Shooting")

                        Case VideoGameCategory.Sports

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Sports")

                        Case VideoGameCategory.Strategy

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Strategy")

                    End Select

                    Select Case .Format

                        Case VideoGameFormat.DS

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("DS")

                        Case VideoGameFormat.GameCube

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("GameCube")

                        Case VideoGameFormat.None

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("None")

                        Case VideoGameFormat.PC

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("PC")

                        Case VideoGameFormat.PS2

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("PS2")

                        Case VideoGameFormat.PS3

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("PS3")

                        Case VideoGameFormat.Wii

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("Wii")

                        Case VideoGameFormat.XBox

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("XBox")

                        Case VideoGameFormat.XBox360

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("XBox 360")
                    End Select

                End With
            End If


        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try

            Dim enumRating As Rating
            Dim enumCategory As VideoGameCategory
            Dim enumFormat As VideoGameFormat
            Dim enumStrLine As String


            enumStrLine = ratingComboBox.SelectedItem.ToString()
            If enumStrLine = "PG-13" Then
                enumStrLine = "PG13"

            ElseIf enumStrLine = "NC-17" Then
                enumStrLine = "NC17"
            End If
            enumRating = CType(System.Enum.Parse(GetType(Rating), enumStrLine), Rating)

            enumStrLine = categoryComboBox.SelectedItem.ToString()
            If enumStrLine = "Flight Simulators" Then
                enumStrLine = "FlightSimulators"
            End If
            enumCategory = CType(System.Enum.Parse(GetType(VideoGameCategory), enumStrLine),  _
                VideoGameCategory)

            enumStrLine = formatComboBox.SelectedItem.ToString()
            If enumStrLine = "XBox 360" Then
                enumStrLine = "XBox360"
            End If
            enumFormat = CType(System.Enum.Parse(GetType(VideoGameFormat), enumStrLine), VideoGameFormat)


            objVideoGameList.Add(idNumberTextBox.Text.Trim, titleTextBox.Text.Trim, descriptionTextBox.Text.Trim, _
            enumRating, CDec(salePriceTextBox.Text), CDec(rentalRateTextBox.Text), CDec(lateFeeTextBox.Text), _
            enumCategory, enumFormat)

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objY As ArgumentException

            MessageBox.Show(objY.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Try
            Dim bolResults As Boolean


            Dim enumRating As Rating
            Dim enumCategory As VideoGameCategory
            Dim enumFormat As VideoGameFormat
            Dim enumStrLine As String


            enumStrLine = ratingComboBox.SelectedItem.ToString()
            If enumStrLine = "PG-13" Then
                enumStrLine = "PG13"

            ElseIf enumStrLine = "NC-17" Then
                enumStrLine = "NC17"
            End If
            enumRating = CType(System.Enum.Parse(GetType(Rating), enumStrLine), Rating)

           enumStrLine = categoryComboBox.SelectedItem.ToString()
            If enumStrLine = "Flight Simulators" Then
                enumStrLine = "FlightSimulators"
            End If
            enumCategory = CType(System.Enum.Parse(GetType(VideoGameCategory), enumStrLine),  _
                VideoGameCategory)

            enumStrLine = formatComboBox.SelectedItem.ToString()
            If enumStrLine = "XBox 360" Then
                enumStrLine = "XBox360"
            End If
            enumFormat = CType(System.Enum.Parse(GetType(VideoGameFormat), enumStrLine), VideoGameFormat)


            bolResults = objVideoGameList.Edit(idNumberTextBox.Text.Trim, titleTextBox.Text.Trim, descriptionTextBox.Text.Trim, _
            enumRating, CDec(salePriceTextBox.Text), CDec(rentalRateTextBox.Text), CDec(lateFeeTextBox.Text), _
            enumCategory, enumFormat)


            If bolResults <> True Then
                MessageBox.Show("VideoGame Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Try
            Dim bolResults As Boolean
            objVideoGameList.DeferredDelete(idNumberTextBox.Text.Trim)
            bolResults = objVideoGameList.Remove(idNumberTextBox.Text.Trim)

            If bolResults <> True Then
                MessageBox.Show("VideoGame Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        Try
            Dim bolResults As Boolean


            bolResults = objVideoGameList.Print(idNumberTextBox.Text.Trim)


            If bolResults <> True Then
                MessageBox.Show("VideoGame Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub printAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printAllButton.Click
        Try

            objVideoGameList.PrintAll()


        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub listAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listAllButton.Click
        Try
            'Optional- refresh the data grid 
            dgVideoGameList.Refresh()

            'Bind Custom Array Object to DataGrid 
            dgVideoGameList.DataSource = objVideoGameList.ToArray()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub
End Class