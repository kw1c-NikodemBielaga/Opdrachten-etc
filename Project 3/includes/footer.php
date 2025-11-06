<?php
//    Autheur:         Nikodem
//    Aanmaakdatum:   <2-4-2024>
//
//    <Namaak van de Veba-solar site>
?>
    <article>
        <div class="deel1">
            <img src="../images/Veba-Solar-Logo-Kleur.svg">
            <br>
            <br>
            Retselseweg 1
            <br>
            5473 HC Heeswijk Dinther
            <br>
            <br>
            <strong>T</strong>
            0413 – 74 50 30
            <br>
            <strong>E</strong>
            <a href="mailto:info@veba-solar.nl">info@veba-solar.nl</a>
            <br>
            <br>
            KvK 61497592
            <br>
            <br>
        </div>
        <div class="deel2">
            <p>
                Heeft u vragen of opmerkingen, wilt u een afspraak, of wilt u graag een offerte ontvangen? Neem dan contact met ons op.
                U kunt ook gebruik maken van onderstaand formulier,<br> wij nemen dan zo spoedig mogelijk contact met u op.
            </p>
            <form onsubmit="return checkform(this);" method="post" enctype="application/x-www-form-urlencoded" name="contact" id="contact">
                <input name="naam" type="text" required class="inputinschrijven" id="naam" placeholder="Naam">
                <input name="telefoonnummer" type="text" required class="inputinschrijven" id="telefoonnummer" placeholder="Telefoonnummer">
                <input name="email" type="email" required class="inputinschrijven" id="email" placeholder="E-mail">
                <textarea name="bericht" class="inputinschrijven" id="bericht" placeholder="Uw bericht"></textarea>
                <div class="clear"></div>
                <input class="knop" name="akkord" type="checkbox" required value="akkord">
                Ik ga akkoord met de
                <a style="text-decoration: underline;" href="https://www.veba-solar.nl/algemene-voorwaarden">Algemene voorwaarden</a>
                <br>
                <input name="verzenden" type="submit" class="input4 button" id="verzenden" value="Verzenden">
            </form>
        </div>
    </article>