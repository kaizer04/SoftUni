<html>
<head>
    <meta charset="UTF-8" />
    <title>Print Tags</title>
</head>
<body>
<div>Enter tags:</div>
<form method="GET">
    <input type="text" name="tags" />
    <input type="submit" value="Submit" />
</form>
</body>
</html>

<?php

if(isset($_GET['tags'])) {
    $tags = explode(',', trim($_GET['tags']));
    foreach($tags as $key => $tag) {
        echo "$key : $tag</br>";
    }
}

?>