<?php

$juego = $_POST["juego"];

if(!empty($_POST["juego"])){
	switch($juego)
	{
		case 1://LOL
			echo '<option value="1">Personaje de lol 1</option>';
			echo '<option value="2">Personaje de lol 2</option>';
			echo '<option value="3">Personaje de lol 3</option>';
			break;
		case 2://jalisco
			echo '<option value="4">araña gorda</option>';
			echo '<option value="5">comida</option>';
			echo '<option value="6">kjfrshetrh</option>';
			break;
		case 3://edo mex
			echo '<option value="7">zapopan</option>';
			echo '<option value="8">sapo lopez</option>';
			echo '<option value="9">Ñdeefse</option>';
			break;
		default:
			echo '<option value="">(municipios o alcaldías no disponibles)</option>';
			
	}
}

?>