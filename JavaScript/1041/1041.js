//var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
//var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let x = Number(lines[0].split(" ")[0]);
let y = Number(lines[0].split(" ")[1]);

if (x > 0 && y > 0) {
    console.log("Q1");
}
if (x < 0 && y > 0) {
    console.log("Q2");
}
if (x < 0 && y < 0) {
    console.log("Q3");
}
if (x > 0 && y < 0) {
    console.log("Q4");
}
if (x === 0 && y === 0) {
    console.log("Origem");
}
if (x === 0 && y !== 0) {
    console.log("Eixo Y");
}
if (x !== 0 && y === 0) {
    console.log("Eixo X");
}