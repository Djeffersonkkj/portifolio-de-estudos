var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const a = parseFloat(lines.shift());
const b = parseFloat(lines.shift());

const MediaPonderada = ((a * 3.5) + (b * 7.5)) / 11;

console.log(`MEDIA = ${MediaPonderada.toFixed(5)}`)