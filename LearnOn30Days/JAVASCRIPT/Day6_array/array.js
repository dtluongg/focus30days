// array methods:
/**
 * To String: toString()
 * join(...)
 * pop
 * push
 * Shift
 * Unshift
 * Splicing
 * Concat
 * Slicing
 */

var languages = ['Vietnamese', 'English', 'Chinese']
// 1. ToString
console.log(languages.toString())

// 2. Join
console.log(languages.join(' - '))

function joinWithCharacter(array, charactor) {
    return array.join(charactor)
}

// Ví dụ khi sử dụng
var cars = ['Honda', 'Mazda', 'Mercedes'];

var result = joinWithCharacter(cars, ' - ');

console.log(result); // Expected: "Honda - Mazda - Mercedes"


//=================
// Viết hàm tại đây
function getLastElement(value){
  return value.at(-1)
}

// Ví dụ sử dụng
var animals = ['Monkey', 'Tiger', 'Elephant'];
var result = getLastElement(animals);

console.log(result); // Expected: "Elephant"
console.log(animals); // Expected: ['Monkey', 'Tiger', 'Elephant']