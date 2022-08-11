<?php

function echo_json($exp) { echo json_encode($exp),"\n"; }

echo_json( true ?? false );
echo_json( true ?? false == false );
echo_json( (true ?? false) == false );
echo_json( null ?? false == false );
echo_json( (null ?? false) == false );
echo_json( null ?? false == true );
echo_json( (null ?? false) == true );

//https://pt.stackoverflow.com/q/561058/101
