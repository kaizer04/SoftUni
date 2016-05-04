<?php

namespace Admin\Controllers;

class Artists_Controller extends Admin_Controller {
    public  function  __construct() {
        //var_dump('Is Admin Astist?'); die();
        parent::__construct(get_class(),
            'artist', '/views/admin/artists/');
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

    public function edit($id) {
        if(!empty($_POST['name']) && !empty($_POST['country']) && !empty($_POST['id'])) {
            $name = $_POST['name'];
            $country = $_POST['country'];
            $id = $_POST['id'];
            $artist = array(
                'id' => $id,
                'name' => $name,
                'country' => $country
            );

            $this->model->update($artist);
        }

        $artist = $this->model->get($id);
        //var_dump($artist); die();
        if(empty($artist)) {
            die('Nothing to edit here');
        }

        $artist = $artist[0];
        //var_dump($artist); die();

        $template_name = DX_ROOT_DIR . $this->views_dir . 'edit.php';

        include_once $this->layout;
    }

    public function add() {
        if(!empty($_POST['name']) && !empty($_POST['country'])) {
            $name = $_POST['name'];
            $country = $_POST['country'];
            $artist = array(
                'name' => $name,
                'country' => $country
            );

            $this->model->add($artist);
        }

        $template_name = DX_ROOT_DIR . $this->views_dir . 'add.php';

        include_once $this->layout;
    }

    public function view($id) {
        $artists = $this->model->get($id);
        var_dump($artists); die();

        $template_name = DX_ROOT_DIR . $this->views_dir . 'index.php';

        include_once $this->layout;
    }
}