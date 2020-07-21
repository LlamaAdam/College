
function part1() {
 var tl = new TimelineMax();
    tl.to(".greenbox", 1 , {x:-50,y:-190});
    return tl;
    }
    function part2() {
     var tl = new TimelineMax();
     tl.to(".sun", 2 ,{x:900,y:-200, ease:  Power2. easeInOut})
       .to(".sun", 2 ,{x:1800,y:0, ease:Power2. easeInOut});
        return tl;
        }
        function part3() {
         var tl = new TimelineMax();
         tl.to(".greenbox", 0.1 , {x:-50,y:-190})
           .to(".blackbox",2,{x:-50,y:-50,opacity:1})
           .to(".moon", 2 ,{x:900,y:-200, ease:  Power2. easeInOut})
           .to(".moon", 2 ,{x:1800,y:0, ease:Power2. easeInOut});
            return tl;
            }

function startmaster() {
  var play = document.querySelector("#play");
  var pause = document.querySelector("#pause");
  var resume = document.querySelector("#resume");
  var reverse = document.querySelector("#reverse");
  var restart = document.querySelector("#restart");
  var master = new TimelineMax({paused:true});
  master.add(part1())
  .add(part2())
  .add(part3())
  ;
  play.onclick = function() {
    master.play();
  }
  pause.onclick = function() {
    master.tweenFromTo(part3());
    master.restart();
  }
  resume.onclick = function() {
    master.duration(6);
    master.restart();
  }
  reverse.onclick = function() {
    master.duration(12);
    master.restart();
  }
  restart.onclick = function() {
    master.duration(10);
    master.restart();
  }

  return master;
  }




 // end of start function

function Redirect() {
               window.location="redirect.html";
            }
