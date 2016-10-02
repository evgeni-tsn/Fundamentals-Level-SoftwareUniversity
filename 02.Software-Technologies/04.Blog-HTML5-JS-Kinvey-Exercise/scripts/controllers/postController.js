/* Created by evgeni-tsn on 25-Jun-2016. */

class PostController {
    constructor(postView, requester, baseUrl, appKey) {
        this._postView = postView;
        this._requester = requester;
        this._baseUrl = baseUrl;
        this._appKey = appKey;
    }

    showCreatePostPage(data, isLogged) {
        this._postView.showCreatePostPage(data, isLogged);
    };

    createPost(requestData) {
        if (requestData.title.length < 10) {
            showPopup('error', "Title content must consist of at least 10 symbols.");
            return;
        }

        if (requestData.content.length < 50) {
            showPopup('error', "Post content must consist of at least 50 symbols.");
            return;
        }

        let requestUrl = this._baseUrl;

        this._requester.post(requestUrl, requestData,
            function success(data) {
                showPopup('success', "You have successfully created a new post.");
                redirectUrl("#/");
            },
            function error(data) {
                showPopup('error', "An error has occurred while attempting to create a new post.");
            });
    };
}