function nameFunc() {
    var x = document.getElementById("myText").value;
    document.getElementById("demo").innerHTML = "Hello " + x;
    
};

function nameFunc2() {
    var x = document.getElementById("myText").value;
    if (x == "Alice" || x == "Bob"){
        document.getElementById("demo2").innerHTML = "Hello " + x;
    }

    else{
        document.getElementById("demo2").innerHTML = "No greeting for you!"
    }
        
}