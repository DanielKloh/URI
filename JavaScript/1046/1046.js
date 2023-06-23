// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let hi = 0; let hf = 0; let horaf = 0;
hi = Number(lines[0].split(" ")[0]);
hf = Number(lines[0].split(" ")[1]);

if (hi < hf) {
    horaf = hf - hi;
}
else {
    horaf = 24 - hi + hf;
}
console.log("O JOGO DUROU " + horaf + " HORA(S)");