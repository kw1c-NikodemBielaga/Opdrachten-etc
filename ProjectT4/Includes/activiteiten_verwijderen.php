<?php
/**
 * User: N.Bielaga
 * Date: 6.06.2024
 * File: Praktijkopdracht4
 */
?>
<?php
session_start();
if (!isset($_SESSION['username']))
{
    header("Location: inlogpage.php");
    exit(); // Zorg ervoor dat er geen code meer wordt uitgevoerd na de redirect
}
?>
<?php
//Includen van database functies
include "../Includes/functionsdb.php";

//Starten van een database connectie
startConnection("SportAcademie");

//ID ophalen van de aangeklikte pokemon
$activityName = $_GET["activityName"];

//Delete query
$query = "DELETE FROM Activity WHERE [Name] = '$activityName';";


$rowsAffected = executeInsertQuery($query);

if($rowsAffected > 0)
{
    echo "Succesvol verwijderd.";
}

else
{
    echo "Er is iets misgegaan";
}

echo "<a href='../index.php'>Ga terug naar overzicht</a>";