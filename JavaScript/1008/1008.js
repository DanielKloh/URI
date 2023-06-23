// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let numero = Number(lines[0]);
let valorHora = Number(lines[1]);
let horas = Number(lines[2]);

let salario = valorHora * horas;

console.log("NUMBER = " + numero);
console.log("SALARY = U$ " + salario.toFixed(2));