//var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
//var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let salario = Number(lines[0]);


if (salario <= 2000) {
    console.log("Isento");
}
else if (salario > 2000 && salario <= 3000) {
    let salariof = (salario - 2000) * 0.08;
    console.log("R$ " + salariof.toFixed(2));
}
else if (salario > 3000 && salario <= 4500) {
    let salariof = (salario - 3000) * 0.18 + 80;
    console.log("R$ " + salariof.toFixed(2));
}
else {
    let salariof = (salario - 4500) * 0.28 + 80 + 270;
    console.log("R$ " + salariof.toFixed(2));
}