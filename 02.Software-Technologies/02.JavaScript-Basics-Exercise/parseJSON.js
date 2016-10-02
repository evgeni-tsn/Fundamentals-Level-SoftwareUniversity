/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */
"use strict";

function solve(arr) {
    let parsed = arr.map(x => JSON.parse(x));
    parsed.forEach(function (x) {
        console.log("Name: "+x.name);
        console.log("Age: "+x.age);
        console.log("Date: "+x.date);
    })
}

solve([
    '{"name":"Gosho","age":"10","date":"19/06/2005"}',
    '{"name":"Tosho","age":"11","date":"04/04/2005"}'
]);