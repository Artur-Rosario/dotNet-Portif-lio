Public Class Form1

    Dim IntVezes As Integer
    Dim IntValor1 As Integer
    Dim IntValor2 As Integer
    Dim IntResultado As Integer
    Dim StrOperador As String = ""

    Private Sub Valor1_ValueChanged(sender As Object, e As EventArgs) Handles Valor1.ValueChanged
        IntValor1 = Valor1.Value
    End Sub

    Private Sub Valor2_ValueChanged(sender As Object, e As EventArgs) Handles Valor2.ValueChanged
        IntValor2 = Valor2.Value
    End Sub

    Private Sub BtnMais_Click(sender As Object, e As EventArgs) Handles BtnMais.Click
        StrOperador = "Soma"
    End Sub

    Private Sub BtnMenos_Click(sender As Object, e As EventArgs) Handles BtnMenos.Click
        StrOperador = "Subtrai"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StrOperador = "Multiplica"
    End Sub

    Private Sub BtnDivisao_Click(sender As Object, e As EventArgs) Handles BtnDivisao.Click
        StrOperador = "Divide"
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Select Case StrOperador
            Case "Soma"
                IntResultado = IntValor1 + IntValor2

            Case "Subtrai"
                IntResultado = IntValor1 - IntValor2

            Case "Multiplica"
                IntResultado = IntValor1 * IntValor2

            Case "Divide"
                IntResultado = IntValor1 / IntValor2
            Case ""

                Timer1.Enabled = True

                'BtnCalcular_Click()

        End Select

        TextBox1.Text = IntResultado
        StrOperador = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        If IntVezes <= 6 Then
            If Label6.Visible = True Then
                Label6.Visible = False
                IntVezes = IntVezes + 1
            Else
                Label6.Visible = True
                IntVezes = IntVezes + 1
            End If

        Else
            Label6.Visible = False

            Timer1.Enabled = False
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Valor1.Value = 0
        IntValor1 = 0

        Valor2.Value = 0
        IntValor2 = 0

        IntResultado = 0
        IntVezes = 0
        TextBox1.Text = ""

        StrOperador = ""
    End Sub
End Class
