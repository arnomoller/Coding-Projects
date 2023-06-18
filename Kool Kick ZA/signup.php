<?php
session_start();

	include("connection.php");
	include("functions.php");
	
	if($_SERVER['REQUEST_METHOD'] == "POST")
	{
		
		//something was posted
		$FirstName = $_POST['FirstName'];
		$LastName = $_POST['LastName'];
		$password = $_POST['password'];
	}
		if(!empty($FirstName) && !empty($LastName) && !empty($password) && !is_numeric($FirstName) && !is_numeric($LastName))
		{
		
			//save to database
			$user_id = random_num(20);
			$query = "INSERT INTO users (FirstName, LastName, password) VALUES ('$FirstName', '$LastName', '$password')";
			
			mysqli_query($con, $query);
			
			header("Location : login.php");
			die;
		}else
		{
			echo("Please enter valid information!");
		}
	
?>

<!DOCTYPE html>
<html>
<head>
	<title>Sign-Up</title>
</head>
<body>

<style type="text/css">
.text{
	
	height: 25px;
	border-radius: 5px;
	padding: 4px;
	border: solid thin #aaa;
	width: 100px;
}

.button{
	padding: 10px;
	width: 100px;
	color: white;
	background-color: lightblue;
	border: none;
}

.box{
	background-color: grey;
	margin: auto;
	width: 300px;
	padding: 20px;
}
</style>

<div class="box">

	<form>
		<div style="font-size: 20px;margin: 10px;color: white;">Sign-Up</div>
		
		<div class="text">
			<input type="text" name="FirstName" placeholder="First Name"><br><br>
		</div>
		<div class="text">
			<input type="text" name="LastName" placeholder="Last Name"><br><br>
		</div>
		<div class="text">
			<input type="password" name="password" placeholder="Password"><br><br>
		</div>
		
		<input class="button" type="submit" value="Sign-Up"><br><br>
		
		<a href="login.php">Click to Login</a><br><br>
	</form>
</div>

</body>	
</html>