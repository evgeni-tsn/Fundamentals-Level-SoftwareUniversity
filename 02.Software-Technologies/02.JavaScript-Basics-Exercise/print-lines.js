/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";
function solve(arr) {
    for (var i = 0; i < arr.length; i++) {
        while(arr[i]!="Stop"){
            console.log(arr[i]);
            i++;
        }
        break;
    }
}

solve(["Line 1",
    "Line 2",
    "Line 3",
    "Stop"]);