var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('/n');

// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');


let A = Number(lines[0].split(" ")[0]);
let B = Number(lines[0].split(" ")[1]);
let C = Number(lines[0].split(" ")[2]);
let D = Number(lines[0].split(" ")[3]);
// console.log(A+" " + B +" "+ C +" " +D);

let soma1 = C + D;
let soma2 = A + B;

if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && A%2 === 0) {
    console.log("Valores aceitos");
}
else {
    console.log("Valores nao aceitos");
}