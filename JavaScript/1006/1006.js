// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let nota1 = lines[0];
let nota2 = lines[1];
let nota3 = lines[2];


let media = ((nota1*2) + (nota2*3) + (nota3*5))/10;

console.log("MEDIA = "+media.toFixed(1));