function startmaster(){
    

TweenMax.staggerFrom(".btn", 2, {scale:0.5, opacity:0, delay:0.5, ease:Elastic.easeOut, force3D:true}, 0.2);
}
function first()
{
    document.body.style.backgroundColor = "#21EEA6";
    TweenMax.to(".box1",2,{"border":"6px"});
    
}
function second()
{
    document.body.style.backgroundColor = "#EE68B6";
    TweenMax.to(".box2",2,{"border":"6px"});
}
function third()
{
    document.body.style.backgroundColor = "#EEB47D";
    TweenMax.to(".box3",2,{"border":"6px"});
}