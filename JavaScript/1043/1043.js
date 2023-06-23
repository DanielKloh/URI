// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let perimetro = 0; 
let area = 0;
let n1 = Number(lines[0].split(" ")[0]);
let n2 = Number(lines[0].split(" ")[1]);
let n3 = Number(lines[0].split(" ")[2]);


if (n1 > n2 - n3 && n1 > n3 - n2 && n1 < n2 + n3 && n1 < n3 + n2) {
    perimetro = n1 + n2 + n3;
    console.log("Perimetro = " + perimetro.toFixed(1));
}
else if (n2 > n1 - n3 && n2 > n3 - n1 && n2 < n1 + n3 && n2 < n3 + n1) {
    perimetro = n1 + n2 + n3;
    console.log("Perimetro = " + perimetro.toFixed(1));
}
else if (n3 > n2 - n1 && n3 > n1 - n2 && n3 < n2 + n1 && n3 < n1 + n2) {
    perimetro = n1 + n2 + n3;
    console.log("Perimetro = " + perimetro.toFixed(1));
}
else {
    area = ((n1 + n2) * n3) / 2;
    console.log("Area = " + area.toFixed(1));
}