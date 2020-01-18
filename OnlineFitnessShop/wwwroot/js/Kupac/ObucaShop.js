function search() {
    var input, filter, ul, li, a, b, i, txtValue, txtValue2, radio1, radio2, radio3;
    input = document.getElementById('myInput');
    filter = input.value.toUpperCase();
    ul = document.getElementById("pcL");
    li = ul.getElementsByClassName("proizvod");
    radio1 = document.getElementById("rd1");
    radio2 = document.getElementById("rd2");
    radio3 = document.getElementById("rd3");

    for (i = 0; i < li.length; i++) {

        b = li[i].getElementsByTagName("h1")[0];
        txtValue2 = b.textContent || a2.innerText;

        if (radio2.checked) {
            if (txtValue2 != "Ženski") {
                continue;
            }
        }

        if (radio1.checked) {
            if (txtValue2 != "Muški") {
                continue;
            }
        }

        a = li[i].getElementsByTagName("h5")[0];
        txtValue = a.textContent || a.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}

function filterMuški() {
    var c, item, a, i, txtValue;
    c = document.getElementById("pcL");
    item = c.getElementsByClassName("proizvod");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByTagName("h1")[0];
        txtValue = a.textContent || a.innerText;
        if (txtValue == "Muški") {
            item[i].style.display = "";
        } else {
            item[i].style.display = "none";
        }
    }
}

function filterŽenski() {
    var c, item, a, i, txtValue;
    c = document.getElementById("pcL");
    item = c.getElementsByClassName("proizvod");
    for (i = 0; i < item.length; i++) {
        a = item[i].getElementsByTagName("h1")[0];
        txtValue = a.textContent || a.innerText;
        if (txtValue == "Ženski") {
            item[i].style.display = "";
        } else {
            item[i].style.display = "none";
        }
    }
}

function filterSvi() {
    var c, item;
    c = document.getElementById("pcL");
    item = c.getElementsByClassName("proizvod");
    console.log(item.length)
    for (i = 0; i < item.length; i++) {
        if (item[i].style.display = "none") {
            item[i].style.display = "";
        }
    }
}