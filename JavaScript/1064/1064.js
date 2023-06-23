// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let numeroPositivo = 0;
let meida = 0;

for (let i = 0; i < 6; i++) {

    let entrada = Number(lines[i]);

    if(entrada > 0){
        numeroPositivo += 1;
        meida += entrada;
    }
}

meida /= numeroPositivo;

console.log(numeroPositivo + " valores positivos");
console.log(meida.toFixed(1));