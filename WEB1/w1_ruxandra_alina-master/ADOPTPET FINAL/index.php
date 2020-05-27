<!DOCTYPE html>
<html lang="en-US">
<head>
  <meta name="viewport" content="width=device-width, initial-scale=1">
	<title>AdoptPet</title>
	<link rel="stylesheet" type="text/css" href="css.css">
  <script type="text/javascript" src="myjs.js"></script>
</head>
<body>
	<div class="header">
      <h1 id="logo"> AdoptPet <img src="image/logo.png" alt="logo" /></h1>
      <div id="btn-reg" class="btn-registration">
    	   <button onclick="window.location.href = 'register.php';">Log In / Register</button>
      </div>
    <?php
    include_once 'menubar.html';
    ?>
  </div>
  <div id="mainContent">
    <div class="mainPetPics">
      <img src="image/dogcat2.png" alt="dog and and">
    </div>
    <div id="pagewrap" style="clear:both">
      <img id="slideshow" name="slide" style=
      "position:relative;
       top:-124px;
       z-index:-1;
       width:100%;">
    </div>
  <div class="footer" style="clear:both">
    <p>Privacy Policy 2019| AdoptPet-All Rights Reserved </p>
  </div>

</body>
</html>
