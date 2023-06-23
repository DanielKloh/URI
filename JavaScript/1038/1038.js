// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let valor1;
let valor2 = 0;
let valor3 = 0;
let valor4 = 0;
let valor5 = 0;
let codigo = Number(lines[0].split(" ")[0]);
let qtd = Number(lines[0].split(" ")[1]);

if (codigo === 1) {
    valor1 = qtd * 4.00;
    console.log(
        "Total: R$ " + valor1.toFixed(2)
    );
}
if (codigo === 2) {
    valor2 = qtd * 4.50;
    console.log(
        "Total: R$ " + valor2.toFixed(2)
    );
}
if (codigo === 3) {
    valor3 = qtd * 5.00;
    console.log(
        "Total: R$ " + valor3.toFixed(2)
    );
}
if (codigo === 4) {
    valor4 = qtd * 2.00;
    console.log(
        "Total: R$ " + valor4.toFixed(2)
    );
}
if (codigo === 5) {
    valor5 = qtd * 1.50;
    console.log(
        "Total: R$ " + valor5.toFixed(2)
    );
}