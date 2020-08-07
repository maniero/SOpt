function AllNull($error) {
    foreach ($error as $key => $value) if (!is_null( $value)) return false;
    return true;
}

//https://pt.stackoverflow.com/q/332875/101
