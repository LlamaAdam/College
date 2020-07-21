function part1() { 
 var tl = new TimelineMax();
    tl.to(".stop", 4, {y:500, scale:10, ease:Power2.easeOut, force3D:true});
    tl.to(".starter",1,{autoAlpha:0, display:"none"});
    return tl; 
    }
function part2(){
    var tl = new TimelineMax();
    tl.fromTo(".smileSvg",2,
              {x:1800,y:1800,opacity:0},
              {x:400,y:400,opacity:1, scale:3}
             );
    tl.fromTo(".tex",3,
              {x:-300,y:-300,opacity:0},
              {x:900,y:400, scale:2,opacity:1}
    );
    return tl;
}

function startmaster() { 
  var master = new TimelineMax();
   master.add(part1())
        .add(part2())
   ;
    
   master.duration(5);
    return master;
    
}