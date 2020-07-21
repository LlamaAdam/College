function startmaster() 
{
    var tl = new TimelineMax();
    tl.from(".logo",2,{scale:0});
    tl.fromTo("#card1",1,
              {x:1000*Math.random(),y:1000*Math.random(),opacity:0},
              {x:0,y:0,ease: SlowMo.ease.config( 0.7, 0.7, false),opacity:1}
             );
    tl.fromTo("#card2",1,
              {x:1000*Math.random(),y:-1000*Math.random(),opacity:0},
              {x:0,y:0,ease: Circ. easeOut,opacity:1}
             );
    tl.fromTo("#card3",1,
              {scale:5,opacity:0},
              {scale:1,opacity:1}
             );
const burst = new mojs.Burst({
  // by default, burst is in the center of the parent element
  // wee need to reset it the the top-left corner
  left: 0,
  top: 0,
  radius:   { 0: 100 },
            count:    8,
            children: {
                shape:      'zigzag',
                fill:       { 'red' : 'yellow' },
                radius:     20,
                angle:      { 360: 0 },
                duration:   2000
            }
});

    const burst2 = new mojs.Burst({
  // by default, burst is in the center of the parent element
  // wee need to reset it the the top-left corner
  left: 0,
  top: 0,
  radius:   { 0: 100 },
  count:    10,
  children: {
    shape:      'polygon',
    points:     5,
    fill:       { 'red' : 'yellow' },
    angle:      { 360: 0 },
    duration:   2000,
    delay:      'stagger(0, 100)'
  }
});
    const burst3 = new mojs.Burst({
  // by default, burst is in the center of the parent element
  // wee need to reset it the the top-left corner
  left: 0,
  top: 0,
  radius:   { 0: 100 },
  count:    10,
  children: {
    shape:      'polygon',
    points:     5,
    fill:       { 'black' : 'orange' },
    angle:      { 360: 0 },
    duration:   2000,
    delay:      'stagger( rand(0, 200) )'
  }
});
    
    
    document.getElementById("card1").onclick = function(e) {
  console.log('a', e);
  burst
    .tune({ x: e.pageX, y: e.pageY })
    .replay(); // `replay`(reset) means `reset` + `play`
        document.getElementById('fullCard1').style.display = 'block';
        document.getElementById("fullCard2").style.display = 'none';
        document.getElementById("fullCard3").style.display = 'none';
        document.getElementById('cardbox').style.backgroundColor  = 'skyblue';
        var tl = new TimelineMax();
        tl.fromTo("#greeting", 1.5,
                  {y:300, ease:Power4.easeOut},
                  {y:0, ease:Power4.easeOut}
                 );
        tl.fromTo("#cake",1.5,
                  {x:300,opacity:0},
                  {x:0, ease:Power4.easeOut,opacity:1}
                 );          
        tl.fromTo("#baloons",1.5,
                  {x:-300, opacity:0, scale:2},
                  {x:0, ease:Power2.easeOut,opacity:1, scale:1}
                 );   
        };
    document.getElementById("card2").onclick = function(e) {
        console.log('a', e);
        document.getElementById("fullCard1").style.display = 'none';
        document.getElementById("fullCard2").style.display = 'block';
        document.getElementById("fullCard3").style.display = 'none';
        document.getElementById('cardbox').style.backgroundColor  = '#430064';
  burst2
    .tune({ x: e.pageX, y: e.pageY })
    .replay(); // `replay`(reset) means `reset` + `play`
        var tl = new TimelineMax();
        tl.fromTo("#greeting2", 1.5,
                  {x:600,y:300},
                  {x:0, y:0, ease:Power4.easeOut}
                 );
        tl.fromTo("#present",1.5,
                  {x:300, y:-600 ,opacity:0},
                  {x:0, y:0, ease:Power4.easeOut,opacity:1}
                 );          
        tl.fromTo("#baloon2",1.5,
                  {y:-300, opacity:0, scale:2},
                  {y:0, ease: Back. easeOut,opacity:1, scale:1}
                 );
        
    };
    document.getElementById("card3").onclick = function(e) {
        console.log('a', e);
        document.getElementById("fullCard3").style.display = 'block';
        document.getElementById("fullCard2").style.display = 'none';
        document.getElementById('fullCard1').style.display = 'none';
        document.getElementById('cardbox').style.backgroundColor  = 'pink';
  burst3
    .tune({ x: e.pageX, y: e.pageY })
    .replay(); // `replay`(reset) means `reset` + `play`
        var tl = new TimelineMax();
        tl.fromTo("#greeting3", 1.5,
                  {scale:5},
                  {scale:1, ease:Power2.easeOut}
                 );
        tl.fromTo("#hi5",1.5,
                  {x:1000,y:1000,opacity:0},
                  {x:0, y:0, ease:Power1.easeOut,opacity:1}
                 );          
        tl.fromTo("#slice",1.5,
                  {scale:0, opacity:0},
                  {scale:1, ease:Power3.easeOut,opacity:1}
                 );
    };
    document.getElementById("thanks").onclick = function () {
        location.href = "ThankYou.html";
    };
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





