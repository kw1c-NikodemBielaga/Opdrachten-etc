<?php
/**
 * User: N.Bielaga
 * Date: 06.03.2024
 * File: Praktijkopdracht
 */
?>
<!DOCTYPE html>
<html>
<head>
    <title>
        Template Javascript
    </title>
    <meta charset="utf-8">
    <meta name=viewport content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="../stylesheet/style.css">
    <script src="../Script/script.js" defer></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA==" crossorigin="anonymous" referrerpolicy="no-referrer"/>
</head>
<body>
<?php
include "../Include/navigatiecalculator.php"
?>
<?php
// Functie om calorieën te berekenen voor vrouwen
function calculateCaloriesForWomen($gewicht, $lengte, $leeftijd)
{
    return 447.593 + (9.247 * $gewicht) + (3.098 * $lengte) - (4.330 * $leeftijd);
}

// Functie om calorieën te berekenen voor mannen
function calculateCaloriesForMen($gewicht, $lengte, $leeftijd)
{
    return 88.362 + (13.397 * $gewicht) + (4.799 * $lengte) - (5.677 * $leeftijd);
}

// Controleren of het formulier is verzonden
if(isset($_POST['submit'])) {
    $geslacht = $_POST['geslacht'];
    $gewicht = $_POST['gewicht'];
    $lengte = $_POST['lengte'];
    $leeftijd = $_POST['leeftijd'];

    if($geslacht == 'vrouw')
    {
        $calories = calculateCaloriesForWomen($gewicht, $lengte, $leeftijd);
    } elseif($geslacht == 'man')
    {
        $calories = calculateCaloriesForMen($gewicht, $lengte, $leeftijd);
    }
    ?>
    <div>
        <h2 class="resultaat">Resultaat:</h2>
        <p class="resultaat">Je mag <?php echo round($calories); ?> calorieën per dag eten zonder aan te komen in gewicht.</p>
    </div>
    <?php
}
?>
<div class="calculator">
    <h2>Calorie Calculator</h2>
    <!-- Een sectie voor de caloriecalculator met een titel -->
    <form method="post" action="">
        <!-- Een formulier met de methode "post" en een lege actie (wat betekent dat het formulier naar dezelfde pagina wordt gestuurd) -->
        <label for="geslacht">Geslacht:</label>
        <!-- Een label voor het geslacht selectieveld -->
        <div class="gender-select">
            <!-- Een div om de radioknoppen voor geslacht te groeperen -->
            <input type="radio" id="geslacht_vrouw" name="geslacht" value="vrouw" checked>
            <!-- Radioknop voor het geslacht "vrouw" met een standaardselectie -->
            <label for="geslacht_vrouw">Vrouw</label>
            <!-- Label voor de radioknop voor het geslacht "vrouw" -->
            <input type="radio" id="geslacht_man" name="geslacht" value="man">
            <!-- Radioknop voor het geslacht "man" -->
            <label for="geslacht_man">Men</label>
            <!-- Label voor de radioknop voor het geslacht "man" -->
        </div>
        <label for="gewicht">Gewicht (kg):</label>
        <!-- Label voor het invoerveld voor het gewicht in kg -->
        <input type="number" name="gewicht" id="gewicht" min="0" max="500" step="1">
        <!-- Invoerveld voor het gewicht met beperkingen (minimale waarde 0, maximale waarde 500 en stapgrootte van 1) -->
        <label for="lengte">Lengte (cm):</label>
        <!-- Label voor het invoerveld voor de lengte in cm -->
        <input type="number" name="lengte" id="lengte" min="0" max="300" step="1">
        <!-- Invoerveld voor de lengte met beperkingen (minimale waarde 0, maximale waarde 300 en stapgrootte van 1) -->
        <label for="leeftijd">Leeftijd:</label>
        <!-- Label voor het invoerveld voor de leeftijd -->
        <input type="number" name="leeftijd" id="leeftijd" min="0" max="150" step="1">
        <!-- Invoerveld voor de leeftijd met beperkingen (minimale waarde 0, maximale waarde 150 en stapgrootte van 1) -->
        <input type="submit" name="submit" value="Bereken">
        <!-- Knop om het formulier te verzenden met de waarde "Bereken" -->
    </form>
    <div class="resultaat" id="resultPlaceholder"></div>
</div>
</body>
</html>