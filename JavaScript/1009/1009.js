// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


var nome = lines[0];
var salario = Number(lines[1]);
var totalVendido = Number(lines[2]);

var total = Number(totalVendido*0.15 + salario);

console.log("TOTAL = R$ "+total.toFixed(2));