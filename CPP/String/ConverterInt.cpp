#include<sstream>
template <typename T> std::string to_string(T value) {
  //create an output string stream
  std::ostringstream os;
  //throw the value into the string stream
  os << value ;
  //convert the string stream into a string and return
  return os.str() ;
}

//https://pt.stackoverflow.com/q/45041/101
