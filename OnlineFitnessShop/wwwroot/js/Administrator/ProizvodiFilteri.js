function filterMuški() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("spol")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Muški") {
            document.getElementById(p).style.display = "";
        } else {
            document.getElementById(p).style.display = "none";
        }
    }
}

function filterŽenski() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("spol")[0];
        txtValue = a.innerText.trim();     
        var p = item[i].id;
        if (txtValue == "Ženski") {
           
            document.getElementById(p).style.display = "";
        } else {
            document.getElementById(p).style.display = "none";
        }
    }
}

function filterSvi() {
    var c, item;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        var p = item[i].id;
        //if (document.getElementById(p).style.display = "none") {
            document.getElementById(p).style.display = ""
        //}
    }
}

function filterProtein() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("kategorija")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Protein") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}
function filterKreatin() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("kategorija")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Kreatin") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}
function filterPreWorkout() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("kategorija")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Pre-Workout") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}


function filterPojasevi() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("tipDodatka")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Pojasevi") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}

function filterŠejkeri() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("tipDodatka")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Šejkeri") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}

function filterSteznici() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("tipDodatka")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Steznici") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}
function filterTorbe() {
    var c, item, a, i, txtValue;
    c = document.getElementById("b-id");
    item = c.getElementsByTagName("tr");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByClassName("tipDodatka")[0];
        txtValue = a.innerText.trim();
        var p = item[i].id;
        if (txtValue == "Torbe") {
            document.getElementById(p).style.display = "";
        }
        else {
            document.getElementById(p).style.display = "none";
        }
    }

}
