// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let horai = 0;
let minutoi = 0;
let horaf = 0;
let minutof = 0;
let totalh = 0;
let totalm = 0;

horai = Number(lines[0].split(" ")[0]);
minutoi = Number(lines[0].split(" ")[1]);
horaf = Number(lines[0].split(" ")[2]);
minutof = Number(lines[0].split(" ")[3]);


//horas

if (horai < horaf) {
    totalh = horaf - horai;
}
else {
    totalh = 24 + (horaf - horai);
}
if (horaf === horai) {
    totalh = 0;
}

//minutos
if (minutoi === minutof) {
    totalm = 0;
}
if (minutoi < minutof) {
    totalm = minutof - minutoi;
}
else {
    totalm = 60 + (minutof - minutoi);
    totalh -= 1;
    if (totalh < 0) {
        totalh = 23;
    }
}




//menos que uma hora
if (horai === horaf) {
    if (minutoi === minutof) {
        totalm = 0;
    }
    if (minutoi < minutof) {
        totalm = minutof - minutoi;
    }
    else {
        totalm = 60 + (minutof - minutoi);
    }
}

if (totalh === 1 && minutoi > minutof) {
    totalh -= 1;
}

//impreção de valores
if (horaf === horai && minutof === minutoi) {
    console.log("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
}
else {
    console.log("O JOGO DUROU " + totalh + " HORA(S) E " + totalm + " MINUTO(S)");
}
