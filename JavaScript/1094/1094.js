// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

//leitura de um valor inteiro que diz quantas vezes o código se repete
let n = Number(lines[0]);

//Define o valor das variaveis
let coelho = 0;
let rato = 0;
let sapo = 0;

//Estrotura de reptção
for (let i = 1; i <= n; ++i) {

    let quantia = Number(lines[i].split(" ")[0]);
    let tipo = (lines[i].split(" ")[1]);


    if (tipo == "C") {
        coelho += quantia;//soma da quantidade de coelhos
    }
    if (tipo == "R") {
        rato += quantia;//soma da quantidade de ratos
    }
    if (tipo == "S") {
        sapo += quantia;//soma da quantidade de sapos
    }

}


let total = coelho + sapo + rato;
let persentcoelho = coelho / total * 100;
let persentrato = rato / total * 100;
let persentsapo = sapo / total * 100;

console.log("Total: " + total + " cobaias");
console.log("Total de coelhos: " + coelho);
console.log("Total de ratos: " + rato);
console.log("Total de sapos: " + sapo);
console.log("Percentual de coelhos: " + persentcoelho.toFixed(2) + " %");
console.log("Percentual de ratos: " + persentrato.toFixed(2) + " %");
console.log("Percentual de sapos: " + persentsapo.toFixed(2) + " %");
