function removeElement(element) {
  if (typeof(element) === "string") {
    element = document.querySelector(element);
  }
  return function() {
    element.parentNode.removeChild(element);
  };
}  // Found on gsap site.

function first(){

     var tl = new TimelineMax();
    tl.from("#paw1",0.5,{scale:2,opacity:0});
    tl.from("#paw2",0.5,{scale:2,opacity:0});
    tl.from("#paw3",0.5,{scale:2,opacity:0});
    tl.from("#paw4",0.5,{scale:2,opacity:0});
     return tl;
}
function second(){
    var tl = new TimelineMax();
    tl.from(".words",1,{scale:5,opacity:0});
    tl.to("#first",1,{opacity:0})
    tl.call(removeElement("#first"));
    return tl;
}
function third(){
    var tl = new TimelineMax();
    tl.from(".main",1,{x:-800,y:-800, ease: Bounce. easeOut, opacity:0});
    return tl;
}

function startmaster(){
    
    
    const OPTS = {
  fill:           'none',
  radius:         25,
  strokeWidth:    { 50 : 0 },
  scale:          { 0: 1 },
  duration:       500,
  left: 0,        top: 0,
  easing: 'cubic.out'
};

const mainCircle = new mojs.Shape({
  ...OPTS,
  stroke:         'white',
});

const smallCircles = [];
const colors = [ 'orange', 'red', 'blue', 'black' ]

for ( let i = 0; i < 4; i++ ) {
  smallCircles.push(new mojs.Shape({
    ...OPTS,
    parent:         mainCircle.el,
    radius:         { 0 : 15 },
    strokeWidth:    { 30: 0 },
    left: '50%',    top: '50%',
    stroke:         colors[ i % colors.length],
    delay:          'rand(0, 350)',
    x:              'rand(-50, 50)',
    y:              'rand(-50, 50)',
    radius:         'rand(5, 20)'
  })
 );
}

document.addEventListener( 'click', function (e) {
  
   mainCircle
    .tune({ x: e.pageX, y: e.pageY  })
    .replay();
  
    for ( let i = 0; i < smallCircles.length; i++ ) {
      smallCircles[i]
        .generate()
        .replay(); 
    }
  
}); 
    
    
    var master = new TimelineMax({});
   master.add(first())
    .add(second())
    .add(third())
   ;
    
   master.duration(5);
    return master;
} // end of starter


// For mouseover

function bouncer(x) {
  TweenMax.to(x, 0.5, {
  scale: 1.5,
  repeat: -1,
  ease: Bounce.easeOut,
  yoyoEase: Power3.easeOut
}); 
}
function bounceout(x){
    TweenMax.to(x,0.5,{scale:1})
}
