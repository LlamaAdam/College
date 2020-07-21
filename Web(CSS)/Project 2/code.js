function myList() {
    var input, filter, ul, li, a, i;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    ul = document.getElementById("myUL");
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0];
        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";

        }
    }
}
var pics = ["Images/llama-clipart-1.png", "Images/Narwhal.jpg", "Images/Penguin.jpg"];
var counter = -1;
function imagechange(){
    counter++;
    if(counter>pics.length-1){
        counter=0
    }
    setTimeout("imagechange()", 10000);
    d= new Date();
    var months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    fd = months[d.getMonth()];
    fd +=" ";
    fd += d.getDate();
    fd +=", ";
    fd += d.getFullYear();
    fd += ". "
    x = d.getHours();
    if(x <= 9){
        fd += "0";
        fd += x;
    }
    else{
        fd += d.getHours()
    }
    fd +=":";
    y = d.getMinutes();
    if(y <= 9){
        fd += "0";
        fd += y;
    }
    else{
        fd += d.getMinutes()
    } 
    document.getElementById("date").innerHTML = fd;
    document.getElementById('adImage').src=pics[counter];
}

d= new Date();
var months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

var cart = ["Images/stuffFrog.jpeg", "Images/stuffZebra.jpeg", "Images/stuffLlama.jpeg", "Images/stuffPenguin.jpeg", "Images/stuffNarwhal.jpeg"];
var cost = [10.99, 11.99, 12.99, 13.99, 14.99];
function hidden() {
    var x = document.getElementById("data");
    x.style.display = "none";
}
function hideFrog() {
    var z = document.getElementById("frog");
    z.style.display = "block";
    hidden();
}
function hideZebra() {
    var z = document.getElementById("zebra");
    z.style.display = "block";
    hidden();
}
function hideLlama() {
    var z = document.getElementById("llama");
    z.style.display = "block";
    hidden();
}
function hidePeng() {
    var z = document.getElementById("peng");
    z.style.display = "block";
    hidden();
}
function hideNarw() {
    var z = document.getElementById("narw");
    z.style.display = "block";
    hidden();
}

var i = 0;
var myFormData = [];
function myform() {
 
    var  text, fLen,  box;
    document.getElementById('start').style.display = 'none'; 
    document.getElementById('next').style.display = 'block';   
    form_questions = ["1. Did you like todays vist",
                      "2. What didn't you like",
                      "3. Will you come again" ,
                      "4. What was the worst animal?",
                      "5. Who was the worst person?"
                     ];
    fLen = form_questions.length;
    text = form_questions[i];
    button_value =  document.getElementById("start").value;

       if(button_value == "start") {
            document.getElementById("question").innerHTML = text; 
            box = "<input type=text id=q"+i
            box +=">"
            document.getElementById("textbox").innerHTML = box; 
            document.getElementById("start").value = "void";

       } else {
            idname="q"+i;
            var value1 = document.getElementById("q"+i).value;  
            
            myFormData.push(value1);  //put to the array
            
            i=i+1;
                if(i > fLen-1){
                  document.getElementById('next').style.display = 'none'; 
                  document.getElementById('textbox').style.display = 'none'; 
                  document.getElementById('sbutton').style.display = 'block'; 
                }  
           text = form_questions[i];
           document.getElementById("question").innerHTML = text; 
           if (text == undefined) { 
               document.getElementById("question").innerHTML = "";
           }
            box = "<input type=text id=q"+i
            box +=">"
            document.getElementById("textbox").innerHTML = box; 
       }
}

function carts(x,y) 
{ 
    //X is price and y is quanity.

    var subTotal = x * y;
    var shipping = 50;
    var tax_d = subTotal * 0.1;
    var tax = tax_d.toFixed(2);
    var total = subTotal + tax_d + shipping;
    var total_i = total.toFixed(2);
    
    
    document.getElementById("subTotal").innerHTML = "Sub Total: " + "$" + subTotal;
    document.getElementById("shipping").innerHTML = "Shipping: " + "$" + shipping;
    document.getElementById("tax").innerHTML = "Tax: " + "$" + tax;
    document.getElementById("total").innerHTML = "Total: " + "$" + total_i;
   
} 
function frogpur(){
    var a = cost[0];
    var b = document.getElementById("qty1").value;
    carts(a,b);
    
}
function zebrapur(){
    var a = cost[1];
    var b = document.getElementById("qty2").value;
    carts(a,b);
    
}
function llamapur(){
    var a = cost[2];
    var b = document.getElementById("qty3").value;
    carts(a,b);
    
}
function narwpur(){
    var a = cost[4];
    var b = document.getElementById("qty5").value;
    carts(a,b);
    
}
function pengpur(){
    var a = cost[3];
    var b = document.getElementById("qty4").value;
    carts(a,b);
}

