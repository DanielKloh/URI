// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let maior = 0;
let menor = 0;
let posicoa = 0;


for (let i = 1; i <= 100; i++) {

    let entrada = Number(lines[i]);

    menor = entrada;

    if(menor > maior){
        maior = menor;
        posicoa = i+1;
    }
    
}
console.log(maior);
console.log(posicoa);