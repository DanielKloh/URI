// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let numeroPar = 0;
let numeroImpar = 0;
let numeroPositivo = 0;
let numeroNegativo = 0;


for (let i = 0; i < 5; i++) {
    let entrada = Number(lines[i]);

    if(entrada > 0){
        numeroPositivo ++;
    }
    else if(entrada < 0){
        numeroNegativo ++;
    }

    if(entrada%2===0){
        numeroPar ++;
    }
    else{
        numeroImpar ++
    }
}


console.log(numeroPar + " valor(es) par(es)");
console.log(numeroImpar + " valor(es) impar(es)");
console.log(numeroPositivo + " valor(es) positivo(s)");
console.log(numeroNegativo + " valor(es) negativo(s)");