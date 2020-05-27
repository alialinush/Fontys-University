
<html lang="en-US">
<head>
	<title>AdoptPet</title>
	<link rel="stylesheet" type="text/css" href="register.css">
</head>
<body>
	<div class="header">
  <h1> AdoptPet <img src="image/logo.png" alt="logo" />
  <!-- <div class="btn-registration">
  	<button>Log In</button>
     </div> -->
      </h1>
			<?php
			include_once 'menubar.html';
			?>
   </div>

        <div class="login-box">
          <div class="left-box">
            <h2>Sign Up</h2>
<form method="POST" action="signup.php">
 <input type="text" name="Username" placeholder="Last Name + First Name" />
      <input type="text" name="email" placeholder="email" />
       <input type="password" name="password" placeholder="Password" />
        <input type="password" name="password2" placeholder="Retype Password" />
           <!-- <input type="submit" name="signup-button" value="Sign Up"> -->
					 <button type="submit" class="register" name="register">Submit
					</button>
</form>
            </div>

              <div class="right-box">
                <span class="signinwith">Sign In</span>
                <!--
        <input type="text" name="email" placeholder="email" />
       <input type="Password" name="Password" placeholder="Password">
         -->
				 <form method="POST" action="signin.php">
            <input type="text" name="emaillogin" placeholder="email" />
       <input type="password" name="passwordlogin" placeholder="Password" />
			 <button type="submit" class="login" name="login">Login
			 </button>
			 </form>
              </div>
                <div class="or">OR</div>


        </div>
        <script type="text/javascript">
        var $email = $('form input[name="email');
var re = /^(([^<>()[]\.,;:s@"]+(.[^<>()[]\.,;:s@"]+)*)|(
".+"))@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}])|(([a-zA
-Z-0-9]+.)+[a-zA-Z]{2,}))$/igm;
if ($email.val() == '' || !re.test($email.val()))
{
    alert('Please enter a valid email address.');
    return false;
}
</script>
  </body>
  </html>
