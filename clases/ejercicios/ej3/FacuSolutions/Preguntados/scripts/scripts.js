function randomQuestion() {

    $('main').empty();
    let round = 1;
    let score = 0;
    let shownAnswers = '';
    gameFunction(round, score, shownAnswers);

}

function gameFunction(round, score, shownAnswers) {
    
        $('main').empty();

        let x = (Math.floor((Math.random() * 18) + 1)).toString();

        if(shownAnswers.toString().indexOf(x) == -1) {
            switch(x) {
                case "1":
                    categoryIcon = '<i class="fas fa-globe-americas"></i>';
                    question = '<h2>¿Cuál es la capital de Sudáfrica?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Ciudad del Cabo</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Bloemfontein</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Pretoria</button>';
                    respuesta4 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Todas las anteriores</button>';                
                break;
                case "2":
                    categoryIcon = '<i class="fas fa-flask"></i>';
                    question = '<h2>¿Cuál de las sisguientes enfermedades ataca al higado?</h2>';
                    respuesta1 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Hepatitis</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Diabetes</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Artrósis</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Cifoescoliosis</button>';
                    
                break;
                case "3":
                    categoryIcon = '<i class="fas fa-theater-masks"></i>';
                    question = '<h2>¿Cuántos hijos/as tuvieron Homero y Marge Simpson?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">2</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">3</button>';
                    respuesta3 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">4</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">5</button>';
                    
                break;
                case "4":
                    categoryIcon = '<i class="fas fa-landmark"></i>';
                    question = '<h2>¿Cómo murió Eva Perón?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Muerte súbita</button>';
                    respuesta2 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Enfermedad</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Suicidio</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Asesinato</button>';
                    
                break;
                case "5":
                    categoryIcon = '<i class="fas fa-palette"></i>';
                    question = '<h2>¿Quién pintó la Mona Lisa?</h2>';
                    respuesta1 = '<button onclick="answer(true, ' + score + ',' + round + ',' + x + ',\'' + shownAnswers + '\')">Leonardo Da Vinci</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Pablo Picasso</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Vincent van Gogh</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Salvador Dalí</button>';
                    
                break;
                case "6":
                    categoryIcon = '<i class="fas fa-futbol"></i>';
                    question = '<h2>¿Quién ganó el mundial de 1978?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Alemania</button>';
                    respuesta2 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Argentina</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Holanda</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Brazil</button>';
                break;
                case "7":
                    categoryIcon = '<i class="fas fa-globe-americas"></i>';
                    question = '<h2>¿Cuántos países hay en el mundo?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">189</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">192</button>';
                    respuesta3 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">196</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">214</button>';                
                break;
                case "8":
                    categoryIcon = '<i class="fas fa-globe-americas"></i>';
                    question = '<h2>¿Cuál de estas ciudades no se encuentra en Europa?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Praga</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Barcelona</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Reykjavik</button>';
                    respuesta4 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Estambul</button>';                
                break;
                case "9":
                    categoryIcon = '<i class="fas fa-flask"></i>';
                    question = '<h2>¿De donde de saca la sacarina?</h2>';
                    respuesta1 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Del carbón</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Del azúcar</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Del aceite de girasol</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Del azufre</button>';                
                break;
                case "10":
                    categoryIcon = '<i class="fas fa-flask"></i>';
                    question = '<h2>¿Qué estudia la icitología?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Los insectos</button>';
                    respuesta2 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Los peces</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Las rocas</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Las erupciones cutáneas</button>';                
                break;
                case "11":
                    categoryIcon = '<i class="fas fa-theater-masks"></i>';
                    question = '<h2>¿Qué personaje de Disney perdió su zapato de cristal?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Tiana</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Blancanieves</button>';
                    respuesta3 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Cenicienta</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">La Sirenita</button>';                
                break;
                case "12":
                    categoryIcon = '<i class="fas fa-theater-masks"></i>';
                    question = '<h2>¿Quién es la mascota de SEGA?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Ryu</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Mario</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Pac Man</button>';
                    respuesta4 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Sonic</button>';                
                break;
                case "13":
                    categoryIcon = '<i class="fas fa-landmark"></i>';
                    question = '<h2>¿Dónde surgió la filosofía?</h2>';
                    respuesta1 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Grecia</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">España</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Egipto</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Japón</button>';                
                break;
                case "14":
                    categoryIcon = '<i class="fas fa-landmark"></i>';
                    question = '<h2>¿Cuántos soldados argentinos murieron en la Guerra de las Malvinas?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">200</button>';
                    respuesta2 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">649</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">987</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">1452</button>';                
                break;
                case "15":
                    categoryIcon = '<i class="fas fa-palette"></i>';
                    question = '<h2>¿Qué odia Mafalda?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">El Pájaro Loco</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Los panqueques</button>';
                    respuesta3 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">La sopa</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">A Manolito</button>';                
                break;
                case "16":
                    categoryIcon = '<i class="fas fa-palette"></i>';
                    question = '<h2>¿Quién compuso la famosa canción "Bohemian Rhapsody?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">John Lennon</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">David Bowie</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Elton John</button>';
                    respuesta4 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Freeddi Mercury</button>';                
                break;
                case "17":
                    categoryIcon = '<i class="fas fa-futbol"></i>';
                    question = '<h2>¿Cómo se llama el estadio del FCBarcelona?</h2>';
                    respuesta1 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">Camp Nou</button>';
                    respuesta2 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Santiago Bernabeu</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">La Masia</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">Barcelona Camp</button>';                
                break;
                case "18":
                    categoryIcon = '<i class="fas fa-futbol"></i>';
                    question = '<h2>¿Cuántos cuadros tiene un tablero de ajedres?</h2>';
                    respuesta1 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ', \'' + shownAnswers + '\')">128</button>';
                    respuesta2 = '<button onclick="answer(true, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">64</button>';
                    respuesta3 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">76</button>';
                    respuesta4 = '<button onclick="answer(false, ' + score + ', ' + round + ',' + x + ',\'' + shownAnswers + '\')">32</button>';                
                break;
            }
    
            // Agrega el ícono de categoría
            $('main').append('<div id="category">' + categoryIcon + '</div>');
            // Agrega la pregunta
            $('main').append(question);
            // Agrega las posibles respuestas
            $('main').append(respuesta1);
            $('main').append(respuesta2);
            $('main').append(respuesta3);
            $('main').append(respuesta4);
            // Agrega el score
            $('#score').empty();
            $('#score').append(score);
            // Agrega el round
            $('#round').empty();
            $('#round').append(round);
            
        }
        else {
            let x = Math.floor((Math.random() * 6) + 1);
            gameFunction(round, score, shownAnswers);
        }
        
        
}

