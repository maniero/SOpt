std::string reverse_pairs(std::string const & src) {
    assert(src.size() % 2 == 0);
    std::string result;
    result.reserve(src.size());
    for (std::size_t i = src.size(); i != 0; i -= 2) {
        result.append(src, i - 2, 2);
    }
    return result;
}
                        
//https://pt.stackoverflow.com/q/42339/101
