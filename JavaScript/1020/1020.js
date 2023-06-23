// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let idade = Number(lines[0]);

let anos;
let mes;
let dias;
let resto;


anos = idade / 365;
resto = idade % 365;
mes = resto / 30;
dias = resto % 30;

console.log(Math.trunc(anos) + " ano(s)");
console.log(Math.trunc(mes) + " mes(es)");
console.log(Math.trunc(dias) + " dia(s)");
