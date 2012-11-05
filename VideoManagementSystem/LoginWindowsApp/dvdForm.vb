Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class dvdForm

    Private dvdobj As DVD

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub dvdForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        objDVDList.Save()
        dgDVDList.DataSource = Nothing
        objDVDList.Clear()
        dvdobj = Nothing
    End Sub

    Private Sub dvdForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try


            objDVDList.Load("")

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        Try

            dvdobj = objDVDList.Item(idNumberTextBox.Text.Trim)

            If dvdobj Is Nothing Then
                MessageBox.Show("DVD Not Found")


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


                With dvdobj
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

                        Case MovieCategory.Action_Adventure

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Action_Adventure")

                        Case MovieCategory.Comedy

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Comedy")

                        Case MovieCategory.Drama

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Drama")

                        Case MovieCategory.Family_Kids

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Family_Kids")

                        Case MovieCategory.Horror

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Horror")

                        Case MovieCategory.Music

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Music")

                        Case MovieCategory.None

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("None")

                        Case MovieCategory.Romance

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Romance")

                        Case MovieCategory.SciFi_Fantasy

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Sci-Fi_Fantasy")

                        Case MovieCategory.Sports

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Sports")

                        Case MovieCategory.Western

                            Me.categoryComboBox.SelectedIndex = Me.categoryComboBox.FindStringExact("Western")

                    End Select

                    Select Case .Format

                        Case DVDFormat.BLUERAY_Disc

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("BLUE-RAY DISC")

                        Case DVDFormat.DVD

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("DVD")

                        Case DVDFormat.HDDVD

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("HD-DVD")

                        Case DVDFormat.None

                            Me.formatComboBox.SelectedIndex = Me.formatComboBox.FindStringExact("None")
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
            Dim enumCategory As MovieCategory
            Dim enumFormat As DVDFormat
            Dim enumStrLine As String


            enumStrLine = ratingComboBox.SelectedItem.ToString()
            If enumStrLine = "PG-13" Then
                enumStrLine = "PG13"

            ElseIf enumStrLine = "NC-17" Then
                enumStrLine = "NC17"
            End If
            enumRating = CType(System.Enum.Parse(GetType(Rating), enumStrLine), Rating)

            enumStrLine = categoryComboBox.SelectedItem.ToString()
            If enumStrLine = "Sci-Fi_Fantasy" Then
                enumStrLine = "SciFi_Fantasy"
            End If
            enumCategory = CType(System.Enum.Parse(GetType(MovieCategory), enumStrLine),  _
                MovieCategory)

            enumStrLine = formatComboBox.SelectedItem.ToString()
            If enumStrLine = "BLUE-RAY DISC" Then
                enumStrLine = "BLUERAY_Disc"
            ElseIf enumStrLine = "HD-DVD" Then
                enumStrLine = "HDDVD"
            End If
            enumFormat = CType(System.Enum.Parse(GetType(DVDFormat), enumStrLine), DVDFormat)


            objDVDList.Add(idNumberTextBox.Text.Trim, titleTextBox.Text.Trim, descriptionTextBox.Text.Trim, _
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

    Private Sub listAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listAllButton.Click
        Try
            'Optional- refresh the data grid 
            dgDVDList.Refresh()

            'Bind Custom Array Object to DataGrid 
            dgDVDList.DataSource = objDVDList.ToArray()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Try
            Dim bolResults As Boolean

            objDVDList.DeferredDelete(idNumberTextBox.Text.Trim)
            bolResults = objDVDList.Remove(idNumberTextBox.Text.Trim)

            If bolResults <> True Then
                MessageBox.Show("DVD Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Try
            Dim bolResults As Boolean

           
            Dim enumRating As Rating
            Dim enumCategory As MovieCategory
            Dim enumFormat As DVDFormat
            Dim enumStrLine As String


            enumStrLine = ratingComboBox.SelectedItem.ToString()
            If enumStrLine = "PG-13" Then
                enumStrLine = "PG13"

            ElseIf enumStrLine = "NC-17" Then
                enumStrLine = "NC17"
            End If
            enumRating = CType(System.Enum.Parse(GetType(Rating), enumStrLine), Rating)

            enumStrLine = categoryComboBox.SelectedItem.ToString()
            If enumStrLine = "Sci-Fi_Fantasy" Then
                enumStrLine = "SciFi_Fantasy"

            End If
            enumCategory = CType(System.Enum.Parse(GetType(MovieCategory), enumStrLine),  _
                MovieCategory)

            enumStrLine = formatComboBox.SelectedItem.ToString()
            If enumStrLine = "BLUE-RAY DISC" Then
                enumStrLine = "BLUERAY"
            ElseIf enumStrLine = "HD-DVD" Then
                enumStrLine = "HDDVD"
            End If
            enumFormat = CType(System.Enum.Parse(GetType(DVDFormat), enumStrLine), DVDFormat)


            bolResults = objDVDList.Edit(idNumberTextBox.Text.Trim, titleTextBox.Text.Trim, descriptionTextBox.Text.Trim, _
            enumRating, CDec(salePriceTextBox.Text), CDec(rentalRateTextBox.Text), CDec(lateFeeTextBox.Text), _
            enumCategory, enumFormat)


            If bolResults <> True Then
                MessageBox.Show("DVD Not Found")
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


            bolResults = objDVDList.Print(idNumberTextBox.Text.Trim)


            If bolResults <> True Then
                MessageBox.Show("DVD Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub printAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printAllButton.Click
        Try

            objDVDList.PrintAll()


        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

End Class