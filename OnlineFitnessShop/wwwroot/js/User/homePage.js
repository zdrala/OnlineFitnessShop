function CopyINArray(pID, vrstaID, vrstaName, naziv, img, sz, kolic, cijena) {
    var niz = new Array();
    var trenutniNIZ = JSON.parse(sessionStorage.getItem('a'));

    if (trenutniNIZ != null) {

        for (var i = 0; i < trenutniNIZ.length; i++) {
            var d = new Object();
            d.ProizvodID = trenutniNIZ[i].ProizvodID;
            d.VrstaID = trenutniNIZ[i].VrstaID;
            d.VrstaName = trenutniNIZ[i].VrstaName;
            d.Naziv = trenutniNIZ[i].Naziv;
            d.imgUrl = trenutniNIZ[i].imgUrl;
            d.Size = trenutniNIZ[i].Size;
            d.Kolicina = parseInt(trenutniNIZ[i].Kolicina);
            d.Cijena = trenutniNIZ[i].Cijena;
            d.Ukupno = d.Cijena * d.Kolicina;
            niz.push(d);
        }
    }

    var u = new Object();
    u.ProizvodID = pID;
    u.VrstaID = vrstaID;
    u.VrstaName = vrstaName;
    u.Naziv = naziv;
    u.imgUrl = img;
    u.Size = sz;
    u.Kolicina = parseInt(kolic);
    u.Cijena = cijena;
    u.Ukupno = u.Cijena * u.Kolicina;
    niz.push(u);


    sessionStorage.setItem('a', JSON.stringify(niz));

}

function getItemNoumber() {
    var trenutniNIZ = JSON.parse(sessionStorage.getItem('a'));

    var brojac = 0;

    if (trenutniNIZ != null) {
        for (var i = 0; i < trenutniNIZ.length; i++) {
            brojac++;
        }
    }
    return brojac;
}

function ProvjeraDaLiPostoji(pID, vID, vel) {
    var trenutniNIZ = JSON.parse(sessionStorage.getItem('a'));

    if (trenutniNIZ == null)
        return null;

    for (var i = 0; i < trenutniNIZ.length; i++) {
        if (trenutniNIZ[i].ProizvodID == pID && trenutniNIZ[i].VrstaID == vID && trenutniNIZ[i].Size == vel) {
            return parseInt(trenutniNIZ[i].Kolicina);
        }
    }

    return null;
}

function DodajKolicinu(pID, vID, vel, kol2) {
    var trenutniNIZ = JSON.parse(sessionStorage.getItem('a'));


    for (var i = 0; i < trenutniNIZ.length; i++) {
        if (trenutniNIZ[i].ProizvodID == pID && trenutniNIZ[i].VrstaID == vID && trenutniNIZ[i].Size == vel) {
            trenutniNIZ[i].Kolicina += parseInt(kol2);
            trenutniNIZ[i].Ukupno = parseInt(trenutniNIZ[i].Kolicina) * trenutniNIZ[i].Cijena;
            sessionStorage.setItem('a', JSON.stringify(trenutniNIZ));
            return;
        }
    }
}

function UkloniIzNiza(index) {
    var niz = new Array();
    var trenutniNIZ = JSON.parse(sessionStorage.getItem('a'));

    if (trenutniNIZ != null) {

        for (var i = 0; i < trenutniNIZ.length; i++) {
            if (i != index) {
                var d = new Object();
                d.ProizvodID = trenutniNIZ[i].ProizvodID;
                d.VrstaID = trenutniNIZ[i].VrstaID;
                d.VrstaName = trenutniNIZ[i].VrstaName;
                d.Naziv = trenutniNIZ[i].Naziv;
                d.imgUrl = trenutniNIZ[i].imgUrl;
                d.Size = trenutniNIZ[i].Size;
                d.Kolicina = parseInt(trenutniNIZ[i].Kolicina);
                d.Cijena = trenutniNIZ[i].Cijena;
                d.Ukupno = d.Cijena * d.Kolicina;
                niz.push(d);
            }
        }
    }

    sessionStorage.setItem('a', JSON.stringify(niz));
}

function Ocisti() {
    sessionStorage.clear();
}