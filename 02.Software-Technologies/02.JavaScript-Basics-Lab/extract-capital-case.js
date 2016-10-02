/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */
"use strict";

function solve(arr) {
    console.log(
        arr
            .join(",")
            .split(/\W+/)
            .filter(w=> w.length > 0)
            .filter(function (word) {
                return word == word.toUpperCase();
        })
            .join(", "));

        }

solve(['PHP, Java and HTML']);

