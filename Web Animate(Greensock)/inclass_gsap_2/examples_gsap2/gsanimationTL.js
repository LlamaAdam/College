function start() { 
TweenMax.to(".box", 3,{x:300, ease:Power4.easeOut});
TweenMax.to(".circle", 3,{x:300, delay:3, ease:Power4.easeOut});
TweenMax.to(".triangle", 3,{x:300, delay:6, ease:Power4.easeOut}); 
}
function star1() { 
 var tl = new TimelineMax();
    tl.to(".box", 3,{x:300, ease:Power4.easeOut});
    return tl; 
    }
function star2() { 
 var tl = new TimelineMax();
    tl.to(".circle", 3,{x:300, delay:3, ease:Power4.easeOut});
    return tl; 
    }
function star3() { 
 var tl = new TimelineMax();
    tl.to(".triangle", 3,{x:300, delay:6, ease:Power4.easeOut});
    return tl; 
    }
function startmaster() { 
  var master = new TimelineMax();
   master.add(star1())
       .add(star2())
       .add(star3())
   ;
    return master;
}