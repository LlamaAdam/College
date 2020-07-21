
function startmaster() {
 var tl = new TimelineMax();
    tl.from(".logo",2,{scale:0});
    tl.fromTo(".card1-item",2,
              {x:1000,y:1000,opacity:0},
              {x:0,y:0,ease: SlowMo.ease.config( 0.7, 0.7, false),opacity:1}
             );
    tl.fromTo(".card2-item",2,
              {x:-1000,y:-1000,opacity:0},
              {x:0,y:0,ease: Circ. easeOut,opacity:1}
             );
    tl.fromTo(".llama",2,
              {scale:5,opacity:0},
              {scale:1,opacity:1}
             );
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
