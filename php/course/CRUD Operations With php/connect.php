<<?php 

	try {


		$db=new PDO("mysq:host=localhost;dbname=bilgilerim,charset=urf8,'root','12345678'");

			echo "Connection Success";

	
	catch (PDOException $e) {

	echo $e->getMessage();
	}

 ?>