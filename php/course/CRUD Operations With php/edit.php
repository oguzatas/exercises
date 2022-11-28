<?php require_once 'connect.php'; ?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Wilkommen zie</title>
</head>
<body>

<h1>Database PDO Edit</h1>
<hr>

<?php 



		$bilgilerimask=$db->prepare("SELECT * from bilgilerim WHERE bilgilerim_id=id");
	    $bilgilerimask->execute(array(

	    	'id'=$_GET['bilgilerim_id']
	    ));

	    $bilgilerimpull=$bilgilerimask->fetch(PDO::FETCH_ASSOC); 

		
	

 ?>

<form> action="islem.php" method="POST"

	<input type="text" required="" name="bilgilerim_ad" value="<?php echo $bilgilerimpull['bilgilerim_name'] ?>">
	<input type="text" required 	name="bilgilerim_soyad" value="<?php echo $bilgilerimpull['bilgilerim_surname'] ?>">
	<input type="text" required="" name="bilgilerim_mail" value="<?php echo $bilgilerimpull['bilgilerim_mail'] ?>">
	<input type="text" required="" name="bilgilerim_age" value="<?php echo $bilgilerimpull['bilgilerim_age'] ?>">

	<input type="hidden" value="<?php echo $bilgilerimpull['bilgilerim_id']?>"  name="bilgilerim_id">
	<button type="submit" name="update">Update The Form</button>

	</form>



	<?php 



</body>
</html>