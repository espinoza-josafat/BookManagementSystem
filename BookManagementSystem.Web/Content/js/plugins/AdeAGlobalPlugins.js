var aControlesAdeAGlobales = [];

var elementoContenedorControles = null;

var clickEvaluarCambioFocusGlobalAdeAControl = function (event, elementoDOM) {
    var resultado = true;

    if ((elementoContenedorControles && $.contains(elementoContenedorControles, document.activeElement)) || (elementoDOM && $.contains(elementoDOM, document.activeElement))) {
        if (aControlesAdeAGlobales && Array.isArray(aControlesAdeAGlobales) && aControlesAdeAGlobales.length > 0) {
            $(aControlesAdeAGlobales).each(function (index, control) {
                var item = control.Elemento;

                if (typeof (item) === "object" && item.constructor.name === "Text") {
                    if ($(item.getElementoDOM()).attr("data-adea-control-error")) {
                        resultado = false;

                        event.stopPropagation();
                    }
                    else
                        resultado = true;

                    return resultado;
                }
            });
        }
    }

    return resultado;
};

var mouseDownEvaluarCambioFocusGlobalAdeAControl = function (event, elementoDOM) {
    var resultado = true;

    if ((elementoContenedorControles && $.contains(elementoContenedorControles, document.activeElement)) || (elementoDOM && $.contains(elementoDOM, document.activeElement))) {
        var sAttributeDataAdeaControl = $(document.activeElement).attr("data-adea-control");
        if (sAttributeDataAdeaControl && sAttributeDataAdeaControl === "text") {
            if (aControlesAdeAGlobales && Array.isArray(aControlesAdeAGlobales) && aControlesAdeAGlobales.length > 0) {
                var itemText = null;

                $(aControlesAdeAGlobales).each(function (index, control) {
                    var item = control.Elemento;
                    if (typeof (item) === "object" && item.constructor.name === "Text" && item.getElementoDOM() === document.activeElement) {
                        itemText = item;
                        return false;
                    }
                });

                if (itemText) {
                    resultado = itemText.isValidAdeAControl();

                    if (!resultado)
                        event.preventDefault();

                    return resultado;
                }
            }
        }
    }

    return resultado;
};

var obtenerAdeAControlesCabecera = function () {
    var resultado = [];

    if (aControlesAdeAGlobales) {
        for (var i = 0; i < aControlesAdeAGlobales.length; i++) {
            var iControlAdeA = aControlesAdeAGlobales[i];

            if (iControlAdeA && iControlAdeA.Elemento && iControlAdeA.Tipo && iControlAdeA.Tipo === 1)
                resultado.push(iControlAdeA.Elemento);
        }
    }

    return resultado;
}

var obtenerAdeAControlesChecklist = function () {
    var resultado = [];

    if (aControlesAdeAGlobales) {
        for (var i = 0; i < aControlesAdeAGlobales.length; i++) {
            var iControlAdeA = aControlesAdeAGlobales[i];

            if (iControlAdeA && iControlAdeA.Elemento && iControlAdeA.Tipo && iControlAdeA.Tipo === 2)
                resultado.push(iControlAdeA.Elemento);
        }
    }

    return resultado;
}

var eliminarAdeAControlesCabecera = function () {
    if (aControlesAdeAGlobales) {
        for (var i = 0; i < aControlesAdeAGlobales.length; i++) {
            var iControlAdeA = aControlesAdeAGlobales[i];

            if (iControlAdeA.Tipo && iControlAdeA.Tipo === 1) {
                aControlesAdeAGlobales.splice(i);
                i--;
            }
        }
    }
}

var eliminarAdeAControlesChecklist = function () {
    if (aControlesAdeAGlobales) {
        for (var i = 0; i < aControlesAdeAGlobales.length; i++) {
            var iControlAdeA = aControlesAdeAGlobales[i];

            if (iControlAdeA.Tipo && iControlAdeA.Tipo === 2) {
                aControlesAdeAGlobales.splice(i);
                i--;
            }
        }
    }
}

var agregarAdeAControlCabecera = function (item) {
    if (item) {
        var iControlAdeA = {};
        iControlAdeA.Tipo = 1;
        iControlAdeA.Elemento = item;

        aControlesAdeAGlobales.push(iControlAdeA);
    }
}

var agregarAdeAControlChecklist = function (item) {
    if (item) {
        var iControlAdeA = {};
        iControlAdeA.Tipo = 2;
        iControlAdeA.Elemento = item;

        aControlesAdeAGlobales.push(iControlAdeA);
    }
}