<?php

class HomeController extends BaseController
{
    function index() {
        $lastPosts = $this->model->getLastPosts(5);
        $this->posts = array_slice($lastPosts, 0, 3);
        $this->sidebarPosts = $lastPosts;
    }

    public function view(int $id)
    {
        $this->post = $this->model->getPostById($id);
    }
}
