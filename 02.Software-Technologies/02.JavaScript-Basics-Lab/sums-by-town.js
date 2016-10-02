/**
 * Created by evgeni-tsn on 17-Jun-2016.
 */
"use strict";
function solve(arr) {
    let objects = arr.map(JSON.parse);
    let data={};

    let sums = objects.forEach(function (object) {
        if (!(object.town in data)) {
            data[object.town] = object.income;
        }
        else{
        data[object.town] += object.income;
        }
    });

    let towns = Object.keys(data).sort();
    for (let town of towns){
        console.log(`${town} -> ${data[town]}`);}
}


let arr = ['{"town":"Sofia","income":200}',
'{"town":"Varna","income":120}',
'{"town":"Pleven","income":60}',
'{"town":"Varna","income":70}'];

solve(arr);