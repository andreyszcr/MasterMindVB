Public Class frmjuego
    Private Sub Mstsalir_Click(sender As Object, e As EventArgs) Handles mstsalir.Click
        'condicion donde mostrar un mensaje que indica si desea salir del juego 
        If MsgBox("¿Desea salir del juego?", vbAbort + vbQuestion) = vbYes Then
            'accion para cerrar 
            Me.Close()
        End If
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstinicio.Click
        'comienza el tiempo del juego 
        timejuego.Start()

        'variable para agregar el color de las casillas de la maquina 

        'creamos una variable tipo color el cual dara los colores de forma aleatoria 

        ' se coloca el randomize que muestre los colores de forma aleatoria


    End Sub


    Private Sub Mstpausa_Click(sender As Object, e As EventArgs) Handles mstpausa.Click
        'tiempo del eugo que esta detenido 
        timejuego.Stop()

        'colocamos un mensaje que muestra un mensaje de pausa 
        ' se crea una condicion cuando el juego esta en pausa muestra un mensaje 
        If MsgBox("juego en pausa,presione Ok para continuar el juego", vbQuestion, "juego en pausa") = vbOK Then
            timejuego.Start()
        End If
    End Sub

    Private Sub Mstacercade_Click(sender As Object, e As EventArgs) Handles mstacercade.Click
        Dim pantalla As New frmautores

        With pantalla
            .MdiParent = Me

            .Show()

        End With
    End Sub

    Private Sub Timejuego_Tick(sender As Object, e As EventArgs) Handles timejuego.Tick
        'se coloca el tiempo que se va a dar 
        'que milisegundo vaya aumentado de uno en 1 
        lblmnsegundo.Text += 1
        '-------------------------------------------------------------------
        'si los milisegundos llegan a 60 entonces 
        If lblmnsegundo.Text = "60" Then
            'termina de hacer los milisegundos y empieza los segundos 
            lblsegundo.Text += 1
            'milisegundos  inicializan en 00 
            lblmnsegundo.Text = "00"
        End If
        '------------------------------------------------------------------------
        'si los segunos llegan a 60 entonces 
        If lblsegundo.Text = "60" Then
            'aumenta los segudnos de uno en uno 
            lblminuto.Text += 1
            'los  segundos inicializan  en 00
            lblsegundo.Text = "00"
        End If
        '----------------------------------------------------------------------------
        'si los minutos llegan a 60 entonces 
        If lblminuto.Text = "60" Then
            'aumenta la hora de uno en uno 
            lblhora.Text += 1
            'los minutos se igualan a 00
            lblminuto.Text = "00"
        End If
    End Sub

    Private Sub Mstreiniciar_Click(sender As Object, e As EventArgs) Handles mstreiniciar.Click
        If MsgBox("Desea Reiniciar ?", vbAbort + vbQuestion, "reinicar juego") = vbYes Then
            timejuego.Stop()
            lblmnsegundo.Text = "00"
            lblsegundo.Text = "00"
            lblminuto.Text = "00"
            lblhora.Text = "00"

            btnescolor1.BackColor = Color.DimGray
            btnescolor2.BackColor = Color.DimGray
            btnescolor3.BackColor = Color.DimGray
            btnescolor4.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub Frmjuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' se coloca el color en gris el cual se colocara el color a escoger 
        btnescolor1.BackColor = Color.DimGray
        btnescolor2.BackColor = Color.DimGray
        btnescolor3.BackColor = Color.DimGray
        btnescolor4.BackColor = Color.DimGray




    End Sub

    Private Sub Btnazul_Click(sender As Object, e As EventArgs) Handles btnazul.Click
        ' se crean condiciones para color azul en el botton 1
        If btnescolor1.BackColor = Color.DimGray Then
            ' colocas el color azul en el boton 1
            btnescolor1.BackColor = Color.Blue

            'condicion en el boton 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            ' colocas el color azul en el boton 2
            btnescolor2.BackColor = Color.Blue

            'condicion  en el boton 3 
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'colocas el color azul en el boton 3
            btnescolor3.BackColor = Color.Blue

            'condicion en boton 4
        ElseIf btnescolor4.BackColor = Color.DimGray Then

            'se coloca el color azul en el boton 4  
            btnescolor4.BackColor = Color.Blue
        End If
        '---------------------------------------------------------------------------------------


    End Sub

    Private Sub Btnrojo_Click(sender As Object, e As EventArgs) Handles btnrojo.Click
        'se crean condicion para color rojo en el button 1
        If btnescolor1.BackColor = Color.DimGray Then
            ' se coloca el color rojo en el boton 1
            btnescolor1.BackColor = Color.Red

            'condicion en el boton 2 
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            ' se coloca el color rojo en el boton 2
            btnescolor2.BackColor = Color.Red

            'condicion de color rojo en el boton  3
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se coloca el rojo en el boton 3 
            btnescolor3.BackColor = Color.Red

            ' condicion de color en el boton 4  
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'se coloca el color roo en el boton 4
            btnescolor4.BackColor = Color.Red
        End If
        '-------------------------------------------------------------------------------


    End Sub

    Private Sub Btnverde_Click(sender As Object, e As EventArgs) Handles btnverde.Click

        'se crean condciones  para el color verde en el button 1
        If btnescolor1.BackColor = Color.DimGray Then
            ' se colocan el verde en el boton 1
            btnescolor1.BackColor = Color.Green

            'se crean condiciones para el color verde en el  button 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            'se colocan el  verde en el boton 2
            btnescolor2.BackColor = Color.Green

            'se crean condiciones para el color verde en el boton 3
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se colocan el verde en el boton 3
            btnescolor3.BackColor = Color.Green

            'se crean condiciones para el color verde en el boton4 
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'se coloca el verde en el boton 4
            btnescolor4.BackColor = Color.Green
        End If

    End Sub

    Private Sub Btnamarillo_Click(sender As Object, e As EventArgs) Handles btnamarillo.Click
        'se crean condiciones en el boton 1
        If btnescolor1.BackColor = Color.DimGray Then
            'se coloca el amarillo en el boton 1
            btnescolor1.BackColor = Color.Yellow

            'se condicion en el boton 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            'se coloca el amarillo en el boton 2
            btnescolor2.BackColor = Color.Yellow

            'condicion el amarillos en el boton 3 
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se coloca el amarillo en el boton 3 
            btnescolor3.BackColor = Color.Yellow

            'condicion el amarillo en el boton 4  
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'coloca el amarillo en el boton 4
            btnescolor4.BackColor = Color.Yellow
        End If

        '-------------------------------------------------------------------------------


    End Sub

    Private Sub Btnnaranja_Click(sender As Object, e As EventArgs) Handles btnnaranja.Click

        'condicion del boton 1 para color naranja
        If btnescolor1.BackColor = Color.DimGray Then
            'se coloca el color naranja en el boton 1
            btnescolor1.BackColor = Color.Orange

            'condicion el naranja en el boton 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            'se coloca el naranja en el boton 2
            btnescolor2.BackColor = Color.Orange

            'condicion el naranja en el boton 3 
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se coloca el naranja en el boton 3 
            btnescolor3.BackColor = Color.Orange

            'condicion el naranja en el boton 4  
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'coloca el naranja en el boton 4
            btnescolor4.BackColor = Color.Orange
        End If

        '-------------------------------------------------------------------------------

    End Sub

    Private Sub Btnmorado_Click(sender As Object, e As EventArgs) Handles btnmorado.Click


        'condicion del boton 1 para color morado
        If btnescolor1.BackColor = Color.DimGray Then
            'se coloca el color morado en el boton 1
            btnescolor1.BackColor = Color.Purple

            'condicion el morado en el boton 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            'se coloca el morado en el boton 2
            btnescolor2.BackColor = Color.Purple

            'condicion elmorado en el boton 3 
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se coloca el morado en el boton 3 
            btnescolor3.BackColor = Color.Purple

            'condicion el morado en el boton 4  
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'coloca el morado en el boton 4
            btnescolor4.BackColor = Color.Purple
        End If

        '-------------------------------------------------------------------------------

    End Sub

    Private Sub Btnrosado_Click(sender As Object, e As EventArgs) Handles btnrosado.Click
        'condicion del boton 1 para color rosado
        If btnescolor1.BackColor = Color.DimGray Then
            'se coloca el color rosado  en el boton 1
            btnescolor1.BackColor = Color.Pink

            'condicion el rosado en el boton 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            'se coloca el rosado en el boton 2
            btnescolor2.BackColor = Color.Pink

            'condicion el rosado en el boton 3 
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se coloca el rosado en el boton 3 
            btnescolor3.BackColor = Color.Pink

            'condicion el rosado en el boton 4  
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'coloca el rosado en el boton 4
            btnescolor4.BackColor = Color.Pink
        End If

        '-------------------------------------------------------------------------------


    End Sub

    Private Sub Btnceleste_Click(sender As Object, e As EventArgs) Handles btnceleste.Click

        'condicion del boton 1 para color celeste
        If btnescolor1.BackColor = Color.DimGray Then
            'se coloca el color celeste  en el boton 1
            btnescolor1.BackColor = Color.LightBlue

            'condicion el celeste en el boton 2
        ElseIf btnescolor2.BackColor = Color.DimGray Then
            'se coloca el celeste en el boton 2
            btnescolor2.BackColor = Color.LightBlue

            'condicion el celeste en el boton 3 
        ElseIf btnescolor3.BackColor = Color.DimGray Then
            'se coloca el rosado en el boton 3 
            btnescolor3.BackColor = Color.LightBlue

            'condicion el celeste en el boton 4  
        ElseIf btnescolor4.BackColor = Color.DimGray Then
            'coloca el celeste en el boton 4
            btnescolor4.BackColor = Color.LightBlue
        End If

        '-------------------------------------------------------------------------------

    End Sub

End Class
