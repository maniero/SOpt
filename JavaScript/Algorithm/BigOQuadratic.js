let contador = 0;

function allIncludes(a, b) {
    let allExists = null;
    for (const aElem of a) {
        // Note que o `includes` abaixo irá iterar sobre cada elemento de `b` até o
        // fim dos elementos, ou até que algum elemento seja igual a `aElem`.
        // Uma complexidade próxima de `O(n)`.
        if (includes(b, aElem)) {
            // Se `exists` já for `true`, irá continuar como `true`.
            // Se for `false`, não será atribuído.
            if (allExists === null) {
                allExists = true;
            }
        } else {
            allExists = false;
        }
    }
    console.log(contador);
    contador = 0;
    return allExists;
}

// Ignore:
function includes(arr, elem) {
    for (const el of arr) {
        if (el === elem) {
            return true;
        }
        contador++;
    }
  return false;
}

// Exemplo de entrada:
allIncludes([1, 2, 3], [3, 2, 1]); // true
allIncludes([1, 2, 3], [1, 2, 4]); // false

//https://pt.stackoverflow.com/q/429553/101
