<?php

//register
$name = $_POST['Username'];
$submittedword = $_POST['password'];
$email = $_POST['email'];
$retypepassword = $_POST['password2'];
$servername = 'studmysql01.fhict.local';
$username ='dbi416830';
$dbpassword = 'Database1';
$dbname = 'dbi416830';
 // Create DB connection
try {
$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname='.$dbname, $username,  $dbpassword);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  //$hash2 = password_hash($submittedword, PASSWORD_DEFAULT);
	$sql = "INSERT INTO login (Name,email,password, Retype_password) VALUES('$name', '$email', '$submittedword', '$retypepassword')";
    // use exec() because no results are returned
    $conn->exec($sql);
    // echo "Your account was created! You can login now!";
    setcookie('error',"Your account was created! You can login now!");
    header("Location: register.php");
    }
catch(PDOException $e)
    {
    echo $sql . "<br>" . $e->getMessage();
    }

$conn = null;
?>
