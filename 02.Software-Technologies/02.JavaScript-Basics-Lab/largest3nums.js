/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */
"use strict";

function solve(arr) {
    let nums = arr.map(Number);
    let sortedNums = nums.sort((a,b) => b-a);
    let count = Math.min(3, arr.length);
    for (var i = 0; i < count; i++) {
        console.log(sortedNums[i]);
    }
}

solve(['10', '30']);