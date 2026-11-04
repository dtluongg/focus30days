/**
 * String 
 */

// trong tring, muốn dùng dấu \ backslash (\) thì cần dùng 2 dấu \\, hoặc muốn hiện '' trong chuỗi thì cần dùng \'hello\'
// số lượng ký tự chiều ngang trên 1 dòng là 80 ký tự
var firstName = 'Luong'
var lastName = 'Do'
console.log('Toi la: ' + firstName + ' ' + lastName);
// với es6 (template string)
console.log('ES6: ')
console.log(`Toi la: ${firstName} ${lastName}`);