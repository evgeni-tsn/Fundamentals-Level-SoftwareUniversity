/* Created by evgeni-tsn on 23-Jun-2016. */
$(function () {
    $('#loadPosts').click(function() {
        let USERNAME = "guest", PASSWORD = "guest";
        let authBase64 = btoa(USERNAME + ":" + PASSWORD);
        $.ajax({
            method: "GET",
            url: "https://baas.kinvey.com/appdata/kid_Bk6R8dYB/posts",
            headers: { "Authorization": "Basic " + authBase64 },
            success: showPosts,
            error: showError
        });
    });
});

function showPosts(data, status) {
    let ul = $('<ul>');
    for (let post of data) {
        ul.append($('<li>').text(
            post.title + " -> " + post.body));
    }
    $('body').append(ul);
}
function showError(data, status) {
    let errorMsg = "Error: " + JSON.stringify(data);
    $('body').append($('<div>').text(errorMsg));
}



