/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";

function solve(arr) {
    Array.prototype.removeAt = function(position){
        this.splice(position,1);
    };
    let array = [];
    for (let i = 0; i < arr.length; i++) {
        let splitted = arr[i].split(" ");
        if(splitted[0] == "add"){
            array.push(splitted[1]);
        }
        else if(splitted[0] == "remove"){
            array.removeAt(splitted[1]);
        }
    }
    // array.map(x => console.log(x));
    for (let i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}

solve(["add 3",
    "add 5",
    "remove 0",
    "add 6",
    "add 8",
    "remove 2",
    "add 7"]);
