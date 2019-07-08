<?php
$json = '{
    "ISteamClient": 0,
    "ISteamFriends": 0,
    "ISteamUser": 0,
    "IEconItems_440": 0,
    "IEconItems_730": 0,
    "ISteamGameCoordinator_440": 0,
    "ISteamGameCoordinator_570": 0
}';
$json_str = json_decode($json, true);
$clientesteam = $json_str["ISteamClient"];
echo "O Cliente Steam esta " . ($clientesteam == 0 ? "Online" : "Offline");

$json = '{
    "ISteamClient": 1,
    "ISteamFriends": 0,
    "ISteamUser": 0,
    "IEconItems_440": 0,
    "IEconItems_730": 0,
    "ISteamGameCoordinator_440": 0,
    "ISteamGameCoordinator_570": 0
}';
$json_str = json_decode($json, true);
$clientesteam = $json_str["ISteamClient"];
echo "\nO Cliente Steam esta " . ($clientesteam == 0 ? "Online" : "Offline");

//https://pt.stackoverflow.com/q/50095/101
