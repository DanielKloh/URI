//var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
//var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');



let valorPositivo = 0;

for (let i = 0; i < 6; i++) {
    let entrada = Number(lines[i]);
    if(entrada > 0){
        valorPositivo += 1;
    }
}

console.log(valorPositivo + " valores positivos");