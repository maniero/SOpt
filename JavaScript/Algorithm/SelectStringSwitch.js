function program(languages) {
    switch (languages) {
    case 'Javascript':
    case 'Typescript':
    case 'Ecmascript': return 'Belongs to the js universe!';
    default : return 'Does not belong to the js universe!!'
    }
}

console.log(program('Javascript'));
console.log(program('Go'));

//https://pt.stackoverflow.com/q/460916/101
