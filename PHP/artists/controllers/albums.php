<?php

namespace Controllers;

class Albums_Controller extends Master_Controller {
    public  function  __construct() {
        parent::__construct(get_class(),
            'album', '/views/albums/');
//        echo "I`m an artist<br />";
    }

    public function index() {
        //$artists = $this->model->get(2);
        //$artists = $this->model->get_by_name('Rado Shisharkata');
        $albums = $this->model->find();
        //var_dump($artists); die();
        //var_dump($this->model); die();
        $template_name = DX_ROOT_DIR . $this->views_dir . 'index.php';

        include_once $this->layout;
    }

    public function view($id) {
        $albums = $this->model->get($id);
        var_dump($albums); die();

        $template_name = DX_ROOT_DIR . $this->views_dir . 'index.php';

        include_once $this->layout;
    }

}