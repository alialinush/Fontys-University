<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" type="text/css" href="ourcats.css">
	<title></title>
</head>
<body>
 	 <div class="container1">
	<div class="header">
  <h1> AdoptPet <img src="image/logo.png" alt="logo" />
  <div class="btn-registration">
  	<button onclick="window.location.href = 'register.php';">Log In / Register</button>
    <?php
    include_once 'menubar.html';
    session_start();
    $loggedin = $_SESSION['loggedin'];
    if (!isset($loggedin))
    {
        console.log("wtf");
        header("Location:register.php");
    }
    ?>
     </div>
      </h1>
   </div>


        <div id="pagewrap">
  <div class="gallery">
   <article class="image">
   <a href="bangalcat.php">
    <img src="image/bangalcat.jpg"/></a>
    <p>Bangal cat</p>
   </article>

   <article class="image">
   <a href="birmancat.php">
    <img src="image/birmacat.jpg"/></a>
    <p>Birman cat</p>
   </article>

   <article class="image">
   <a href="persian.php">
    <img src="image/persiancat.jpg"/></a>
    <p>Persian cat</p>
   </article>

   <article class="image">
   <a href="siames.php">
    <img src="image/siamesecat.jpg"/></a>
    <p>Siamese cat</p>
   </article>

   <article class="image">
   <a href="toytiger.php">
    <img src="image/toygercat.jpg"/></a>
    <p>Toyger cat</p>
   </article>

   <article class="image">
   <a href="sphynxcat.php">
    <img src="image/sphynxcat.jpg"/></a>
    <p>Sphynx cat</p>
   </article>


   </article>
  </div>
 </div>
</html>
