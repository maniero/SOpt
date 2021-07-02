extern "C" {
#include "lua.h"
#include "lualib.h"
#include "lauxlib.h"
}

int main() {
    lua_State *L = lua_open();
    luaL_openlibs(L);
    luaL_dostring(L, "print('Ola mundo')");
    lua_close(L);
}

//https://pt.stackoverflow.com/q/50413/101
