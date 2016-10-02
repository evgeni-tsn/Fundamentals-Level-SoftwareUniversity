/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */
"use strict";

function solve(arr) {
    let data = {};
    for (let i = 0; i < arr.length - 1; i++) {
        let splitted = arr[i].split(" ");
        let key = splitted[0];
        let value = splitted[1];

        if (!(key in data)) {
            data[key] = [];
            data[key].push(value);
        }
        else {
            data[key].push(value);
        }
    }

    let keyword = arr[arr.length - 1];
    if (keyword in data)
        data[keyword].forEach(x => console.log(x));
    else
        console.log("None")
}

solve(["key value",
    "key eulav",
    "test tset",
    "key"]);