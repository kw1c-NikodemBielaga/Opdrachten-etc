<?php
session_start();
if (!isset($_SESSION['username']))
{
    header("Location: inlogpage.php");
    exit(); // Zorg ervoor dat er geen code meer wordt uitgevoerd na de redirect
}
?>
<?php
/*
 */
if(!isset($_GET["activityName"]))
{
    header("Location: index.php");
    exit;
}

//Ophalen Id uit URL
$activityName = $_GET["activityName"];

//Includen van database functies
include "../Includes/functionsdb.php";

startConnection("SportAcademie");

//Query die Alle gevens ophaalt van de Activiteiten met het id $ActivityId.
$query = "SELECT * FROM Activity WHERE [Name] = '$activityName'";
echo $query;

$result = executeQuery($query);

$record = $result->fetch(PDO::FETCH_ASSOC);
if ($record === false)
{
    header("Location: index.php");
    exit;
}

// Controleer of het formulier is ingediend
if ($_SERVER['REQUEST_METHOD'] == 'POST')
{
    // Formuliergegevens ophalen
    $name = $_POST['name'];
    $start = $_POST['start'];
    $end = $_POST['end'];
    $location = $_POST['location'];

    // Query schrijven
    $queryUpdate = "UPDATE Activity
                    SET [Name] = '$name', [Start] = '$start', 
                    [End] = '$end', [Location] = '$location'
                    WHERE [Name] = '$activityName'";

    // Query uitvoeren
    $rowsAffected = executeInsertQuery($queryUpdate);
}
?>
<form method="post">
    <fieldset>
        <legend>Activiteiten bewerken</legend>
        <p>
            <label for="name">Name</label>
            <input type="text" name="name" id="name" value="<?php echo $record["Name"]; ?>">
        </p>
        <p>
            <label for="start">Start</label>
            <input type="text" name="start" id="start" value="<?php echo $record["Start"]; ?>">
        </p>
        <p>
            <label for="end">End</label>
            <input type="text" name="end" id="end" value="<?php echo $record["End"]; ?>">
        </p>
        <p>
            <label for="location">Location</label>
            <input type="text" name="location" id="location" value="<?php echo $record["Location"]; ?>">
        </p>


        <input type="submit" name="bewerken" value="Bewerk Activiteit toe">

    </fieldset>
</form>