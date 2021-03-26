function checkFieldInsert(normalInitialLevel, masterInitialLevel){
    for (let i = 0; i <= checkfields.length; i++){
        if ((checkfields[i] == currentLevel || checkfields[i] == desiredLevel) && levelNormal.checked && parseInt(checkfields[i].value) >= 400 || levelMaster.checked && parseInt(checkfields[i].value) < 400){
            if (levelMaster.checked){
                alert(`Level ${checkfields[i].value} is not master level`)
                break
            } else if (levelNormal.checked){
                alert(`Level ${checkfields[i].value} is not normal level`)
                break
            }
        }
    }   
}

https://pt.stackoverflow.com/q/495213/101
