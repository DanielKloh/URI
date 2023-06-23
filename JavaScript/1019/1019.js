// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let N = Number(lines[0]);
let hora = 0;
let min = 0;
let resto = 0;


hora=N/3600;
resto=N%3600;

min=resto/60;
seg=resto%60;

console.log(Math.trunc(hora)+":"+Math.trunc(min)+":"+Math.trunc(seg));