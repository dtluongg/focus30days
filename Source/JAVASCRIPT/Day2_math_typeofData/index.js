/**
 * Type of Data
 */
/*
    In JavaScript have two basic type of data (Primitive Data and Complex Data)
    Primitive should know is type of data we can see every where, it like is string, number, boolean, Undefined, Null, symbol.
    Complex should know is function, object.
*/

/*
    Truthy & Falsy

    Truthy:
    Any value in Javascript when change to type of data is boolean have result = true, we call this is Truthy
    Example: true, string, array, number -> Truthy (different value of list 6 Falsy -> Truthy)
    ---------------------------------------------------------------------------------------------------------------
    Falsy:
    Any value in Javascript when change to type of data is boolean have result = fasle, we call this is Falsy
    Example: false, 0, '',  null, undefined, NaN -> Falsy
    false, số 0, chuỗi rỗng, null, undefined, NaN -> tất cả value khác với 6 cái này đều là Truthy.

*/
const testTrue = true;
const testString = typeof('hello Luong') == "string";
const testArray = typeof['Hello', 'Luong'] ;
const testNumber = typeof(2) == "number";
const testTruthy = testTrue && testArray
console.log(`Truthy: ${testArray} `)

/*
    Math Logical and If Clause
    && will return true value if all value of list && no one in Falsy
    || will return value true if have one value true of list ||
*/
