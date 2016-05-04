<?php

$text = $_GET['text'];
$blacklist = $_GET['blacklist'];
$blacklistItems = preg_split("/\s+/", $blacklist, -1, PREG_SPLIT_NO_EMPTY);
//var_dump($blacklistItems);

$emailPattern = '/\b[A-Za-z0-9\-\_\+]+@[A-Za-z0-9\-]+\.[A-Za-z0-9\-\_\.]+\b/';

$newText = preg_replace_callback($emailPattern, 'getReplacement', $text);

//var_dump($matches);

echo "<p>$newText</p>";

function getReplacement($match) {
    $email = $match[0];
    if (shouldBlacklist($email)) {
        return str_repeat("*", strlen($email));
    }
    else {
        return "<a href=\"mailto:$email\">$email</a>";
    }
}

function shouldBlacklist($email) {
    global $blacklistItems;
    foreach ($blacklistItems as $blacklistItem) {
        //if (strlen($blacklistItem) > 0 && $blacklistItem[0] == "*") {
        if (startsWith($blacklistItem, '*')) {
            $blacklistedDomain = substr($blacklistItem, 1);
            if (endsWith($email, $blacklistedDomain)) {
                return true;
            }
        }
        else {
            if ($email === $blacklistItem) {
                return true;
            }
        }
    }
    return false;
}

function startsWith($location, $target) {
    return $target === "" || strpos($location, $target) === 0;
}

function endsWith($location, $target) {
    return $target === "" || substr($location, -strlen($target)) === $target;
}