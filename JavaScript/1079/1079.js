// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let parametro = Number(lines[0]);

let nota1 = 0;
let nota2 = 0;
let nota3 = 0;

for (let i = 1; i <= parametro; i++) {
    nota1 = Number(lines[i].split(" ")[0]);
    nota2 = Number(lines[i].split(" ")[1]);
    nota3 = Number(lines[i].split(" ")[2]);

    nota1 *= 2;
    nota2 *= 3;
    nota3 *= 5;

    let media = (nota1 + nota2 +nota3) / 10;

    console.log(media.toFixed(1));
}