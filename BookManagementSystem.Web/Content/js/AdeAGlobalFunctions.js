function cambiarAMayusculasKeyUp(inputText) {
    inputText.value = inputText.value.toUpperCase();
}

function soloLetrasKeyPress(event) {
    var inputValue = window.event ? event.keyCode : event.which;
    if (!((inputValue >= 65 && inputValue <= 90) || (inputValue >= 97 && inputValue <= 122))) {
        event.preventDefault();
    }
}

function soloLetrasGuionBajoKeyPress(event) {
    var inputValue = window.event ? event.keyCode : event.which;
    if (!((inputValue >= 65 && inputValue <= 90) || (inputValue >= 97 && inputValue <= 122) || (inputValue === 95))) {
        event.preventDefault();
    }
}

function soloLetrasNumerosGuionBajoKeyPress(event) {
    var inputValue = window.event ? event.keyCode : event.which;
    if (!((inputValue >= 65 && inputValue <= 90) || (inputValue >= 97 && inputValue <= 122) || (inputValue >= 48 && inputValue <= 57) || (inputValue === 95))) {
        event.preventDefault();
    }
}

function soloNumerosKeyPress(event) {
    var inputValue = window.event ? event.keyCode : event.which;
    if (!(inputValue >= 48 && inputValue <= 57)) {
        event.preventDefault();
    }
}

function isInteger(value) {
    return typeof value === "number" &&
        isFinite(value) &&
        Math.floor(value) === value;
}