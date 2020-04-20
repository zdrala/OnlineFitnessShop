function autoLoad() {

    var broj = getItemNoumber();
    document.getElementById("noumberItems").innerHTML = broj;
    var sadrzaj = document.getElementById("content-div");

    document.querySelector("#korpaTabela tbody").innerHTML = "";
    var Korpa = JSON.parse(sessionStorage.getItem('a'));
    console.log(Korpa);

    if (Korpa == null || broj == 0) {
        sadrzaj.style.display = "none";
        document.getElementById("praznaKorpaID").style.display = "block";
        return;
    }


    if (sadrzaj.style.display == "none") {
        sadrzaj.style.display = "block";
        document.getElementById("praznaKorpaID").style.display = "none";
    }


    var brojac = 0;
    var ukupno = 0;
    for (var i = 0; i < Korpa.length; i++) {
        var tr = document.createElement('tr');
        tr.id = "red-" + brojac;
        document.querySelector("#korpaTabela tbody").appendChild(tr);

        var td1 = document.createElement('td');
        var img = document.createElement("img");
        var td2 = document.createElement('td');
        var td3 = document.createElement('td');
        var td4 = document.createElement('td');
        var td5 = document.createElement('td');
        var td6 = document.createElement('td');
        var td7 = document.createElement('td');
        var bttn = document.createElement('button');
        var bttn2 = document.createElement('button');
        bttn.setAttribute("onclick", "Izbrisi(" + brojac + ");");
        bttn2.setAttribute("onclick", "Izbrisi(" + brojac + ");");
        bttn2.setAttribute("class", "mobileButton");

        td1.appendChild(img);
        tr.appendChild(td1);
        tr.appendChild(td2);
        tr.appendChild(td3);
        tr.appendChild(td4);
        tr.appendChild(td5);
        tr.appendChild(td6);
        td7.appendChild(bttn);
        td7.appendChild(bttn2);
        tr.appendChild(td7);



        img.src = "/images/" + Korpa[i].imgUrl;
        td2.innerText = Korpa[i].Naziv;
        if (Korpa[i].VrstaName == "Suplementacija") {
            td3.innerText = Korpa[i].Size + " kg";
        }
        else {
            td3.innerText = Korpa[i].Size;
        }
        td4.innerText = Korpa[i].Cijena + " KM";
        td5.innerText = Korpa[i].Kolicina;
        td6.innerText = Korpa[i].Ukupno + " KM";
        bttn.innerText = "IZBRIŠITE";
        bttn2.innerText = "X";

        ukupno += Korpa[i].Ukupno;

        brojac++;
    }

    document.getElementById("placeUkupno").innerHTML = ukupno + " KM";

};

function Ocisti() {
    sessionStorage.clear();
    autoLoad();
}

function Izbrisi(v) {
    var cov = document.getElementById("coverID");
    var box = document.getElementById("popupID");

    cov.style.display = "block";
    box.style.display = "block";

    var a1 = document.getElementById("link1");
    var a2 = document.getElementById("link2");

    a1.addEventListener('click', function () {
        cov.style.display = "none";
        box.style.display = "none";
    });

    a2.onclick = function () {
        UkloniIzNiza(v);
        cov.style.display = "none";
        box.style.display = "none";
        autoLoad();

    };
}

window.onload = autoLoad;