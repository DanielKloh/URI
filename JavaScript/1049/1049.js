// var input = process.argv[2];//require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('/n');

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');


let p1 = lines[0];
let p2 = lines[1];
let p3 = lines[2];

if (p1 === "vertebrado") {
    if (p2 === "ave") {
        if (p3 === "carnivoro") {
            console.log("aguia");
        }
        else {
            console.log("pomba");
        }
    }
    else if (p2 === "mamifero") {
        if (p3 === "onivoro") {
            console.log("homem");
        }
        else {
            console.log("vaca");
        }
    }
}
if (p1 === "invertebrado") {
    if (p2 === "inseto") {
        if (p3 === "herbivoro") {
            console.log("lagarta");
        }

        else {
            console.log("pulga");
        }
    }
    else if (p2 === "anelideo") {
        if (p3 === "hematofago") {
            console.log("sanguessuga");
        }
        else {
            console.log("minhoca");
        }
    }
}