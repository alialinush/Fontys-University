<!DOCTYPE html>
<meta charset="utf-8">
<meta name="viewport" content="width = device-width, initial-scale = 1">
<html>
<head>
	<title></title>
	<link rel="stylesheet" type="text/css" href="ourdogs.css">
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
      header("Location:register.php");
    }
    ?>
     </div>
      </h1>
   </div>


        <div id="pagewrap">
  <div class="gallery">
   <article class="image">
    <a href="tiffany.php"><img src="image/beagle.jpg"/></a>
    <p>Beagle</p>
   </article>

   <article class="image">
   <a href="blackpomeranian.php">
    <img src="image/blackpomeranian.jpg"/></a>
    <p>Black Pomeranian</p>
   </article>

   <article class="image">
   <a href="bulldog.php">
    <img src="image/bulldog.jpg"/></a>
    <p>Bulldog</p>
   </article>

   <article class="image">
   <a href="pug.php">
    <img src="image/pug.jpg"/></a>
    <p>Pug</p>
   </article>

   <article class="image">
   <a href="germansheep.php">
    <img src="image/germanshep.jpg"/></a>
    <p>German shepherd</p>
   </article>

   <article class="image">
   <a href="goldenretriever.php">
    <img src="image/goldenretriever.jpg"/></a>
    <p>Golden retriever</p>
   </article>

   <article class="image">
   <a href="husky.php">
    <img src="image/husky.jpg"/></a>
    <p>Husky</p>
   </article>

	<article class="image">
    <a href="pomeranian.php">
    <img src="image/pomeranian.jpg"/></a>
    <p>Pomeranian</p>
   </article>
  </div>
 </div>




</body>
</html>
