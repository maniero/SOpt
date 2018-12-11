namespace My_lib {

    using namespace His_lib; // everything from His_lib
    using namespace Her_lib; // everything from Her_lib

    using His_lib::String; // resolve potential clash in favor of His_lib
    using Her_lib::Vector; // resolve potential clash in favor of Her_lib

}

//https://pt.stackoverflow.com/q/38435/101
