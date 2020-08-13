var countDownDate = new Date("Nov 30, 2018 00:00:00").getTime();
var x = setInterval(function() {
var distance = countDownDate - new Date().getTime();
    document.getElementById("days").innerHTML = Math.floor(distance / (1000 * 60 * 60 * 24)) + "<br><small>dias</small>";
    document.getElementById("hours").innerHTML = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60)) + "<br><small>horas</small>";
    document.getElementById("minutes").innerHTML = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60)) + "<br><small>minutos</small>";
    document.getElementById("seconds").innerHTML = Math.floor((distance % (1000 * 60)) / 1000) + "<br><small>segundos</small>";
    document.getElementById("decimals").innerHTML = Math.floor((distance % (10 * 60)) / 100) + "<br><small>décimos</small>";                
}, 100);
.clock .clock-box {
    display: inline-block;
    text-align: center;
    margin: 5px;
}  

.clock-box {
    background-color: black;
    color: lightgreen;
    border-radius: 5px;
    width: 60px;
    font-size: 10px;
}
<div class="clock">
    <div class="clock-box" id="days"></div>
    <div class="clock-box" id="hours"></div>
    <div class="clock-box" id="minutes"></div>
    <div class="clock-box" id="seconds"></div>
    <div class="clock-box" id="decimals"></div>
</div>

//https://pt.stackoverflow.com/q/340139/101
