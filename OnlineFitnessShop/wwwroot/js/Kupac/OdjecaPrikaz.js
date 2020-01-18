var a = localStorage.length;
function bttn() {
    var current = document.getElementsByClassName("active");
    var b = document.getElementById("button-dodaj");
    var kol1 = document.getElementById("inputKol").value;
    var kol2 = document.getElementById("kol").value;
    var b = document.getElementById("log").innerHTML;

    if (b == "False") {
        prikaziError("OPCIJA JE DOSTUPNA SAMO LOGIRANIM KORISNICIMA", "danger");
        return;
    }

    if (current.length > 0) {

        if (kol2 < 1) {
            prikaziError("UNESENA KOLIČINA NE MOŽE BITI MANJA OD 1 !", "danger");
            return;
        }

        if (kol2 > kol1) {
            prikaziError("NEMA NA STANJU", "danger");
            return;
        }

        var proID = document.getElementById("ProizvodID").innerHTML;
        var odjID = document.getElementById("OdjecaID").innerHTML;
        var naziv = document.getElementById("nazivID").innerHTML;
        var slika = document.getElementById("imgID").innerHTML;
        var size = document.getElementsByClassName("active")[0].innerHTML;
        var cijena = document.getElementById("cijenaID").innerHTML;

        var check = ProvjeraDaLiPostoji(proID, odjID, size);
        if (check != null) {
            var k = parseInt(check) + parseInt(kol2);
            if (k > kol1) {

                prikaziError("NEMA NA STANJU", "danger");
                return;
            }
            else {
                DodajKolicinu(proID, odjID, size, kol2);
                prikaziError("PROIZVOD SE VEĆ NALAZI U KORPI, KOLIČINA JE IZMIJENJENA", "success");
                return;
            }
        }

        var broj = getItemNoumber();
        document.getElementById("noumberItems").innerHTML = ++broj;
        CopyINArray(proID, odjID, "Odjeca", naziv, slika, size, kol2, cijena);
        prikaziError("DODANO U KORPU", "success");
    }
    else {
        prikaziError("ODABERITE VELIČINU", "info");
    }
}

function prikaziError(poruka, vrsta) {
    var x = document.getElementById("divZaError");

    x.innerHTML = poruka;

    if (vrsta == "danger") {
        x.style.backgroundColor = "#ff3333";
    }

    if (vrsta == "success") {
        x.style.backgroundColor = "#80ff80";
    }

    if (vrsta == "info") {
        x.style.backgroundColor = "#4da6ff";
    }

    x.style.display = "block";


    setTimeout(function () {
        $('#divZaError').fadeOut('slow');
    }, 4000);
}