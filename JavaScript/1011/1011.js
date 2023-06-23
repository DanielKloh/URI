// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let raio = Number(lines[0]);

let calculo = ((4/3.0)*3.14159)*(raio*raio*raio)

console.log("VOLUME = " + calculo.toFixed(3));