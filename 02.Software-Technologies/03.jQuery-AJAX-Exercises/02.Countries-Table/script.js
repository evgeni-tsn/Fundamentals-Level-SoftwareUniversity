/* Created by evgeni-tsn on 23-Jun-2016. */

function fixRowLinks() {
    $('#countriesTable a').show();

    let tableRows = $("#countriesTable tr");
    $(tableRows[1]).find("a:contains('Up')").hide()

    $(tableRows[tableRows.length-1]).find("a:contains('Down')").hide();
}

function addCountry() {
    let country = $('#newCountryText').val();
    let capital = $('#newCapitalText').val();
    addCountryToTable(country, capital, true);
    row.hide();
    row.fadeIn();
    $("#newCountryText").val('');
    $("#newCapitalText").val('');
    fixRowLinks()
}

function deleteRow(link) {
    let row = $(link).parent().parent();
    row.fadeOut(function () {
        row.remove();
        fixRowLinks()
    });
}

$(function () {
    addCountryToTable("Bulgaria", "Sofia");
    addCountryToTable("Germany", "Berlin");
    addCountryToTable("Russia", "Moscow");
    addCountryToTable("France", "Paris");
    addCountryToTable("India", "New Delhi");
    fixRowLinks()
});

function moveRowUp(link) {
    let row = $(link).parent().parent();
    row.fadeOut(function () {
        row.insertBefore(row.prev());
        row.fadeIn();
        fixRowLinks()
    })
}

function moveRowDown(link) {
    let row = $(link).parent().parent();
    row.fadeOut(function () {
        row.insertAfter(row.next());
        row.fadeIn();
        fixRowLinks();
    })

}

function addCountryToTable(country, capital) {
    let row = $('<tr>')
        .append($("<td>").text(country))
        .append($("<td>").text(capital))
        .append($("<td>")
            .append($("<a href='#' onclick='moveRowUp(this)'>[Up]</a>"))
            .append(" ")
            .append($("<a href='#' onclick='moveRowDown(this)'>[Down]</a>"))
            .append(" ")
            .append($("<a href='#' onclick='deleteRow(this)'>[Delete]</a>"))
        );
    $("#countriesTable").append(row);
    return row;

}