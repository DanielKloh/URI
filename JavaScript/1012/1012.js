// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let A = Number(lines[0].split(" ")[0]);
let B = Number(lines[0].split(" ")[1]);
let C = Number(lines[0].split(" ")[2]);


triangulo = Number(A * C / 2.00);
circulo = Number(3.14159 * C * C);
trapezio = Number((A + B) / 2.00 * C);
quadrado = Number(B*B);
retangulo = Number(A * B);

console.log("TRIANGULO: " + triangulo.toFixed(3));
console.log("CIRCULO: " + circulo.toFixed(3));
console.log("TRAPEZIO: " + trapezio.toFixed(3));
console.log("QUADRADO: " + quadrado.toFixed(3));
console.log("RETANGULO: " + retangulo.toFixed(3));