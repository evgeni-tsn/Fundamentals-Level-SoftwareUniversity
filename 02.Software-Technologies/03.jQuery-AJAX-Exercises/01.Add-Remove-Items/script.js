/* Created by evgeni-tsn on 23-Jun-2016. */

function addItemToList(text) {
    $('#items').append(
        $('<li>').append($('<span>').text(text))
            .append(" ")
            .append($("<a href='#' onclick='deleteItem(this)'>[Delete]</a>")
            )
    );
}

function addItemFromInput() {
    addItemToList($('#newItemText').val());
    $("#newItemText").val("");
}

$(function () {
    $("#newItemText").keypress(function (e) {
        if (e.keyCode === 13){
            $('#newItemText + input[type="button"]').click();
        }
    })
});



$(function () {
    addItemToList("First")
    addItemToList("Second")
});

function deleteItem(link) {
    $(link).parent().remove();
}
