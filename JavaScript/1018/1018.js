// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let valor = lines[0];
let n = valor;
let cem = 0;
let cinquenta = 0;
let vinte = 0;
let dez = 0;
let cinco = 0;
let dois = 0;
let um = 0;
let resto = 0;

cem = valor / 100;
// 76
resto = valor % 100;
valor = resto;

// 1
cinquenta = resto / 50;

//26      76/50
resto = resto % 50;
valor = resto;
// 1 
vinte = resto / 20;
valor = resto;
// 6 
resto = resto % 20;

// 0
dez = resto / 10;
valor = resto;

//      6 / 10         
resto = resto % 10;

// 1
cinco = valor / 5;

resto = resto % 5;
valor = resto;


dois = valor / 2;
resto = resto % 2;
valor = resto;



um = valor / 1;
resto = resto % 1;


console.log(Math.trunc(n));
console.log(Math.trunc(cem) + " nota(s) de R$ 100,00");
console.log(Math.trunc(cinquenta) + " nota(s) de R$ 50,00");
console.log(Math.trunc(vinte) + " nota(s) de R$ 20,00");
console.log(Math.trunc(dez) + " nota(s) de R$ 10,00");
console.log(Math.trunc(cinco) + " nota(s) de R$ 5,00");
console.log(Math.trunc(dois) + " nota(s) de R$ 2,00");
console.log(Math.trunc(um) + " nota(s) de R$ 1,00");