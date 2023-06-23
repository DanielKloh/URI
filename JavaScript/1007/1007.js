// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let valor1 = lines[0];
let valor2 = lines[1];
let valor3 = lines[2];
let valor4 = lines[3];

let difereca = (valor1 * valor2 - valor3 * valor4);

console.log("DIFERENCA = " + difereca);