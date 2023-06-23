// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let numeroPar = 0;

for (let i = 0; i < 5; i++) {
    let entrada = Number(lines[i]);

    if(entrada%2 === 0){
        numeroPar ++;
    }
}

console.log(numeroPar + " valores pares");