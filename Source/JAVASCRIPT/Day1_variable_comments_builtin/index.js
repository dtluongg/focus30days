console.log("Hello every one, My name is Do Tien luong, nick name is Tylan. Today is 15/09/2026, I want to create plan for learn ReactJS from basic to knownlegde master. Let me try");

/** Day 1
 * Learn JavaScript for work, preparing for future.
 * Created by Do Tien Luong
 */ 

/* 
    Lesson 1 - Variable: 
    Variable can know basic like initial value, is maybe use variable with var, let, const.
    The different of that:
    1. var is variable global, can be update value, can be init again, no need value inital, have hoisting.
    2. let is variable scope, can be update value,  can not init again, no need value inital, no hoisting.
    3. const is variable scope, cannot update value, cannot init again, need value initial, no hoisting.
    Variable initial is character first. can not use number or another different character.
*/
// Example for Variable:
var testVar = 'Tien Luong'
console.log(testVar);
const testConst = 'This is value of testConst const';
console.log(testConst);
// testConst = 1; // Cannot Assignment to constant variable.

/*
    Lesson 2 - Built-in
    Built-in can know basic like some function help developer control greatter.
    1. Console -> show value have been used in console.log(value) on tab console in web browser.
    2. Confirm -> show popup in screen, user need choose option accept or decline.
    3. Alert -> show popup in screen, user need read and click accept to continue.
    4. Prompt -> show popup in screen, user need read and typing answer to continue.
    5. SetTimeout -> use for one function auto run after time out (once). use ClearTimeOut to end;
    6. SetInterval -> us for one function auto run while time out (many). use ClearInterval to end;
*/
// Example: 
// setInterval(()=> {
//     console.log("Luong is learning Javascript");
// }, 1500);


/*
    Lesson 3: - Operator:
    1. Arithmetic Operator - Vietnamese is toán tử số học: use for calculate arithmetic 
    2. Assigment Operator - Vietnamese is toán tử gán (=)
    3. Comparison Operator - Vietnamese is toán tử so sánh =< >= <> 
    4. Logical Operator - Vietnamese is toán tử logic && || ....
*/

/*  1. Arithmetic Operator
    +   Cộng
    -   Trừ
    *   Nhân 
    /   Chia
    **  Lũy thừa
    %   Chia lấy dư
    ++  Tăng 1 
    --  Giảm 1
*/
// Example:
    // var age = 20
    // var nextAge = 1 + age; // nextAge correct but age not increase
    // var nextAge = ++age; // age increase before ++ 
    // var nextAge = age++; // age increase after ++

/*  2. Assigment Operator: 
    =       x = y   ---> x = y
    +=      x += y  ---> x = x + y
    -=      x -=y   ---> x = x - y
    *=      x *= y  ---> x = x * y
    /=      x /= y  ---> x = x / y
    **=     x **= y ---> x = x ** y

    ++a (prefix)    -> return value before increase
    a++ (postfix)   -> return value after increase
*/
// Example: 
    // var a = 1, b = -1, c = a + b, d = a - b;
    var ex = 6 
    var result = ++ex * 2 - ex-- * 2; // 7 * 2 - 7 * 2
    console.log("value = ", result) 

/*  3. Comparison Operator => value of Comparison Operator is true or false
    ==      5 == 5
    !=      3 != 5
    >       5 > 3
    >=      5 > 3 + 2
    <       3 < 5
    <=      3 <= 5 - 2
*/
