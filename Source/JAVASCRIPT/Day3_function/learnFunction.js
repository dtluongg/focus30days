console.log("Today, I'm learn about function");

/**
 * Function have two type
 * Type 1: Built-in Function (Alert, Console.log,..)
 * Type 2: Function created (function get..(){}) // hàm tự định nghĩa
 */

/**
 * 1. Function is code block
 * 2. Function cannot Execute when init
 * 3. Function can recive parameter
 * 4. Function can return one value
 */

// parameter  : tham số => console(a,b) 
// agrument   : đối số  => console(1,2) 

// parameter:
function writeLog(){
  console.log("Đây là 1 dòng log")
}
// khi định nghĩa, gọi là tham số, khi sử dụng gọi là đối số
function writeLog(mess1, mess2){
  console.log(mess1);
  console.log(mess2);
}

writeLog('Hello', 'Luong');

// console.log().. use arguments for get all info of array,...
// Khi function trùng tên, nó chỉ gọi function đc khởi tạo cuối cùng
// Khi khai báo biến trong function, biến đó chỉ đc gọi trong function
// Hàm vẫn đc khởi tạo trong hàm khác bình thường

/**
 * 
 * Các loại function:
 * 1. Declaration Function
 * 2. Express Funtion
 * 3. Arrow Function
 */

// 1. Declaration Function: 
function DeclarationFunction() {
  // là khởi tạo bằng chữ function, bắt buộc đặt tên, nếu ko đặt tên thi k phải là declaration function, có thể gọi trước khi khởi tạo
  // Is init with function first, require set name, if not set name, cannot call this is declaration function, can call before init (hoisting)
}

// 2. Express Function:
const ExpressFunction = function(){
  // khai báo dưới dạng biến, nhưng lại gán kiểu biến là function, nhưng không thể gọi trước khi khởi tạo
  // Init with varian, but type of varios is function, but can not call before init (no hoisting)
}

// 3. Arrow Function
const ArrowFunction = () => {
  // khai báo function dạng biến, nhưng dùng ký hiệu mới trong es6 để tạo function nhanh hơn, không cần dùng chữ function
  // Init with varian, but use new type of ES6 for create function faster, don't need us function name.
}


