﻿Imports System.Data.OleDb
Module mdlconfig
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader

    Sub koneksioDB()
        Try
            CONN = New OleDb.OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=data.accdb")
            CONN.Open()
            'MsgBox("DATA TERINPUT...")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
