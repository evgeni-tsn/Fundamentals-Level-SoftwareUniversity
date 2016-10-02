/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";
function solve(arr) {
    let n = parseInt(arr[0]);
    let x = parseInt(arr[1]);
    if(x >= n){
        console.log(n*x);
    }else{
        console.log(n/x);
    }
}

solve([20,30]);