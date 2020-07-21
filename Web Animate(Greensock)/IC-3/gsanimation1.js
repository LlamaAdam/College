
function startmaster() {
 var tl = new TimelineMax();
    tl.to("#canvas_background",2,{x:600});
    tl.from("#body",2,{x:-600});
    tl.from("#svg_10",0.5,{opacity:0,size:2});
    tl.from("#svg_12",0.5,{opacity:0,size:2});
    tl.from("#svg_7",2,{x:-600, ease:Power1.easeOut});
    tl.from("#svg_6",2,{opacity:0,x:600});


}
 // end of start function
