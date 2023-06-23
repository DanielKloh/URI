//  var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
//  var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let dddNumber = [61,71,11,21,32,19,27,31];
let dddCidade = ["Brasilia","Salvador","Sao Paulo","Rio de Janeiro","Juiz de Fora","Campinas","Vitoria","Belo Horizonte"];
let entrada = Number(lines[0]);


for(let i = 0;i < dddCidade.length; i++){

    if(entrada === dddNumber[i]){
        console.log(dddCidade[i]);
        entrada = 1;
    }
}

if(entrada !== 1){
    console.log("DDD nao cadastrado");
}