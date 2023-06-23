//var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
//var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');



let numMes = Number(lines[0]);

let mes = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];


for (let i = 0; i < mes.length; i++) {

    if (numMes === i + 1) {

        console.log(mes[i]);
    }
}