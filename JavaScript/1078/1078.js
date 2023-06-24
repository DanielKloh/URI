// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let entrada = Number(lines[0]);

for (let i = 1; i <= 10; i++) {
    console.log(i + " x " + entrada +" = " + entrada*i);
}