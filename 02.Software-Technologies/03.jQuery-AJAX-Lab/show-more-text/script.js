/* Created by evgeni-tsn on 23-Jun-2016. */

function showText() {
    document.getElementById('text').style.display = 'inline';
    document.getElementById('more').style.display = 'none';
    document.getElementById('less').style.display = 'inline';
}

function hideText() {
    document.getElementById('text').style.display = 'none';
    document.getElementById('less').style.display = 'none';
    document.getElementById('more').style.display = 'inline';

}