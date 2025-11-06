//    Autheur:         Ties de Bruijn
//    Aanmaakdatum:   <02-23-2024>
//
//    <Namaak van de Veba-solar site>

// bool if menu needs to be shown
var Visable = false;

function SwitchBurgerMenuState()
{
    //all child elements of the burger button (the lines)
    var ElementChildren = document.getElementById("BurgerButton").children;
    if(Visable)
    {
        // hide menu
        document.getElementById("Hamburger").style.display = "none";
        // change line colors
        ElementChildren[0].style.backgroundColor = "rgba(34, 141, 0,255)";
        ElementChildren[1].style.backgroundColor = "rgba(34, 141, 0,255)";
        ElementChildren[2].style.backgroundColor = "rgba(34, 141, 0,255)";
        //change transform and rotateion animation
        ElementChildren[1].style.transform = "rotateZ(0deg)";
        ElementChildren[2].style.transform = "translateY(0px) rotateZ(0deg)";
    }
    else
    {
        // show menu
        document.getElementById("Hamburger").style.display = "unset";
        // change line colors
        ElementChildren[0].style.backgroundColor = "rgba(34, 141, 0,0)";
        ElementChildren[1].style.backgroundColor = "rgba(0, 0, 0,255)";
        ElementChildren[2].style.backgroundColor = "rgba(0, 0, 0,255)";
        //change transform and rotateion animation
        ElementChildren[1].style.transform = "rotateZ(45deg)";
        ElementChildren[2].style.transform = "translateY(-9px) rotateZ(-45deg)";

    }
    // flip bool visable
    Visable = !Visable;
}