
function startmaster() {
 var tl = new TimelineMax();
    tl.from(".logo",2,{scale:0});


Draggable.create(".icon", {
  bounds:"svg",
  onDrag: function() {
    if (this.hitTest("#bag")) {
      TweenLite.to(this.target, 0.6, {opacity:0, scale:0, svgOrigin:"675 143"});
    }
  }
});

}

function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    TweenMax.fromTo(mySidenav, 5, { opacity: 0 },         //from state
        { opacity: 1 });          
    TweenMax.staggerFrom('.btn', 5, { scale: 0, y: +100, ease: Bounce.easeOut }); 
}
function openNav_right() {
    document.getElementById("mySidenav_right").style.width = "250px";
    TweenMax.fromTo(mySidenav_right, 2, { opacity: 0 },         //from state
        { opacity: 1 });          
    TweenMax.staggerFrom('.btn', 3, { scale: 0, y: +100, ease: Bounce.easeOut }); 
}
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}
function closeNav_right() {
    document.getElementById("mySidenav_right").style.width = "0";
}
 // end of start function

