var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('/n');

// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');



let diaComeco = Number(lines[0].split(" ")[1]);
let horaComeco = Number(lines[1].split(":")[0]);
let minComeco = Number(lines[1].split(":")[1]);
let segComeco = Number(lines[1].split(":")[2]);
let diaFim = Number(lines[2].split(" ")[1]);
let horaFim = Number(lines[3].split(":")[0]);
let minFim = Number(lines[3].split(":")[1]);
let segFim = Number(lines[3].split(":")[2]);

let totalMin = 0;
let totalSeg = 0;
let totalHora = 0;
let totalDia = 0;

let totalMinComeco = minComeco * 60;
let totalHoraComeco = horaComeco * 3600;
let totalDiaComeco = diaComeco * 86400;

let totalComeco = totalDiaComeco + totalHoraComeco + totalMinComeco + segComeco;


let totalMinFim = minFim * 60;
let totalHoraFim = horaFim * 3600;
let totalDiaFim = diaFim * 86400;

let totalFim = totalDiaFim + totalHoraFim + totalMinFim + segFim;

let total = totalFim - totalComeco;

if (total % 86400 >= 0) {
    totalDia = Math.trunc(total / 86400);
    total %= 86400;
}

if (total % 3600 >= 0) {
    totalHora = Math.trunc(total / 3600);
    total %= 3600;
}


totalMin = Math.trunc(total / 60);
total %= 60;


totalSeg = total;



console.log(totalDia + " dia(s)");
console.log(totalHora + " hora(s)");
console.log(totalMin + " minuto(s)");
console.log(totalSeg + " segundo(s)");