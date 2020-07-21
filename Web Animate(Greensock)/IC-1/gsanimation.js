function start() {
 var tl = new TimelineMax();
    tl.to("#chessboard", 2,{x:300, ease:Power4.easeOut});
    tl.from("#row1", .5,{x:800, ease:Power3.easeOut, opacity:0});
    tl.from("#row2", .5,{x:800, ease:Power2.easeOut, opacity:0});
    tl.from("#row3", .5,{x:800, ease:Power1.easeOut, opacity:0});
    tl.from("#row4", .5,{x:800, ease:Power0.easeOut, opacity:0});
    tl.from("#row5", .5,{x:800, ease:Back, opacity:0});
    tl.from("#row6", .5,{y:800, ease:Elastic, opacity:0});
    tl.from("#row7", .5,{y:800, ease: Sine. easeOut, opacity:0});
    tl.from("#row8", .5,{x:800, ease: SlowMo.ease, opacity:0});
}
function pieces() {
 var t2 = new TimelineMax();
    t2.to("#king", .5,{x:155, y:-45, ease: Power1.easeOut, opacity:1});
    t2.to("#queen",.5,{x:170, y:-45, ease:Power2.easeOut, opacity:1});
    t2.to("#bishop",.5,{x:-5, y:-45, ease:Power3.easout, opacity:1});
}