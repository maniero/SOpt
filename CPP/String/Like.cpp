if (a[0] == '9' && a[a.size() - 1] == '4')

auto patternBegin = "9";
auto patternEnd = "4";
if (a.size() > patternBegin.size() && a.size() > patternEnd.size() &&
    equals(patternBegin.begin(), patternBegin.end(), a.end()) &&
    equals(patternEnd.rbegin(), patternEnd.rend(), a.rbegin()))
    
//https://pt.stackoverflow.com/q/140168/101
