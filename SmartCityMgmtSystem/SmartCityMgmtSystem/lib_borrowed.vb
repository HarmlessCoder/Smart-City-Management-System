Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports SmartCityMgmtSystem.lib_dash
Public Class lib_borrowed
    Public Property uid As Integer = -1
    Public Property u_name As String = "Hello"

    Private Structure Entry
        Public BookID As Integer
        Public Author As String
        Public Title As String
        Public DueDate As String
        Public RadioButton As RadioButton ' Added RadioButton field
    End Structure

    Dim borrowedBooks As New List(Of Entry)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lib_search = New lib_search() With {
            .uid = uid,
            .u_name = u_name
        }
        lib_search.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lib_ebooks = New lib_ebooks() With {
            .uid = uid,
            .u_name = u_name
        }
        lib_ebooks.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim lib_dash = New lib_dash() With {
            .uid = uid,
            .u_name = u_name
        }
        lib_dash.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lib_request = New lib_request() With {
            .uid = uid,
            .u_name = u_name
        }
        lib_request.Show()
        Me.Close()
    End Sub

    Private Sub lib_borrowed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = u_name
        LoadBorrowedBooks()
        PopulateTable()
    End Sub

    Private Sub LoadBorrowedBooks()
        borrowedBooks.Clear()
        Dim query As String = "SELECT bb.book_ID, b.author, b.title, bb.dueDate FROM lib_borrowed_books bb INNER JOIN lib_books  b ON bb.book_ID = b.book_ID WHERE bb.issuedTo = '" & uid & "'"

        Dim Con = Globals.GetDBConnection()

        Try
            Con.Open()
            Dim cmd As New MySqlCommand(query, Con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                borrowedBooks.Add(New Entry With {
                .BookID = reader("book_ID").ToString(),
                .Author = reader("author").ToString(),
                .Title = reader("title").ToString(),
                .DueDate = reader("dueDate").ToString(),
                .RadioButton = New RadioButton()
            })
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close() ' Close the connection in the finally block to ensure it's closed even if an exception occurs
            End If
        End Try
    End Sub

    Private Sub PopulateTable()
        borrowedBooksTablePanel.Controls.Clear()

        For rowIndex As Integer = 0 To borrowedBooks.Count - 1
            Dim entry As Entry = borrowedBooks(rowIndex)
            borrowedBooksTablePanel.RowStyles(rowIndex).SizeType = SizeType.Absolute
            borrowedBooksTablePanel.RowStyles(rowIndex).Height = 50

            ' Add book details
            Dim bookIdLabel As New Label()
            bookIdLabel.Text = entry.BookID.ToString()
            bookIdLabel.Font = New Font(bookIdLabel.Font.FontFamily, 13) ' Set font size
            bookIdLabel.ForeColor = Color.Black ' Set font color to black
            borrowedBooksTablePanel.Controls.Add(bookIdLabel, 0, rowIndex)
            bookIdLabel.TextAlign = ContentAlignment.MiddleCenter ' Center the label
            bookIdLabel.Anchor = AnchorStyles.None ' Set Anchor to None

            Dim authorLabel As New Label()
            authorLabel.Text = entry.Author
            authorLabel.Width = 200 ' Adjust width as needed
            authorLabel.Font = New Font(authorLabel.Font.FontFamily, 13) ' Set font size
            authorLabel.ForeColor = Color.Black ' Set font color to black
            borrowedBooksTablePanel.Controls.Add(authorLabel, 1, rowIndex)
            authorLabel.TextAlign = ContentAlignment.MiddleCenter ' Center the label
            authorLabel.Anchor = AnchorStyles.None ' Set Anchor to None

            Dim titleLabel As New Label()
            titleLabel.Text = entry.Title
            titleLabel.AutoSize = True
            titleLabel.Font = New Font(titleLabel.Font.FontFamily, 13) ' Set font size
            titleLabel.ForeColor = Color.Black ' Set font color to black
            borrowedBooksTablePanel.Controls.Add(titleLabel, 2, rowIndex)
            titleLabel.TextAlign = ContentAlignment.MiddleCenter ' Center the label
            titleLabel.Anchor = AnchorStyles.None ' Set Anchor to None

            Dim dueDateLabel As New Label()
            dueDateLabel.Text = entry.DueDate
            dueDateLabel.Font = New Font(dueDateLabel.Font.FontFamily, 13) ' Set font size
            dueDateLabel.ForeColor = Color.Black ' Set font color to black
            borrowedBooksTablePanel.Controls.Add(dueDateLabel, 3, rowIndex)
            dueDateLabel.TextAlign = ContentAlignment.MiddleCenter ' Center the label
            dueDateLabel.Anchor = AnchorStyles.None ' Set Anchor to None

            ' Add radio button for options
            borrowedBooksTablePanel.Controls.Add(entry.RadioButton, 4, rowIndex)
            entry.RadioButton.TextAlign = ContentAlignment.MiddleCenter ' Center the radio button
            entry.RadioButton.Anchor = AnchorStyles.None ' Set Anchor to None
            entry.RadioButton.Size = New Size(16, 16) ' Set the size of the radio button
        Next

        Dim adjustLabel2 As New Label()
        adjustLabel2.Text = ""
        borrowedBooksTablePanel.Controls.Add(adjustLabel2, 1, borrowedBooks.Count)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim HomePageDashboard = New HomePageDashboard() With {
            .uid = uid
        }
        HomePageDashboard.Show()
        Me.Close()
    End Sub
End Class