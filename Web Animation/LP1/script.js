
//Updated

setTimeout(anotherFunction, 3000);

function anotherFunction() {
  document.getElementById("part1").style.display = "none";
  document.getElementById("part2").style.display = "block";
}

function closeNav(x) {
    document.getElementById("mySidenav").style.display = "none";
}
function myFunction(x) {
  document.getElementById("mySidenav").style.display = "block";
  x.classList.toggle("change");
  setTimeout(function(){x.classList.toggle("change");}, 2000);
}

function groups() {
  document.getElementById("subPage").innerHTML = "Our Groups";
}
function join() {
  document.getElementById("subPage").innerHTML = "Join Here!";
}
function events(){
  document.getElementById("subPage").innerHTML = "Event List";
}
