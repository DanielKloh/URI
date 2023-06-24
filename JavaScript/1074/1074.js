// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let parametro = Number(lines[0]);

for (let i = 1; i <= parametro; i++) {

    let entrada = Number(lines[i]);


    if (entrada === 0) {
        console.log("NULL");
    }


    else if (entrada % 2 === 0) {

        if (entrada > 0) {
            console.log("EVEN POSITIVE");
        }
        else if (entrada < 0) {
            console.log("EVEN NEGATIVE");
        }
    }


    else if(entrada % 2 !== 0) {
        if (entrada > 0) {
            console.log("ODD POSITIVE");
        }
        else if (entrada < 0) {
            console.log("ODD NEGATIVE");
        }
    }
}
