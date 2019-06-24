var mainNodeInner = document.createElement('div'),
    mainNodeInnerPlus = document.createElement('div'),
    mainNodeAppend = document.createElement('div'),
    sampleHTML = '<div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div>',
    testHTML = '',
    numSamples = 1000,
    before = null,
    after = null;
for (var i = 0; i < numSamples; i++) testHTML += sampleHTML;
mainNodeInnerPlus.innerHTML = testHTML;
before = new Date().getTime();
mainNodeInnerPlus.innerHTML += sampleHTML;
after = new Date().getTime();
console.log("TIME INNER HTML +=: " + (after - before) + " ms");
console.log("Num childs after: " + mainNodeInnerPlus.childElementCount);
console.log(' ');
var allHTML = testHTML + sampleHTML;
before = new Date().getTime();
mainNodeInner.innerHTML = allHTML;
after = new Date().getTime();
console.log("TIME INNER HTML =: " + (after - before) + " ms");
console.log("Num childs after: " + mainNodeInner.childElementCount);
console.log(' ');
mainNodeAppend.innerHTML = testHTML;
before = new Date().getTime();
var sampleNode = document.createElement('div');
sampleNode.innerHTML = sampleHTML;
while (sampleNode.hasChildNodes()) mainNodeAppend.appendChild(sampleNode.firstChild);
after = new Date().getTime();
console.log("TIME APPEND CHILD: " + (after - before) + " ms");
console.log("Num childs after: " + mainNodeAppend.childElementCount);

//https://pt.stackoverflow.com/q/392870/101
