// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let distancia = Number(lines[0]);
let combustivel = Number(lines[1]);

let media = distancia / combustivel;


console.log(media.toFixed(3) +" km/l");