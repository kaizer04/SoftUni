<!DOCTYPE html>
<html>
<head>

</head>
<body>
    <style type="text/css">
        body {
            background-color: greenyellow;
        }
    </style>
    <div id="container">
        <div id="top-menu">
            Top Menu
        </div>
        <?php
            if(!emp ty($this->logged_user)) {
                echo "<div id='userbar'>Hello, {$this->logged_user['username']}!</div>";
            }
        ?>
        <div id="main">

