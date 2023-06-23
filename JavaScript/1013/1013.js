// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let a = Number(lines[0].split(" ")[0]);
let b = Number(lines[0].split(" ")[1]);
let c = Number(lines[0].split(" ")[2]);


let maiorAB = (a + b + Math.abs(a - b)) / 2;
let maiorAC = (maiorAB + c + Math.abs(c - maiorAB)) / 2;

let maior = Math.max(maiorAB, maiorAC);

console.log(maior + " eh o maior");