<?php

$list = $_GET['list'];
$maxSize = $_GET['maxSize'];

$listArr = preg_split("/\\n/", $list, -1, PREG_SPLIT_NO_EMPTY);
//var_dump($listArr);

//foreach ($listArr as $row) {
//    trim($listArr);
//    var_dump($row);
//}
$result = "<ul>";
for ($i = 0; $i < count($listArr); $i++) {
    $trimedRow = trim($listArr[$i]);
    //var_dump($trimedRow);

    if (strlen($trimedRow) > 0) {
        if (strlen($trimedRow) > $maxSize) {
            $resizedRow = substr($trimedRow, 0, $maxSize);
            $result .= "<li>" . htmlspecialchars($resizedRow) . "...</li>";
        }
        else {
            $result .= "<li>" . htmlspecialchars($trimedRow) . "</li>";
        }
    }

}
echo $result . "</ul>";

//var_dump($listArr);