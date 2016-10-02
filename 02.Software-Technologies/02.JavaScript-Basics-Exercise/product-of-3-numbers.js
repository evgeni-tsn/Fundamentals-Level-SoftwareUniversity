/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";
function solve(arr) {
    let expression = parseInt(arr[0])*parseInt(arr[1])*parseInt(arr[2]);
    if (expression > 0){
        console.log("Positive");
    }
    else{
        console.log("Negative");
    }
}

solve(arr);