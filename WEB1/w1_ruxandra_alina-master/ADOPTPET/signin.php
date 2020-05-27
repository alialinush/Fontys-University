<?php

// log in
$name = $_POST['emaillogin'];
$submittedword = $_POST['passwordlogin'];

$username ='dbi416830';
$dbpassword = 'Database1';
$dbname = 'dbi416830';
 // Create DB connection
$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname='.$dbname, $username,  $dbpassword);

$sql = "select * from login where email=:emaillogin and password=:passwordlogin;";

$stmt = $conn->prepare($sql);
$stmt->execute([':emaillogin'=> $name, ':passwordlogin'=>$submittedword]);

$result = $stmt->fetchAll();

if (count($result)== 1)
{

//  go to the secret page

  session_start();
  $_SESSION['loggedin'] = 'true';

  setcookie('error','');
  header('Location: index.php');
}
else
{
// credentials wrong => go back to welcome
  //setcookie('error',"Login credentials wrong");
  header("Location: register.php");
}
?>
