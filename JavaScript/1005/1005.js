// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let nota1 = lines[0];
let nota2 = lines[1];

nota1*=3.5;
nota2*=7.5;

let media =( nota1 + nota2) /11;
console.log("MEDIA = " + media.toFixed(5));  