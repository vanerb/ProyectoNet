﻿Imports System.Data.SqlClient
Public Class VerUsuarios


    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Vaciar()
        PanelUserInfo.Visible = True
        btsave.Visible = True
        btsaveas.Visible = False
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        PanelUserInfo.Visible = False
    End Sub

    Private Sub VerUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelUserInfo.Visible = False
        btsave.Visible = False
        btsaveas.Visible = False
        Mostrar()

    End Sub

    Private Sub btsaveas_Click(sender As Object, e As EventArgs) Handles btsaveas.Click

        Try


            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("editar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iduser", lbiduser.Text)
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@usuario", tbUser.Text)
            cmd.Parameters.AddWithValue("@passworduser", tbPass.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            PanelUserInfo.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try

    End Sub





    Private Sub datagrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellContentDoubleClick
        Try
            Vaciar()
            btsave.Visible = False
            btsaveas.Visible = True
            PanelUserInfo.Visible = True
            tbName.Text = datagrid.SelectedCells.Item(2).Value
            tbUser.Text = datagrid.SelectedCells.Item(3).Value
            tbPass.Text = datagrid.SelectedCells.Item(4).Value
            lbiduser.Text = datagrid.SelectedCells.Item(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@usuario", tbUser.Text)
            cmd.Parameters.AddWithValue("@password", tbPass.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            PanelUserInfo.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub datagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellClick
        If e.ColumnIndex = Me.datagrid.Columns.Item("bteliminar").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente estás seguro de que quieres eliminar este elemento?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("eliminar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@iduser", datagrid.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    cerrar()
                    Mostrar()
                Catch ex As Exception

                End Try

            End If

        End If



    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        buscar()
    End Sub

    Private Sub tbbuscar_TextChanged(sender As Object, e As EventArgs) Handles tbbuscar.TextChanged
        buscar()
    End Sub

    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Try
            abrir()
            da = New SqlDataAdapter("buscar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", tbbuscar.Text)

            da.Fill(dt)
            datagrid.DataSource = dt
            cerrar()
            Multilinea(datagrid)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub Vaciar()
        lbiduser.Text = ""
        tbName.Text = ""
        tbUser.Text = ""
        tbPass.Text = ""
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            datagrid.DataSource = dt
            cerrar()
            Multilinea(datagrid)

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class