/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";

function solve(arr) {
    let line = arr.map(function (x) {
        let split = x.split(" -> ");
        console.log("Name: "+ split[0]);
        console.log("Age: "+ split[1]);
        console.log("Grade: "+ split[2]);
    })
}

solve(["Pesho -> 13 -> 6.00",
    "Ivan -> 12 -> 5.57",
    "Toni -> 13 -> 4.90"]);
