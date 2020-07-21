function start() {
 var tl = new TimelineMax();
    tl.to(".flex-container", 3,{ ease:Power4.easeOut, opacity:1});
    tl.from(".one", 1,{y:-600, ease:Back.easeInOut,opacity:0},0.5);
    tl.from(".two", 1,{y:-600, ease:Back.easeInOut,opacity:0},1);
    tl.from(".three", 1,{y:-600, ease:Back.easeInOut,opacity:0},1.5);
    tl.from(".four", 1,{y:-600, ease:Back.easeInOut,opacity:0},2);
    tl.from(".five", 1,{y:-600, ease:Back.easeInOut,opacity:0},2.5);
    tl.from(".seven", 1,{y:-600, ease:Back.easeInOut,opacity:0},3);
    tl.from(".eight", 1,{y:-600, ease:Back.easeInOut,opacity:0},3.5);
    tl.from(".nine", 1,{y:-600, ease:Back.easeInOut,opacity:0},4);
}
