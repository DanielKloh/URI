// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let tempo = Number(lines[0]);
let velocidadeMedia = Number(lines[1]);

let total = (tempo * velocidadeMedia)/12;

console.log(total.toFixed(3));