<?php
$cnf['displayException'] = false;
$cnf['errorView'] = 'errors.error';

$cnf['default_controller'] =  'Index';
$cnf['default_method'] =  'index';
$cnf['namespaces']['Controllers'] = 'C:\xampp\htdocs\Blog-Practical-Project\Blog\controllers';
$cnf['namespaces']['Models'] = 'C:\xampp\htdocs\Blog-Practical-Project\Blog\models';
$cnf['namespaces']['Constants'] = 'C:\xampp\htdocs\Blog-Practical-Project\Blog\constants';
$cnf['namespaces']['Views'] = 'C:\xampp\htdocs\Blog-Practical-Project\Blog\views';

$cnf['viewsDirectory'] = 'C:\xampp\htdocs\Blog-Practical-Project\Blog\views';

$cnf['session']['autostart'] = true;
$cnf['session']['type'] = 'native'; //native, database
$cnf['session']['name'] = '_sess';
$cnf['session']['lifetime'] = 3600;
$cnf['session']['path'] = '/';
$cnf['session']['domain'] = '';
$cnf['session']['secure'] = false;
$cnf['session']['dbConnection'] = 'session';
$cnf['session']['dbTable'] = 'sessions';

$cnf['pageSize'] = 5;

return $cnf;