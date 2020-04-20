function autoLoad() {

    var broj = getItemNoumber();
    document.getElementById("noumberItems").innerHTML = broj;
};

function Ocisti() {
    sessionStorage.clear();
    autoLoad();
}

window.onload = Ocisti;