(function () {

    // Create your own kinvey application

    let baseUrl = "https://baas.kinvey.com";
    let appKey = "kid_Bk6R8dYB";
    let appSecret = "d8c4087b31cf4aed8eeccbe0a797bac4";
    var _guestCredentials = "6e782eac-66b6-4b5f-9719-2fc25efed24c.IJqckU2q8y0MWo+Zz0/l60knZapnueTA7euG4H85/Ok="; // Create a guest user using PostMan/RESTClient/Fiddler and place his authtoken here...

    //Create AuthorizationService and Requester

    let selector = ".wrapper";
    let mainContentSelector = ".main-content";

    // Create HomeView, HomeController, UserView, UserController, PostView and PostController

    let authService = new AuthorizationService(
        baseUrl,
        appKey,
        appSecret,
        _guestCredentials);

    authService.initAuthorizationType("Kinvey");

    let requester = new Requester(authService);

    let homeView = new HomeView(selector, mainContentSelector);
    let homeController = new HomeController(homeView, requester, baseUrl, appKey);

    let userView = new UserView(selector, mainContentSelector);
    let userController = new UserController(userView, requester, baseUrl, appKey);

    let postView = new PostView(selector, mainContentSelector);
    let postController = new PostController(postView, requester, baseUrl, appKey);

    initEventServices();

    onRoute("#/", function () {
        if(!authService.isLoggedIn()){
            homeController.showGuestPage();
        }
        else {
            homeController.showUserPage();
        }
    });

    onRoute("#/post-:id", function () {
        let top = $("#post-" + this.params['id']).position().top;
        $(window).scrollTop(top);
    });

    onRoute("#/login", function () {
        userController.showLoginPage(authService.isLoggedIn());
    });

    onRoute("#/register", function () {
        userController.showRegisterPage(authService.isLoggedIn());
    });

    onRoute("#/logout", function () {
        userController.logout();
    });

    onRoute('#/posts/create', function () {
        let data = {
            fullName : sessionStorage['fullName']
        };

        postController.showCreatePostPage(data, authService.isLoggedIn());
    });

    bindEventHandler('login', function (ev, data) {
        userController.login(data);
    });

    bindEventHandler('register', function (ev, data) {
        userController.register(data);
    });

    bindEventHandler('createPost', function (ev, data) {
        postController.createPost(data);
    });

    run('#/');
})();
