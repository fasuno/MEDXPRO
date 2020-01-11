Imports System.Data.SqlClient

Module Connection
    Public ExecuteQuery As String
    Public query As String
    'Public update As String

    Public con As New SqlConnection("Data source = localhost; initial catalog=PROMEDDB; Integrated Security=true")
    Public cmd As New SqlClient.SqlCommand
    Public adapt As New SqlDataAdapter
    'Public Executequery As String
End Module
