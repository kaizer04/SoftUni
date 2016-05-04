<?php

namespace Controllers;

class Artists_Controller extends Master_Controller {
    public  function  __construct() {
        parent::__construct(get_class(),
            'artist', '/views/artists/');
//        echo "I`m an artist<br />";
    }

    public function index() {
        //$artists = $this->model->get(2);
        //$artists = $this->model->get_by_name('Rado Shisharkata');
        $artists = $this->model->find();
        //var_dump($artists); die();
        //var_dump($this->model); die();
        $template_name = DX_ROOT_DIR . $this->views_dir . 'index.php';

        include_once $this->layout;
    }

    public function view($id) {
        $artists = $this->model->get($id);
        var_dump($artists); die();

        $template_name = DX_ROOT_DIR . $this->views_dir . 'index.php';

        include_once $this->layout;
    }

    public function dve() {
        include_once DX_ROOT_DIR . $this->views_dir . 'dve.php';

        include_once $this->layout;
    }

    public function tri() {
        include_once DX_ROOT_DIR . $this->views_dir . 'tri.php';

        include_once $this->layout;
    }
}