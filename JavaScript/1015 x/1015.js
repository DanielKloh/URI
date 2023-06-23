// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let numero1 = Number(lines[0].split(" ")[0]);
let numero2 = Number(lines[0].split(" ")[1]);
let numero3 = Number(lines[1].split(" ")[0]);
let numero4 = Number(lines[1].split(" ")[1]);


let distancia = (Math.sqrt(Math.pow((numero2 - numero1), 2) + Math.pow((numero4 - numero3), 2)));

console.log(distancia.toFixed(4));