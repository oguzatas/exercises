<?php require_once 'connect.php'; ?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Wilkommen zie</title>
</head>
<body>

<h1>Database PDO operations</h1>
<hr>

<form> action="islem.php" method="POST"

	<input type="text" required="" name="bilgilerim_ad" placeholder="Please Enter Your Name">
	<input type="text" required 	name="bilgilerim_soyad" placeholder="Enter Your Surname">
	<input type="text" required="" name="bilgilerim_mail" placeholder="Enter Your E-Mail">
	<input type="text" required="" name="bilgilerim_age" placeholder="Enter Your Age">
	<button type="submit" name="insertoperation">Enter</button>

	</form>

	<br>

	<h4>List of the saves</h4>
	<hr>

	<?php 

			//  standart single data pull operation
	// $bilgilerimask=$db->prepare("SELECT * from bilgilerim");
	// $bilgilerimask->execute();

	// $bilgilerimpull=$bilgilerimask->fetch(PDO::FETCH_ASSOC);

	// echo "<pre>"
	// print_r($bilgilerimpull);
	// echo "<pre>"

	// $bilgilerimpull['bilgilerim_ad'];

			//Using while to get all data
	
	// while($bilgilerimpull=$bilgilerimask->fetch(PDO::FETCH_ASSOC)) {

	// 	$bilgilerimask=$db->prepare("SELECT * from bilgilerim");
	//     $bilgilerimask->execute();

	// 	echo $bilgilerimpull['bilgilerim_ad']; echo "<br>" 
	// }

			// Using WHERE to pull special data
	// while($bilgilerimpull=$bilgilerimask->fetch(PDO::FETCH_ASSOC)) {

	// 	$bilgilerimask=$db->prepare("SELECT * from bilgilerim WHERE bilgilerim_yas=age");
	//     $bilgilerimask->execute(

	//     	'age'=32
	//     );

	// 	echo $bilgilerimpull['bilgilerim_ad']; echo "<br>" 
	// }


	 ?>

	 <table style="width: 60%" border="1">
	 	
	 	<tr>
	 		<th>ID</th>
	 		<th>Name</th>
	 		<th>Surname</th>
	 		<th>Mail</th>
	 		<th>Age</th>
	 		<th width="50">Operations</th>
	 	</tr>

	 	<?php  

	 	 

	 	$bilgilerimask=$db->prepare("SELECT * from bilgilerim");
	     $bilgilerimask->execute(

	     	'age'=32
	     );

	 	while($bilgilerimpull=$bilgilerimask->fetch(PDO::FETCH_ASSOC)) { ?>
	 


	 	<tr>
	 		<td><?php echo $bilgilerimpull['bilgilerim_id'] ?></td>
	 		<td><?php echo $bilgilerimpull['bilgilerim_name'] ?></td>
	 		<td><?php echo $bilgilerimpull['bilgilerim_surname'] ?></td>
	 		<td><?php echo $bilgilerimpull['bilgilerim_mail'] ?></td>
	 		<td><?php echo $bilgilerimpull['bilgilerim_age'] ?></td>
	 		<td align="center"> <a href="edit.php?bilgilerim_id=<?php echo $bilgilerimpull['bilgilerim_id] ?>"><button>Edit</button></td>
	 		<td align="center"> <a href="islem.php?bilgilerim_id=<?php echo $bilgilerimpull['bilgilerim_id] ?>"><button>Delete</button></td>
	 	</tr>

	 <?php } ?>

	 </table>
	 	

</body>
</html>