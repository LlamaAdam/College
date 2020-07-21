function removeElement(element) {
  if (typeof(element) === "string") {
    element = document.querySelector(element);
  }
  return function() {
    element.parentNode.removeChild(element);
  };
}

function first() {
    var tl = new TimelineMax();
    var x = document.getElementById("merc").getElementsByTagName('img');
    tl.from("#merc",1,{x:2000*Math.random(),y:2000*Math.random(),opacity:0,scale:3});
    tl.from("#merc",0.5,{color:330033});
    return tl;
}
function second() {
    var tl = new TimelineMax();
    var x = document.getElementById("ven").getElementsByTagName('img');
    tl.call(removeElement("#merc"));
    tl.from("#ven",1,{x:-2000*Math.random(),y:2000*Math.random(),opacity:0,scale:2});
    tl.from("#ven",0.5,{color:330033});
    return tl;
}
function third() {
    var tl = new TimelineMax();
    var x = document.getElementById("ear").getElementsByTagName('img');
    tl.call(removeElement("#ven"));
    tl.from("#ear",1,{x:-2000*Math.random(),y:-2000*Math.random(),opacity:0,scale:4});
    tl.from("#ear",0.5,{color:330033});
    return tl;
}
function fourth() {
    var tl = new TimelineMax();
    var x = document.getElementById("mars").getElementsByTagName('img');
    tl.call(removeElement("#ear"));
    tl.from("#mars",1,{x:2000*Math.random(),y:-2000*Math.random(),opacity:0,scale:5*Math.random()});
    tl.from("#mars",0.5,{color:330033});
    return tl;
}
function fifth() {
    var tl = new TimelineMax();
    var x = document.getElementById("jupi").getElementsByTagName('img');
    tl.call(removeElement("#mars"));
    tl.from("#jupi",1,{x:2000*Math.random(),y:2000*Math.random(),opacity:0,scale:2});
    tl.from("#jupi",0.5,{color:330033});
    return tl;
}
function sixth() {
    var tl = new TimelineMax();
    var x = document.getElementById("sat").getElementsByTagName('img');
    tl.call(removeElement("#jupi"));
    tl.from("#sat",1,{x:2000*Math.random(),y:-2000*Math.random(),opacity:0,scale:3*Math.random()});
    tl.from("#sat",0.5,{color:330033});
    return tl;
}
function seventh(){
    var tl = new TimelineMax();
    var x = document.getElementById("uran").getElementsByTagName('img');
    tl.call(removeElement("#sat"));
    tl.from("#uran",1,{x:-2000*Math.random(),y:2000*Math.random(),opacity:0,scale:6*Math.random()});
    tl.from("#uran",0.5,{color:330033});
    return tl;
}
function eigth() {
    var tl = new TimelineMax();
    var x = document.getElementById("nep").getElementsByTagName('img');
    tl.call(removeElement("#uran"));
    tl.from("#nep",1,{x:2000*Math.random(),y:-2000*Math.random(),opacity:0,scale:10*Math.random()});
    tl.from("#nep",0.5,{color:330033});
    return tl;
}
function startmaster(){
    var master = new TimelineMax({});
    master.add(first())
    master.add(second())
    master.add(third())
    master.add(fourth())
    master.add(fifth())
    master.add(sixth())
    master.add(seventh())
    master.add(eigth())
    
   ;
    
   master.duration(12);
    return master;
}