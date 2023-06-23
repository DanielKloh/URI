var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let valor1 = Number(lines[0]);
let valor2 = Number(lines[1]);

let soma = valor1 + valor2;

console.log("SOMA = " + soma);