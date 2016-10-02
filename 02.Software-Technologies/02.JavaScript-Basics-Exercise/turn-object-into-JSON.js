/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */

"use strict";

function solve(arr) {
    let object = {};
    for (let i = 0; i < args.length; i++) {
        let argParams = args[i].split('->');
        let key = argParams[0].trim();
        let value = argParams[1].trim();

        object[key] = Number(value) || value;
    }

    console.log(JSON.stringify(object));
}

solve(["name -> Angel",
    "surname -> Georgiev",
    "age -> 20",
    "grade -> 6.00",
    "date -> 23/05/1995",
    "town -> Sofia"]);