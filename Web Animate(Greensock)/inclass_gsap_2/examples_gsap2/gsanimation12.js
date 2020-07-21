function start() { 
 
TweenMax.to(".box", 3,{x:300, ease:Power4.easeOut, onStart: amStart});
TweenMax.to(".circle", 3,{x:300, delay:3, ease:Power4.easeOut, 
                          onUpdate: amRun  });
TweenMax.to(".triangle", 3,{x:300, delay:6, ease:Power4.easeOut,
                           onComplete: Redirect
                           }); 
}

function amStart(){
    console.log("I am starting");
}
function amRun(){
    console.log("I am running");
}
function amDone(){
    console.log("I am done");
}
 function Redirect() {
               window.location="redirect.html";
            }