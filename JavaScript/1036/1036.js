// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

let input = require('fs').readFileSync('/dev/stdin', 'utf8');
let lines = input.split('\n');

let A = Number(lines[0].split(" ")[0]);
let B = Number(lines[0].split(" ")[1]);
let C = Number(lines[0].split(" ")[2]);


let delta = (Math.pow(B, 2) - 4 * A * C);

let raiz = Math.sqrt(delta);
if (delta > 0 && A !== 0) {
   let X1 = ((-B) + raiz) / (2 * A);
   let X2 = ((-B) - raiz) / (2 * A);
    console.log("R1 = " + X1.toFixed(5));
    console.log("R2 = " + X2.toFixed(5));
}
else {
    console.log("Impossivel calcular");
}