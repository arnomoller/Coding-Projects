<?php

$dbhost = "localhost";
$dbuser = "root";
$dbpass = "";
$dbname = "fe_login_page";

if(!$con = mysqli_connect($dbhost,$dbuser,$dbpass,$dbname))
{
	
	die("Failed to establish connection!");

}
else{
	echo("Connection has been established!");
}
?>