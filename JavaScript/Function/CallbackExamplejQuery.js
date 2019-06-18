// args is for internal usage only
each: function( obj, callback, args ) { //note que args não faz parte da API pública
    var i = 0,
        length = obj.length,
        isArray = isArraylike( obj );

    if ( args ) { //aqui trata quando há algo interno acontecendo
        if ( isArray ) {
            for ( ; i < length; i++ ) {
                if ( callback.apply( obj[ i ], args ) === false ) {
                    break;
                }
            }
        } else {
            for ( i in obj ) {
                if ( callback.apply( obj[ i ], args ) === false ) {
                    break;
                }
            }
        }

    // A special, fast, case for the most common use of each
    } else { //tratamento do caso público que é que nos interessa
        if ( isArray ) { //tratamento especial se for um array
            for ( ; i < length; i++ ) { //varrrrá todo array passado
                if ( callback.call( obj[ i ], i, obj[ i ] ) === false ) {
                    break; //encerra quando a chama acima falhar
                }
            }
        } else { //outros objetos
            for ( i in obj ) { //vai analisar cada elemento do objeto passado
                if ( callback.call( obj[ i ], i, obj[ i ] ) === false ) {
                    break;
                }
            }
        }
    }

    return obj;
},

//https://pt.stackoverflow.com/q/47828/101
