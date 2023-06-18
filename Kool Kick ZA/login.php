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
	
		if(!empty($FirstName) && !empty($LastName) && !empty($password) && !is_numeric($FirstName) && !is_numeric($LastName))
		{
			//read from database
			$query = "select * from users where FirstName = '$FirstName' limit 1";
			$query = "select * from users where LastName = '$LastName' limit 1";
			$result = mysqli_query($con, $query);
		
			if($result)
			{
				if($result && mysqli_num_rows($result) > 0)
				{
					$user_data = mysqli_fetch_assoc($result);
			
					if($user_data['password'] === $password) 
					{
					
						$_SESSION['user_id'] = $user_data['user_id'];
						header("Location : home.html");
						die;
					}	
				}
			}
			echo "Wrong First Name or Last Name or Password";	
		}else
		{
			echo "Wrong First Name or Last Name or Password";
		}
		
	}	
?>
<!DOCTYPE html>
<html>
<head>
	<title>Login</title>
</head>
<body>

	<style type="text/css">
		#text{
			
			height: 25px;
			border-radius: 5px;
			padding: 4px;
			border: solid thin #aaa;
			width: 100px;
		}
	
	#button{
		padding: 10px;
		width: 100px;
		color: white;
		background-color: lightblue;
		border: none;
	}
	
	#box{
		background-color: grey;
		margin: auto;
		width: 300px;
		padding: 20px;
	}
	</style>
	
	<div id="box">
	
		<form method = "post">
			<div style="font-size: 20px;margin: 10px;color: white;">Login</div>
			
			<div class="text">
				<input type="text" name="FirstName" placeholder="First Name"><br><br>
			</div>
			<div class="text">
				<input type="text" name="LastName" placeholder="Last Name"><br><br>
			</div>
			<div class="text">
				<input type="password" name="password" placeholder="Password"><br><br>
			</div>
			<input class="button" type="submit" value="Login"><br><br>
			
			<a href="signup.php">Click to Sign-Up</a><br><br>
		</form>
	</div>

</body>	
</html>