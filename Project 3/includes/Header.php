
<?php
//    Autheur:         Ties de Bruijn
//    Aanmaakdatum:   <02-23-2024>
//
//    <Namaak van de Veba-solar site>
//the base url is the url to the root of the website's folder
$BaseURL = "http://www.veba-solar.nl/";
?>
<!-- Navigation List -->
<ul>
    <li>
        <a href="<?php echo $BaseURL;?>">Home</a>
    </li>
    <li>
        <a href="#">Onze panelen</a>
    </li>
    <li>
        <a href="#">Offerte aanvragen</a>
    </li>
    <li>
        <a href="#">Contact</a>
    </li>
    <li>
        <a href="<?php echo $BaseURL;?>pages/zonneCheck.php">ZonneCheck</a>
    </li>
</ul>
<!-- Hamburger Menu Button -->
<span onclick="SwitchBurgerMenuState();" id="BurgerButton">
    <div></div>
    <div></div>
    <div></div>
</span>
<!-- Hamburger Nav-->
<span id="Hamburger">
    <ul>
    <li>
        <a href="#">Onze panelen en werkwijze</a>
    </li>
    <li>
        <a href="#">Duurzaamheid</a>
    </li>
    <li>
        <a href="#">Vraag een offerte aan</a>
    </li>
</ul>
</span>

