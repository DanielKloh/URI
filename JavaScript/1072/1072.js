// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let parametro = Number(lines[0]);
let dentro = 0;
let fora = 0;

for (let i = 0; i <= parametro; i++) {

    let entrada = Number(lines[i]);

    if (entrada >= 10 && entrada <= 20){
        dentro ++;
    }
    else{
        fora ++;
    }
    
}

fora --;

console.log(dentro + " in");
console.log(fora + " out");