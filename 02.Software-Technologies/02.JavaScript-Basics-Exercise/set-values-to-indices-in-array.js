/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";

function solve(arr) {
    let array = [];
    for (let i = 0; i < arr[0]; i++) {
        array[i] = 0;
    }
    
    for (let i = 1; i < arr.length; i++) {
        let splited = arr[i].split(" - ");
        array[parseInt(splited[0])] = parseInt(splited[1]);
    }

    for (let i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}

solve(["5",
    "0 - 3",
    "3 - -1",
    "4 - 2"]);