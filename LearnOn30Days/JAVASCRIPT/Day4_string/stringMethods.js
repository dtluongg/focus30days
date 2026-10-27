// work with string
const email = 'luong1402technical1402@gmail.com';
// 1. Length
console.log(`Length of email: ${email.length}`)

// 2. Find Index:
console.log(`Vi tri cua 1402: ${email.indexOf('1402')}`);
// indexOf hỗ trợ tham số vị trí bắt đầu tìm
console.log(`Vi tri cua 1402: ${email.indexOf('1402', 6)}`); 
// string trong js có thể tìm qua biểu thức chính quy (regex)
email.search('*^[1-9]')

// 3. Cut String
email.slice(-3, -1)

//4 replace
console.log(email.replace(/1402/g, '2003')
)

//...
// split 
var coursesStr = 'HTML & CSS, JavaScript, ReactJS';
function strToArray(str) {
    return str.split(", ");
}
// Expected results
console.log(strToArray(coursesStr)) 
// Output: ['HTML & CSS', 'JavaScript', 'ReactJS']


// upper case
const getUpperCaseName = (string) => {
    return string.toUpperCase();
}
// Expected results:
console.log(getUpperCaseName("Nguyen van a")) // "NGUYEN VAN A"
console.log(getUpperCaseName("nGuyen vAn C")) // "NGUYEN VAN C"