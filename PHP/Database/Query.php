select * from tabela where user_id = $user_id || user_group = $user_group || find_in_set($user_level, user_level) || find_in_set($user_type, user_type) || find_in_set($user_role, user_role) || (user_id = null && user_group = null && user_level = null && user_type = null && user_role)

//https://pt.stackoverflow.com/q/46259/101
