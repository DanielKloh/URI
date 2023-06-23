var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('/n');

var A = lines[0];
var B = lines[1];

var soma = Number(A) + Number(B);

console.log(`X = ${soma} ${lines}`);




//Resolucao do exercicio
var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

var A = lines[0];
var B = lines[1];

var soma = Number(A) + Number(B);

console.log("X = " + soma);