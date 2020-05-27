var i = 0;  // start point 
var images = [];
var time = 3000;

//imager list

images[0] = 'image/catgirl.jpg';
images[1] = 'image/dogeyes.jpg';
images[2] = 'image/mandog.jpg';

//change image

function changeImg()
{
 document.slide.src = images[i];

 if (i < images.length - 1) 
 {
 i++;
 }
 else 
 {
 i = 0;
 }
 setTimeout("changeImg()", time);
}

window.onload = changeImg;