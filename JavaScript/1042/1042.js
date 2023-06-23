 //var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
//var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let n1 = Number(lines[0].split(" ")[0]);
let n2 = Number(lines[0].split(" ")[1]);
let n3 = Number(lines[0].split(" ")[2]);

if (n1 < n2 && n1 < n3 && n2 < n3) {
    console.log(n1);
    console.log(n2);
    console.log(n3);
}
if (n1 < n2 && n1 < n3 && n3 < n2) {
    console.log(n1);
    console.log(n3);
    console.log(n2);
}

if (n2 < n1 && n2 < n3 && n1 < n3) {
    console.log(n2);
    console.log(n1);
    console.log(n3);
}
if (n2 < n1 && n2 < n3 && n3 < n1) {
    console.log(n2);
    console.log(n3);
    console.log(n1);
}

if (n3 < n2 && n3 < n1 && n2 < n1) {
    console.log(n3);
    console.log(n2);
    console.log(n1);
}
if (n3 < n2 && n3 < n1 && n1 < n2) {
    console.log(n3);
    console.log(n1);
    console.log(n2);
}

console.log();
console.log(n1);
console.log(n2);
console.log(n3);