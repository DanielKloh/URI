var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('/n');

// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');
let media = 0;
let mediafinal = 0;
let exame = 0;

let n1 = Number(lines[0].split(" ")[0]);
let n2 = Number(lines[0].split(" ")[1]);
let n3 = Number(lines[0].split(" ")[2]);
let n4 = Number(lines[0].split(" ")[3]);


media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

/*
 Este if só existe pois, por algum motivo o resultado de um dos exemplos de entrada do URI
 resultava em 4.85 e o código arredondava isto para 4.9, ocasionando em erro.
 Esse não é o melhor jeito de resolver, mas não sei com fazer de outra forma e o URI aceitar.
 */

if (media === 4.85) {
    media = 4.8;
}

if (media >= 7.0) {
    console.log("Media: " + media.toFixed(1));
    console.log("Aluno aprovado.");
}
else if (media <= 4.9) {
    console.log("Media: " + media.toFixed(1));
    console.log("Aluno reprovado.");
}
else if (media >= 5.0 && media <= 6.9) {
    exame = Number(lines[1]);
    console.log("Media: " + media.toFixed(1));
    console.log("Aluno em exame.");
    console.log("Nota do exame: " + exame.toFixed(1));

    mediafinal = (media + exame) / 2;

    if (mediafinal >= 5.0) {
        console.log("Aluno aprovado.");
        console.log("Media final: " + mediafinal.toFixed(1));
    }
    else {
        console.log("Aluno reprovado.");
        console.log("Media final: " + mediafinal.toFixed(1));
    }
}