function answer(playerAnswer, score, round, x, shownAnswers) {
        
    shownAnswers += "" + x + "";
    if(playerAnswer == true) {
        $('main').append('<i class="fas fa-check-circle green answerResult"></i>');
        $('.green').hide().fadeIn(500);
        score = score + 20;
    }
    else {
        $('main').append('<i class="fas fa-times-circle red answerResult"></i>');
        $('.red').hide().fadeIn(500);
        score = score - 5;
    }

    round++;

    window.setTimeout(function() {
        if(round < 11) {
            gameFunction(round, score, shownAnswers);
        }
        else {
            $('main').empty();
            $('main').append('<h2 id="finalScore">Your final score is ' + score + '!</h2>');
            let stars = score/20;
            switch(true) {
                case stars< 1:
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 1 && stars < 2):
                    $('main').append('<i class="fas fa-star-half-alt gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 2 && stars < 3):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 3 && stars < 4):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star-half-alt gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 4 && stars < 5):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 5 && stars < 6):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star-half-alt gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 6 && stars < 7):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 7 && stars < 8):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star-half-alt gold"></i>');
                    $('main').append('<i class="far fa-star gold"></i>');
                break;
                case (stars >= 8 && stars < 9):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star"></i>');
                break;
                case (stars >= 9 && stars < 10):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star-half-alt gold"></i>');
                break;
                case (stars >= 10 && stars < 11):
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                    $('main').append('<i class="fas fa-star gold"></i>');
                break;
            }
        }
    }, 1000);
    
}