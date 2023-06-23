// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let A = Number(lines[0].split(" ")[0]);
let B = Number(lines[0].split(" ")[1]);

if (A % B === 0 || B % A === 0) {
    console.log("Sao Multiplos");
}
else {
    console.log("Nao sao Multiplos");
}