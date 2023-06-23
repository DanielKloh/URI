var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');



let code1 = Number(lines[0].split(" ")[0]);
let qtd1 = Number(lines[0].split(" ")[1]);
let prec1 = Number(lines[0].split(" ")[2]);

let code2 = Number(lines[1].split(" ")[0]);
let qtd2 = Number(lines[1].split(" ")[1]);
let prec2 = Number(lines[1].split(" ")[2]);

let total = (qtd1 * prec1) + (qtd2 * prec2);
console.log("VALOR A PAGAR: R$ " + total.toFixed(2));