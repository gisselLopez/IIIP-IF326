
Imports System.Text.RegularExpressions

Imports System.Data.SqlClient
Public Class FrmUsuario
    Dim conexion As New Conexion()
    Dim DT As New DataTable
    Public ds As DataSet = New DataSet()
    Public dr As SqlDataReader




    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()

    End Sub
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z09-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUsername.Clear()
        txtCorreo.Clear()
        txtPsw.Clear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuario()

            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.conexion.Close()

        End If


    End Sub
    Private Sub insertarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, pws, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUsername.Text
        pws = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, nombre, apellido, userName, pws, rol, estado, correo) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String
        idUsuario = txtCodigo.Text
        rol = cmbRol.Text
        Try
            If (conexion.eliminarUsuario(idUsuario, rol)) Then
                MsgBox("Dado de baja")

            Else
                MsgBox("Error al dar de baja usuario")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub modificarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, pws, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUsername.Text
        pws = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.modificarUsuario(idUsuario, nombre, apellido, userName, pws, rol, estado, correo) Then
                MessageBox.Show("El Usuario a sido Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al modificar usuario", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BuscarUsuario()
        Dim Username As String
        Username = txtUsername.Text
        Try

            DT = conexion.BuscarUsuario(Username)
            If DT.Rows.Count <> 0 Then
                MessageBox.Show("Usuario ha sido encontrado ", "Buscando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DGV.DataSource = DT
                txtUsername.Text = ""
            Else
                MessageBox.Show("El Usuario no ha sido  encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DGV.DataSource = Nothing
                txtUsername.Text = ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuario()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuario()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarUsuario()

    End Sub
    Private Sub btnDesencriptar_Click(sender As Object, e As EventArgs) Handles btnDesencriptar.Click
        txtResultado.Text = Eramake.eCryptography.Decrypt(txtModificado.Text)
    End Sub

    Private Sub btnEncriptar_Click(sender As Object, e As EventArgs) Handles btnEncriptar.Click
        txtModificado.Text = Eramake.eCryptography.Encrypt(txtPsw.Text)
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick


    End Sub
    Function cambiar(ByVal cambiartext As String) As String
        Dim A As String = StrConv(cambiartext, VbStrConv.ProperCase)
        Return A
    End Function
    Private Sub OrdenarPalabras()
        Me.txtApellido.Text = cambiar(Me.txtApellido.Text)
        Me.txtNombre.Text = cambiar(Me.txtNombre.Text)

    End Sub

    Private Sub Minuscula()
        Dim minuscula As String
        minuscula = LCase(txtCorreo.Text)
        txtCorreo.Text = minuscula
    End Sub


    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        OrdenarPalabras()
        Minuscula()
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged


        'Obtén el número de la fila que se seleccionó en el Datagridview
        Dim FilaActual As Integer
        FilaActual = DGV.CurrentRow.Index

        txtCodigo.Text = DGV.Rows(FilaActual).Cells(0).Value
        txtNombre.Text = DGV.Rows(FilaActual).Cells(1).Value
        txtApellido.Text = DGV.Rows(FilaActual).Cells(2).Value
        txtPsw.Text = DGV.Rows(FilaActual).Cells(3).Value
        cmbRol.Text = DGV.Rows(FilaActual).Cells(4).Value
        txtUsername.Text = DGV.Rows(FilaActual).Cells(5).Value
        txtCorreo.Text = DGV.Rows(FilaActual).Cells(6).Value
    End Sub
End Class
