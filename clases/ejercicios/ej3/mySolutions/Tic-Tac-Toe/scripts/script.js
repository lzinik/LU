$(function () {
    console.log("Ready to go!");

    player = 'X';

    // La función de abajo se encarga de manejar todo lo que ocurre cuando un jugador hace click en uno de los cuadrados.
    $('.square').click(function() {
        let clickedSquare = $(this);

        if (clickedSquare.children().length > 0) {
            alert('That square has already been chosen...')
        } else {
            // Agrego la ficha del jugador correspondiente.
            clickedSquare.append('<p id="cross">' + player + '</p>');
            console.log('Clicked square number ' + clickedSquare.attr('id') + '!');
            // Al un jugador elegir un cuadrado, debo cambiar de jugador automáticamente para que juegue el oponente.
            togglePlayer();
            // Ahora que cambié el jugador, lo muestro en pantalla.
            turnDisplayerFunction();
            // Cada vez que se toca un square chequea si alguien ganó o no.
            didPlayerWin();
            didItEnd();
        }

    }); 

    // Muestra en pantalla el cambio de jugador.
    function turnDisplayerFunction() {
        $('#turnDisplayer').remove();
        $('#container').before("<h2 id='turnDisplayer'>It's " + player + "'s turn.</h2>");
    }

    // Alterna entre jugadores.
    function togglePlayer() {
        if(player == 'X') {
            player = 'O';
        } else {
            player = 'X';
        }
    };

    // Chequea si alguien ganó comparando columnas, filas y diagonales. Es horrible, pero tiene que chequear todas las posibilidades.
    // Si encuentran una manera más acotada de chequear todos los resultados show me.
    function didPlayerWin() {
        let winner = false;
        if ($('#one').html() == $('#two').html() && $('#one').html() == $('#three').html() && $('#one').children().length > 0) {
            alert($('#one').find('p').html() + ' has won!');
            winner = true;
        } else if($('#four').html() == $('#five').html() && $('#four') == $('#six').html() && $('#four').children().length > 0) {
            alert($('#four').find('p').html() + ' has won!');
            winner = true;
        } else if($('#seven').html() == $('#eight').html() && $('#seven').html() == $('#nine').html() && $('#seven').children().length > 0) {
            alert($('#seven').find('p').html() + ' has won!');
            winner = true;
        } else if($('#one').html() == $('#four').html() && $('#one').html() == $('#seven').html() && $('#one').children().length > 0) {
            alert($('#one').find('p').html() + ' has won!');
            winner = true;
        } else if($('#two').html() == $('#five').html() && $('#two').html() == $('#eight').html() && $('#two').children().length > 0) {
            alert($('#two').find('p').html() + ' has won!');
            winner = true;
        } else if($('#three').html() == $('#six').html() && $('#three').html() == $('#nine').html() && $('#three').children().length > 0) {
            alert($('#three').find('p').html() + ' has won!');
            winner = true;
        } else if($('#one').html() == $('#five').html() && $('#one').html() == $('#nine').html() && $('#one').children().length > 0) {
            alert($('#one').find('p').html() + ' has won!');
            winner = true;
        } else if($('#three').html() == $('#five').html() && $('#three').html() == $('#seven').html() && $('#three').children().length > 0) {
            alert($('#three').find('p').html() + ' has won!');
            winner = true;
        }

        // Esto último va a esperar 5 segundos una vez anunciado el ganador y va a refrescar la página para que el juegue comience de nuevo.
        if(winner) {
            setTimeout(function () {
                window.location.reload(1);
            }, 2000);
        }
    }
    
    // Chequea si ya no se pueden elegir cuadrados porque todos están llenos.
    function didItEnd() {
        // Esto horrible de acá abajo chequea que todos los cuadrados tengan un hijo. En caso de tenerlo, se llenaron todos los cuadrados y el juego debe terminar.
        if ($('#one').children().length > 0 && $('#two').children().length > 0 && $('#three').children().length > 0 && $('#four').children().length > 0
        && $('#five').children().length > 0 && $('#six').children().length > 0 && $('#seven').children().length > 0
        && $('#eight').children().length > 0 && $('#nine').children().length > 0) {
            alert('Nobody won...');
            setTimeout(function () {
                window.location.reload(1);
            }, 2000);
        }
    }

})