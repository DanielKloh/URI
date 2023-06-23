// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let maior = 0;
let A = Number(lines[0].split(" ")[0]);
let B = Number(lines[0].split(" ")[1]);
let C = Number(lines[0].split(" ")[2]);

if (A > B && A > C)
{
maior = A;
}
else if (B > A && B > C)
{
maior = B;
B = A;
}
else
{
maior = C;
C = A;
}

if (maior >= B + C)
{
console.log("NAO FORMA TRIANGULO");
}
else
{
if (Math.pow(maior, 2) > Math.pow(B, 2) + Math.pow(C, 2))
{
    console.log("TRIANGULO OBTUSANGULO");
}
if (Math.pow(maior, 2) < Math.pow(B, 2) + Math.pow(C, 2))
{
    console.log("TRIANGULO ACUTANGULO");
}
if (Math.pow(maior, 2) == Math.pow(B, 2) + Math.pow(C, 2))
{
    console.log("TRIANGULO RETANGULO");
}
if (maior == B && maior == C && C == B)
{
    console.log("TRIANGULO EQUILATERO");
}
else
{
    if (maior == B || B == C || C == maior )
    {
        console.log("TRIANGULO ISOSCELES");
    }
}}