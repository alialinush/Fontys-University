<!DOCTYPE html>

<html>
<head>
	<title></title>
	<link rel="stylesheet" type="text/css" href="contact.css">
</head>
<body>
 <div class="container1">
	<div class="header">
  <h1> AdoptPet <img src="image/logo.png" alt="logo" />
  <div class="btn-registration">
		<button onclick="window.location.href = 'register.php';">Log In / Register</button>
		<?php
		include_once 'menubar.html';
		?>
     </div>
      </h1>
   </div>

 <div class="content">
 	 <!-- <h1>Contact Us</h1> -->
 </div>
  <!-- JAVASCRIPT  -->
       <script type="text/javascript">
          function validate()
           {
              var text = document.getElemntById("text1").value;

              var regx = /^([a-zA-Z0-9\.-]+)@([a-zA-Z0-9\.-]+).([a-z]{2,20})$/;
                if (regx.test(text))
                 {
                  document.getElemntById("lbltext").innerHTML="Valid";
                  document.getElemntById("lbltext").style.visibility="visible";
                  document.getElemntById("lbltext").style.color="green";
                }
                 else
                 {
                   document.getElemntById("lbltext").innerHTML="Invalid";
                   document.getElemntById("lbltext").style.visibility="visible";
                   document.getElemntById("lbltext").style.color="red";

                 }

          }

       </script>

         <!--  END JAVASCRIPT  -->
      <div class="filter">
        <div class="container">
          <div class="desc">
             <h1>Contact</h1>
             <p>
               Address: Rachelsmolen 1 .
             </p>
             <div class="googlemaps">
               <img src="image/maps.gif">
             </div>
          </div>
					<!-- this is how to connect php -->
					<form method="POST" action="maincontact.php">
            <div class="form">
              <h2>Type your message</h2>
              <form>
                 <input type="text" name="name" placeholder="Name"> <br>
                 <input type="text" name="email" placeholder="E-mail">

                 <br>

                 <textarea name="message" placeholder="Message"></textarea> <br>


				  <button type="submit" name="submit">SEND MAIL</button>
              </form>
            </div>
          </form>

        </div>
      </div>



    <h3>Privacy Policy | AdoptPet-All Rights Reserved</h3>
        </div>

</body>
</html>
