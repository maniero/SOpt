function rand(min = 1, max = 2){
    return Math.floor(Math.random() * (max - min) + min)
}

function f1(callback){
    setTimeout(function(){
        console.log('f1')
        if(callback)
            callback()
    }, rand())
}

function f2(callback){
    setTimeout(function(){
        console.log('f2')
        if(callback)
            callback()
    , rand()})
}

function f3(callback){
    setTimeout(function(){
        console.log('f3')
        if(callback)
            callback('Terminei.')
    }, rand())
}

f1(f2(f3(console.log)));
