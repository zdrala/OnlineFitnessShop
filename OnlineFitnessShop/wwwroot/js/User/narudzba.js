function karticeCheck() {
    var c, item, divK;
    c = document.getElementById("karticeCount");
    divK = document.getElementById("kartice");
    item = parseInt(c.value);
    console.log(item);

    if (item == 0) {
        document.getElementById("rd1").checked = true;
        popUp();
    }
    else {
        divK.style.display = "block";
    }
}

function radio1Check() {
    var divK,kartica;
    divK = document.getElementById("kartice");
    kartica = document.getElementById("sel");

    if (divK.style.display == "block") {
        divK.style.display = "none";
        kartica.value = 0;
    }
}

function popUp() {
    var cov = document.getElementById("coverID");
    var box = document.getElementById("popupID");

    cov.style.display = "block";
    box.style.display = "block";

    var a1 = document.getElementById("link2");

    a1.addEventListener('click', function () {
        cov.style.display = "none";
        box.style.display = "none";
    });
}