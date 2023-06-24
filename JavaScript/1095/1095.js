// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

const { format } = require('path');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let paramentro = 60;
let count = 1;

do {
    console.log("I="+ count +" J="+paramentro);
    count += 3;
    paramentro -= 5;
} while (paramentro!==-5);