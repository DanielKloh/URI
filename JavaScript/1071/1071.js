// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let x = Number(lines[0]);
let y = Number(lines[1]);

let soma = 0;


if (x % 2 !== 0) {
    if (x > 0) {
        x -= 1;
    }
    else {
        x += 1;
    }
}
if (y % 2 !== 0) {
    if (y > 0) {
        y -= 1;
    }
    else {
        y += 1;
    }
}

if (x > y) {

    for (i = x; i > y; i--) {
        if (i % 2 !== 0) {
            soma += i;

        }
    } console.log(soma);
}
if (x < y) {
    for (i = x; i < y; i++) {
        if (i % 2 !== 0) {
            soma += i;

        }
    } console.log(soma);
}
if (x == y) {
    console.log("0");
}