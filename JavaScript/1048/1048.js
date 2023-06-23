// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let persentual = 0;
let sal = Number(lines[0]);

if (sal <= 400) {
    persentual = 15.0;
} else if (sal <= 800) {
    persentual = 12.0;
}
else if (sal <= 1200) {
    persentual = 10.0;
}
else if (sal <= 2000) {
    persentual = 7.0;
}
else {
    persentual = 4.0;
}

let reajuste = sal * persentual / 100;
let novosal = sal + reajuste;

console.log("Novo salario: " + novosal.toFixed(2));
console.log("Reajuste ganho: " + reajuste.toFixed(2));
console.log("Em percentual: " + persentual + " %");


