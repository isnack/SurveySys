function limitaTextarea(valor) {
    quantidade = 299;
    total = valor.length;

    if (total <= quantidade) {
        resto = quantidade - total;
        document.getElementById('lblContador').innerHTML = resto;
    } else {
        document.getElementById('txtEnunciado').value = valor.substr(0, quantidade);
        document.getElementById('lblContador').innerHTML = "Limite de caracteres atingido!";
        return false;
    }
}

