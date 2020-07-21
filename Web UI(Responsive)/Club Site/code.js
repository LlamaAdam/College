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

function openModal() {
  document.getElementById('myModal').style.display = "block";
}

// Close the Modal
function closeModal() {
  document.getElementById('myModal').style.display = "none";
}

var slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("demo");
  var captionText = document.getElementById("caption");
  if (n > slides.length) {slideIndex = 1}
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";
  dots[slideIndex-1].className += " active";
  captionText.innerHTML = dots[slideIndex-1].alt;
}
function show_div(div_id) {
    // hide all the divs
    document.getElementById('one').style.display = 'none';
    document.getElementById('two').style.display = 'none';
    document.getElementById('three').style.display = 'none';
    document.getElementById('four').style.display = 'none';
    document.getElementById('five').style.display = 'none';
    document.getElementById('six').style.display = 'none';
    document.getElementById('seven').style.display = 'none';
    document.getElementById('eight').style.display = 'none';
	//document.getElementById('part7').style.display = 'none';
    // show the requested div
    document.getElementById(div_id).style.display = 'block';
}
  function build_two(div_id) {
    // hide all the divs
    document.getElementById('one').style.display = 'none';
    document.getElementById('two').style.display = 'none';
    document.getElementById('three').style.display = 'none';
    document.getElementById('four').style.display = 'none';
    document.getElementById('five').style.display = 'none';
    document.getElementById('six').style.display = 'none';
	//document.getElementById('part7').style.display = 'none';
    // show the requested div
    document.getElementById(div_id).style.display = 'block';
  }
