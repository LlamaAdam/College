function start() {
 var tl = new TimelineMax();
    tl.to(".flex-container", 3,{ ease:Power4.easeOut, opacity:1});
    tl.from(".one", 1,{x:-600, ease:Circ,opacity:0});
    tl.from(".two", 1,{x:-600,y:600, ease:Power1.easeIn,opacity:0});
    tl.from(".three", 1,{y:600, ease:Power2.easeOut,opacity:0});
    tl.from(".four", 1,{x:600 , y:600, ease:Power3.easeIn,opacity:0});
    tl.from(".five", 1,{x:600, ease:Back.easeInOut,opacity:0});
    tl.from(".seven", 1,{x:600,y:-600, ease:Elastic,opacity:0});
    tl.from(".eight", 1,{y:-600, ease:Expo.easeIn,opacity:0});
    tl.from(".nine", 1,{x:-600,y:-600, ease:Power0.easeNone,opacity:0});
}
