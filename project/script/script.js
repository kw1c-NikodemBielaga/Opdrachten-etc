/*
Auteurs:        Nikodem Bielaga   
Aanmaakdatum:   10.01.2024

Onderwerp:      Praktijk project
*/
document.addEventListener('DOMContentLoaded', function() 
{
    // Array met technische modules en behaalde cijfers
    const modules = 
    [
        { naam: "Plannen en Ontwerpen", cijfers: [9.3, 8.3, 4.4] },
        { naam: "Realiseren", cijfers: [8, 9, 7.9] },
        { naam: "Testen en verbeteren", cijfers: [7.5, 10, 10] },
        { naam: "Computervaardigheden", cijfers: [7, 7.6, 6.7] },
    ];
    
    // De bovenstaande array bevat gegevens over verschillende modules en hun behaalde cijfers.

    // Functie om gemiddeld cijfer te berekenen
    function berekenGemiddelde(moduleNaam) 
    {
        const module = modules.find(m => m.naam === moduleNaam);

        if (module) 
        {
            // Bereken het gemiddelde van de cijfers voor de opgegeven module
            const gemiddelde = module.cijfers.reduce((acc, cijfer) => acc + cijfer, 0) / module.cijfers.length;
            return gemiddelde.toFixed(1); // Afgerond op één decimaal
        } 
        else 
        {
            return "Module niet gevonden";
        }
    }

    // Functie om resultaten in een tabel te tonen
    function toonResultaten() 
    {
        const table = document.createElement("table");

        // Header rij van de tabel
        const headerRow = table.insertRow();
        headerRow.insertCell().textContent = "Vakken";
        headerRow.insertCell().textContent = "Oefeningen";
        headerRow.insertCell().textContent = "Praktijkopdracht";
        headerRow.insertCell().textContent = "Project";
        headerRow.insertCell().textContent = "Gemiddelde";
        headerRow.insertCell().textContent = "Beoordeling";

        // Gegevens rijen voor elke module
        modules.forEach(module => 
        {
            const row = table.insertRow();
            row.insertCell().textContent = module.naam;
            
            // Voeg cijfers toe voor elke module
            module.cijfers.forEach(cijfer => 
            {
                row.insertCell().textContent = cijfer;
            });

            // Voeg gemiddelde toe voor elke module
            const gemiddelde = berekenGemiddelde(module.naam);
            row.insertCell().textContent = gemiddelde;

            // Voeg beoordeling toe op basis van het gemiddelde
            const beoordeling = gemiddelde >= 5.5 ? "Voldoende" : "Onvoldoende";
            row.insertCell().textContent = beoordeling;
        });

        // Zoek het <h1> element op en voeg de tabel erna toe
        const h1Element = document.querySelector('h1');
        if (h1Element) 
        {
            h1Element.parentNode.insertBefore(table, h1Element.nextSibling);
        } 
        else 
        {
            // Voeg de tabel aan het einde van de body toe als <h1> niet wordt gevonden
            document.body.appendChild(table);
        }
    }

    // Roep de functie aan om de resultaten in een tabel weer te geven
    toonResultaten();
});



document.addEventListener('DOMContentLoaded', function () {
    // Zoek het HTML-element met de class 'bx-menu' en wijs het toe aan de variabele menuIcon
    const menuIcon = document.querySelector('.bx-menu');
    
    // Zoek het HTML-element met de class 'navlist' en wijs het toe aan de variabele navList
    const navList = document.querySelector('.navlist');

    // Voeg een click-eventlistener toe aan het menu-icoon
    menuIcon.addEventListener('click', function () {
        // Controleer of de stijl van het navigatielijstelement is ingesteld op 'block'
        if (navList.style.display === 'block') {
            // Als het zo is, verander het naar 'none' om het te verbergen
            navList.style.display = 'none';
        } else {
            // Als het niet zo is, verander het naar 'block' om het zichtbaar te maken
            navList.style.display = 'block';
        }
    });
});
