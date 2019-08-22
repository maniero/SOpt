#include <stdio.h>
extern "C" {
    #include "lua/lua.h"
    #include "lua/lualib.h"
    #include "lua/lauxlib.h"
}
// In Lua 5.0 reference manual is a table traversal example at page 29.
void PrintTable(lua_State *L) {
    lua_pushnil(L);
    while(lua_next(L, -2) != 0) {
        if(lua_isstring(L, -1))
          printf("%s = %s\n", lua_tostring(L, -2), lua_tostring(L, -1));
        else if(lua_isnumber(L, -1))
          printf("%s = %d\n", lua_tostring(L, -2), lua_tonumber(L, -1));
        else if(lua_istable(L, -1))
          PrintTable(L);
        lua_pop(L, 1);
    }
}

void main() {
    lua_State *L = lua_open();
    // Load file.
    if(luaL_loadfile(L, "seuCodigo.lua") || lua_pcall(L, 0, 0, 0)) {
        printf("Cannot run file\n");
        return;
    }
    // Print table contents.
    lua_getglobal(L, "myTable");
    PrintTable(L);
    // Print specific field.
    lua_getglobal(L, "myTable");
    lua_pushstring(L, "one");
    lua_gettable(L, -2);
    if(lua_isstring(L, -1))
        printf("\myTable.one = %s\n", lua_tostring(L, -1));
    lua_close(L);
}

//https://pt.stackoverflow.com/q/55230/101
