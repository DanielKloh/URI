    // var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let entrada = Number(lines[0]);
let parametro = entrada+12
for (let i = entrada; i < parametro ; i++) {
    if(i%2 !== 0){
        console.log(i);
    }
}