var Llama = ["Images/Llama.jpg", "Images/Llama2.jpg", "Images/Llama3.jpg"];
var cow = ["Images/Cow.jpg", "Images/Cow2.jpg", "Images/Cow3.jpg"];
var Horse = ["Images/Horse.jpg", "Images/Horse2.jpg", "Images/Horse3.jpg"];
var Hyena = ["Images/Hyena.jpg", "Images/Hyena2.jpg", "Images/Hyena3.jpg"];
var Lion = ["Images/Lion.jpg", "Images/Lion2.jpg", "Images/Lion3.jpg"];
var Giraffe = ["Images/Giraffe.jpg", "Images/Giraffe2.jpg", "Images/Giraffe3.jpg"];
var Velociraptor = ["Images/Velociraptor.jpg", "Images/Velociraptor2.jpg", "Images/Velociraptor3.jpg"];
var Groot = ["Images/Groot.jpg", "Images/Groot2.jpg", "Images/Groot3.jpg"];
var Krypto = ["Images/Krypto.jpg", "Images/Krypto2.jpg", "Images/Krypto3.jpg"];

piccounter=0;
function llup(){
    piccounter++;
    if(piccounter>Llama.length-1){
        piccounter=0;
    }
    document.getElementById('Llamapic').src=Llama[piccounter];
}
function lldw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('Llamapic').src=Llama[piccounter];
}

function coup(){
    piccounter++;
    if(piccounter>cow.length-1){
        piccounter=0;
    }
    document.getElementById('Cowpic').src=cow[piccounter];
}
function codw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('Cowpic').src=cow[piccounter];
}

function houp(){
    piccounter++;
    if(piccounter>Horse.length-1){
        piccounter=0;
    }
    document.getElementById('horpic').src=Horse[piccounter];
}
function hodw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('horpic').src=Horse[piccounter];
}
function hyup(){
    piccounter++;
    if(piccounter>Hyena.length-1){
        piccounter=0;
    }
    document.getElementById('hyepic').src=Hyena[piccounter];
}
function hydw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('hyepic').src=Hyena[piccounter];
}
function liup(){
    piccounter++;
    if(piccounter>Lion.length-1){
        piccounter=0;
    }
    document.getElementById('liopic').src=Lion[piccounter];
}
function lidw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('liopic').src=Lion[piccounter];
}
function giup(){
    piccounter++;
    if(piccounter>Giraffe.length-1){
        piccounter=0;
    }
    document.getElementById('giapic').src=Giraffe[piccounter];
}
function gidw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('giapic').src=Giraffe[piccounter];
}
function veup(){
    piccounter++;
    if(piccounter>Velociraptor.length-1){
        piccounter=0;
    }
    document.getElementById('velpic').src=Velociraptor[piccounter];
}
function vedw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('velpic').src=Velociraptor[piccounter];
}
function grup(){
    piccounter++;
    if(piccounter>Groot.length-1){
        piccounter=0;
    }
    document.getElementById('gropic').src=Groot[piccounter];
}
function grdw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('gropic').src=Groot[piccounter];
}
function kyup(){
    piccounter++;
    if(piccounter>Krypto.length-1){
        piccounter=0;
    }
    document.getElementById('krypic').src=Krypto[piccounter];
}
function kydw(){
    if(piccounter <= 0){
        piccounter=3;
    }
    piccounter--;
    document.getElementById('krypic').src=Krypto[piccounter];
}

var foodweight = [10, 25, 15, 4];
    var animal;
    var food;
function feedanimals(){
    var choicea=document.getElementsByName('animal');
    var choiceb=document.getElementsByName('food');
    var totalfood = 0;
    var x;
    for(var i = 0; i < choicea.length; i++){
        if(choicea[i].checked){
            animal = choicea[i].value;
        }
    }
    for(var i = 0; i < choiceb.length; i++){
        if(choiceb[i].checked){
            food = choiceb[i].value;
        }
    }
    console.log(animal);
    console.log(food);
    if(animal == 'a' && food == 'b'){
        var foodqty=document.getElementById('foodqty').value;
        totalfood = foodqty * 10;
        console.log(foodqty);
        x = "The cow will need " + totalfood + " lbs of corn for " + foodqty + " servings.";
        document.getElementById("results").innerHTML = x;
        
    }
    else if(animal == 'b' && food == 'a'){
        var foodqty=document.getElementById('foodqty').value;
        totalfood = foodqty * 25;
        console.log(foodqty);
        x = "The lion will need " + totalfood + " lbs of meat for " + foodqty + " servings."
        document.getElementById("results").innerHTML = x;
    }
    else if(animal == 'c' && food == 'c'){      
        var foodqty=document.getElementById('foodqty').value;
        totalfood = foodqty * 15;
        console.log(foodqty);
        x = "The seal will need " + totalfood + " fish for " + foodqty + " servings."
        document.getElementById("results").innerHTML = x;
    }
    else if(animal == 'd' && food == 'd'){
        var foodqty=document.getElementById('foodqty').value;
        totalfood = foodqty * 4;
        console.log(foodqty);
        x = "The elephent will need " + totalfood + " barrels of hay for " + foodqty + " servings.";
        document.getElementById("results").innerHTML = x;
    }
    else {
        x="You chose poorly.";
        document.getElementById("results").innerHTML = x;
    }
    
}