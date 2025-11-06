<?php
/**
 * User: N.Bielaga
 * Date: 06.03.2024
 * File: Praktijkopdracht
 */
?>
<div class="banner" id="banner">
    <img src="images/banner-virtuele-tour-pink.png" alt="Banner">
</div>
<!-- Het 'container' div-element dient als een wrapper voor de hele diavoorstelling. -->
<div class="container">
    <!-- De 'arrow l' div-element wordt gebruikt voor de linkernavigatiepijl. Wanneer erop wordt geklikt, wordt de 'prev()' functie aangeroepen. -->
    <div class="arrow l" onclick="prev()">

        <!-- In dit 'button' element wordt de linkernavigatiepijl weergegeven. Wanneer erop wordt geklikt, wordt de 'nextImage()' functie aangeroepen. -->
        <button class="popuparrow" onclick="nextImage()"><</button>
    </div>

    <!-- Elke 'slide' div-element bevat één dia van de diavoorstelling. -->
    <div class="slide">
        <div>
            <!-- Hier wordt de inhoud van de eerste dia weergegeven, inclusief een titel ('caption'), een subtitel ('caption1') en een knop ('orangebutton'). -->
            <p class="caption">BREEK RECORDS</p>
            <h3 class="caption1">P O W E R &nbsp; S T A T I O N</h3>
            <button class="orangebuttom">LEES MEER</button>
        </div>
    </div>

    <!-- Hier wordt de inhoud van de tweede dia weergegeven. -->
    <div class="slide">
        <div>
            <!-- Dit is de titel ('caption') en subtitel ('caption2') van de tweede dia, samen met een knop ('orangebutton'). -->
            <p class="caption">VECHT-&nbsp; EN <br> VERDEDIGINSSPORTEN</p>
            <h3 class="caption2">B O X I N G &nbsp; S T A T I O N</h3>
            <button class="orangebuttom">LEES MEER</button>
        </div>
    </div>
    <!-- Hier wordt de inhoud van de derde dia weergegeven. -->
    <div class="slide">
        <div>
            <!-- Dit is de titel ('caption') en subtitel ('caption3') van de derde dia, samen met een knop ('orangebutton'). -->
            <p class="caption">TRAINSTATIN073</p>
            <h3 class="caption3">1 &nbsp;O P &nbsp; 1 &nbsp; I N T R O D U C T I E</h3>
            <button class="orangebuttom">GRATIS AANVRAGEN</button>
        </div>
    </div>
    <div class="arrow r" onclick="next()">
        <button class="popuparrowl" onclick="nextImage()">></button>
    </div>
</div>
