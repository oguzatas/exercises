

<?php 

require_once 'connect.php';

if (isset($_POST['insertoperation'])) {

	// this architecture prevents the sql injection. Proper and safe way to insert
	$save=$db->prepare("INSERT into bilgilerim set

		bilgilerim_ad=:bilgilerim_ad,
		bilgilerim_soyad=:bilgilerim_soyad,
		bilgilerim_mail=:bilgilerim_mail,
		bilgilerim_yas=:bilgilerim_yas,
		
		");

	$insert=$save->execute(array(

		bilgilerim_ad=>		$_POST['bilgilerim_ad'],
		bilgilerim_soyad=>	$_POST['bilgilerim_soyad'],
		bilgilerim_mail=>	$_POST['bilgilerim_mail'],
		bilgilerim_yas=>	$_POST['bilgilerim_yas'],

	));

	if ($insert) {

		echo "insert success";

		Header("Location:index.php?stats=ok");
	}

	else {
		echo "insert failed";

		Header("Location:index.php?stats=failed");
	}
}



if (isset($_POST['updateoperation'])) {

	
	$save=$db->prepare("UPDATE bilgilerim set

		bilgilerim_ad=:bilgilerim_ad,
		bilgilerim_soyad=:bilgilerim_soyad,
		bilgilerim_mail=:bilgilerim_mail,
		bilgilerim_yas=:bilgilerim_yas,
		where bilgilerim_id={$_POST['bilgilerim_id']}
		");

	$insert=$save->execute(array(

		bilgilerim_ad=>		$_POST['bilgilerim_ad'],
		bilgilerim_soyad=>	$_POST['bilgilerim_soyad'],
		bilgilerim_mail=>	$_POST['bilgilerim_mail'],
		bilgilerim_yas=>	$_POST['bilgilerim_yas'],

	));

	if ($insert) {

		echo "insert success";

		Header("Location:edit.php?stats=ok&bilgilerim_id=$bilgilerim_id");
		exit;
	}

	else {
		echo "insert failed";

		Header("Location:edit.php?stats=failed&bilgilerim_id=$bilgilerim_id");
		exit;
	}
}

if ($_GET['bilgilerimsil']=="ok") {

	$delete=$db->prepare("DELETE from bilgilerim where bilgilerim_id=:id")
	$control=$delete->execute(array(

		'id' => $_GET['bilgilerim_id']

	));


	if ($control) {

		echo "insert success";

		Header("Location:edit.php?stats=ok");
		exit;
	}

	else {
		echo "insert failed";

		Header("Location:edit.php?stats=failed");
		exit;
	}

}

 ?>