function program(languages) {
    return (languages === 'Javascript' || languages === 'Typescript' || languages === 'Ecmascript') ? 'Belongs to the js universe!' : 'Does not belong to the js universe!!';
}

console.log(program('Javascript'));
console.log(program('Go'));

//https://pt.stackoverflow.com/q/460916/101
