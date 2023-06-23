var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('/n');

// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');

let lasMoeda = [100, 50, 20, 10, 5, 2, "-", 1, 0.50, 0.25, 0.10, 0.05, 0.01];
let quantidades = [0, 0, 0, 0, 0, 0, "-" ,0, 0, 0, 0, 0, 0];
let entrada = Number(lines[0]);

//verifica notas
for(var pos = 0; pos < lasMoeda.length; pos++){
    if(lasMoeda[pos] != "-"){
        if (entrada >= lasMoeda[pos]) {
            quantidades[pos] = Math.floor((entrada / lasMoeda[pos]));
            entrada = Number((entrada % lasMoeda[pos]).toFixed(2));
        }
    }
}
var tipoMoeda = "nota";

console.log(tipoMoeda.toUpperCase()+"S:");
for (let i = 0; i < lasMoeda.length; i++)
{
    if(lasMoeda[i] == "-"){
        tipoMoeda = "moeda";
        console.log(tipoMoeda.toUpperCase()+"S:");
    }else{
        console.log(quantidades[i] + " " + tipoMoeda + "(s) de R$ " + lasMoeda[i].toFixed(2));
    }
}


