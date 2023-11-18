
$('.numericas').focusout(function () {

    $(this).val(SacarPuntosComas_($(this).val()));
    $(this).val(formatoMiles_($(this).val()));
    if ($(this).val() == '') { $(this).val('0'); }



});

$('.numericas').focus(function () {

    $(this).val(SacarPuntosComas_($(this).val()));
    if (parseInt($(this).val()) == 0)
    { $(this).val(''); }


});

$('.numericas').load(function () {


    var decimal = $.data(this, "numericas");
    var callback = $.data(this, "numericas.callback");
    var val = $(this).val();
    if (val != "") {


        callback.apply(this);
        $(this).val(SacarPuntosComas_($(this).val()));
        $(this).val(formatoMiles_($(this).val()));
        if ($.trim($(this).val()) == '') { $(this).val('0'); }

    }

});

$('.numericas').keydown(function (event) {
    if (event.shiftKey) {
        event.preventDefault();
    }
    if (event.keyCode == 11 || event.keyCode == 9 || event.keyCode == 37 || event.keyCode == 39) { return; }
    if (event.keyCode == 46 || event.keyCode == 8) {
    }
    else {
        if (event.keyCode < 95) {
            if (event.keyCode < 48 || event.keyCode > 57) {
                event.preventDefault();
            }
        }
        else {
            if (event.keyCode < 96 || event.keyCode > 105) {
                event.preventDefault();
            }
        }
    }
});

function SacarPuntosComas_(cadena) {

    if (cadena != "" && cadena != undefined) {
        cadena = cadena.replace(/\./g, '');
        cadena = cadena.replace(/\,/g, '');
    }
    return cadena;
}


function SacarPuntos_(cadena) {

    if (cadena != "" && cadena != undefined) {
        cadena = cadena.replace(/\./g, '');
        cadena = cadena.replace(/\,/g, '');
    }
    return cadena;
}


function formatoMiles_(valor) {
    if (valor == '') return '';

    var number = new String(valor);
    var result = '';

    while (number.length > 3) {
        result = '.' + number.substr(number.length - 3) + result;
        number = number.substring(0, number.length - 3);
    }

    result = number + result;
    return result;

};

(function ($) {

    $.fn.numericas = function (callback) {
        callback = typeof callback == "function" ? callback : function () { };
        return this.data("numericas.callback", callback).keydown($.fn.numericas.keydown).blur($.fn.numericas.blur).focus($.fn.numericas.focus).focusout($.fn.numericas.focusout);
    }

    $.fn.numericas.keydown = function (event) {


        var decimal = $.data(this, "numericas");
        var key = event.charCode ? event.charCode : event.keyCode ? event.keyCode : 0;
        if (key == 13 && this.nodeName.toLowerCase() == "input") {
            return true;
        }
        else if (key == 13) {
            return false;
        }

        if (event.shiftKey) {
            event.preventDefault();
        }
        if (event.keyCode == 11 || event.keyCode == 9 || event.keyCode == 37 || event.keyCode == 39) { return; }
        if (event.keyCode == 46 || event.keyCode == 8) {
        }
        else {
            if (event.keyCode < 95) {
                if (event.keyCode < 48 || event.keyCode > 57) {
                    event.preventDefault();
                }
            }
            else {
                if (event.keyCode < 96 || event.keyCode > 105) {
                    event.preventDefault();
                }
            }
        }
    }

    $.fn.numericas.blur = function () {

        var decimal = $.data(this, "numericas");
        var callback = $.data(this, "numericas.callback");
        var val = $(this).val();
        if (val != "") {


            callback.apply(this);
            $(this).val(SacarPuntosComas_($(this).val()));
            $(this).val(formatoMiles_($(this).val()));
            if ($.trim($(this).val()) == '') { $(this).val('0'); }

        }
    }

    $.fn.removeNumeric = function () {
        return this.data("numericas", null).data("numericas.callback", null).unbind("keypress", $.fn.numeric.keypress).unbind("blur", $.fn.numeric.blur);
    }

    $.fn.numericas.focus = function () {

        var decimal = $.data(this, "numericas");
        var callback = $.data(this, "numericas.callback");
        var val = $(this).val();
        if (val != "") {

            callback.apply(this);

            $(this).val(SacarPuntosComas_($(this).val()));
            if (parseInt($(this).val()) == 0)
            { $(this).val(''); }

        }
    }

    $.fn.numericas.focusout = function () {

        var decimal = $.data(this, "numericas");
        var callback = $.data(this, "numericas.callback");
        $(this).val(formatoMiles_($(this).val()));
        var val = $.trim($(this).val());
        if (val == "") {

            callback.apply(this);

            $(this).val(SacarPuntosComas_($(this).val()));
            $(this).val(formatoMiles_($(this).val()));
            if ($.trim($(this).val()) == '') { $(this).val('0'); }

        }
    }

})(jQuery);




/***************************************************************************************************/
/************    NUMEROS DESCIMALES   **************************************************************/
/***************************************************************************************************/



function LimpiarFormatoDecimales_(cadena) {

    if (cadena == '') { return ''; }
    if (cadena != "" && cadena != undefined) {

        var separados = cadena.split(',');
        var enteros = separados[0];
        enteros = enteros.replace(/\./g, '');
        var decimales = '';
        if (separados.length > 1)
            decimales = ',' + separados[1];

        cadena = enteros + decimales;
    }
    return cadena;
}

function ConvercionComas_A_Puntos(cadena) {
    if (cadena == '') { return ''; }
    if (cadena != "" && cadena != undefined) {
        cadena = cadena.replace(/\,/g, '-');
        cadena = cadena.replace(/\./g, '');
        cadena = cadena.replace(/\-/g, '.');
    }
    return cadena;
}

function DeComas_A_Puntos(cadena) {
    if (cadena == '') { return ''; }
    if (cadena != "" && cadena != undefined) {
        cadena = cadena.replace(/\,/g, '-');
        cadena = cadena.replace(/\./g, '');
        cadena = cadena.replace(/\-/g, '.');
    }


    return cadena;
}

function SacarPuntos(cadena) {
    if (cadena == '') { return ''; }
    if (cadena != "" && cadena != undefined) {
        cadena = cadena.replace(/\./g, '');
    }
    return cadena;
}

function formatoMilesConDecimales_(cadena) {
    if (cadena == '') { return ''; }
    if (cadena.substring(cadena.length - 1) == ',') { cadena = cadena.substring(0, cadena.length - 1) }


    var separado = cadena.split(',');
    var enteros = '';
    var decimal = '';
    if (separado.length > 1);
    {
        enteros = separado[0]
        if (separado.length > 1)
            decimal = ',' + separado[1];
        enteros = SacarPuntosComas(enteros);
        enteros = formatoMiles(enteros);
        cadena = enteros + decimal;

    }


    return cadena;
}

$('.numericasDec').focusout(function () {
    conso.log(' pasa 5 ')

    $(this).val(formatoMilesConDecimales_($(this).val()));
    if ($(this).val() == '') { $(this).val('0'); }
});

$('.numericasDec').focus(function () {

    $(this).val(LimpiarFormatoDecimales($(this).val()));
    if (parseInt($(this).val()) == 0)
    { $(this).val(''); }
});

$('.numericasDec').keyup(function (event) {

    $(this).val($(this).val().replace(/\./g, ','));

});

$('.numericasDec').keydown(function (event) {


    if (event.shiftKey) {
        event.preventDefault();
    }
    if (event.keyCode == 11 || event.keyCode == 9 || event.keyCode == 37 || event.keyCode == 39) { return; }
    else if (event.keyCode == 110 || event.keyCode == 188) {

        var p = $(this).val().split(',');
        var t = p.length;
        if (t < 2)
            return;
    }
    if (event.keyCode == 46 || event.keyCode == 8) {


    }
    else {
        if (event.keyCode < 95) {
            if (event.keyCode < 48 || event.keyCode > 57) {
                event.preventDefault();
            }

        }
        else {
            if ((event.keyCode < 96 || event.keyCode > 105)) {
                event.preventDefault();
            }

        }
    }
});






(function ($) {




    $.fn.numericasDec = function (callback) {
        callback = typeof callback == "function" ? callback : function () { };
        return this.data("numericasDec.callback", callback).keydown($.fn.numericasDec.keydown).keyup($.fn.numericasDec.keyup).blur($.fn.numericasDec.blur).focus($.fn.numericasDec.focus).focusout($.fn.numericasDec.focusout);
    }

    $.fn.numericasDec.keydown = function (event) {


        var decimal = $.data(this, "numericasDec");
        var key = event.charCode ? event.charCode : event.keyCode ? event.keyCode : 0;
        if (key == 13 && this.nodeName.toLowerCase() == "input") {
            return true;
        }
        else if (key == 13) {
            return false;
        }

        if (event.shiftKey) {
            event.preventDefault();
        }
        if (event.keyCode == 11 || event.keyCode == 9 || event.keyCode == 37 || event.keyCode == 39) { return; }
        else if (event.keyCode == 110 || event.keyCode == 188) {

            var p = $(this).val().split(',');
            var t = p.length;
            if (t < 2)
                return;
        }

        if (event.keyCode == 46 || event.keyCode == 8) {
        }
        else {
            if (event.keyCode < 95) {
                if (event.keyCode < 48 || event.keyCode > 57) {
                    event.preventDefault();
                }
            }
            else {
                if (event.keyCode < 96 || event.keyCode > 105) {
                    event.preventDefault();
                }
            }
        }
    }

    $.fn.numericasDec.keyup = function (event)
    { $(this).val($(this).val().replace(/\./g, ',')); }

    $.fn.numericasDec.blur = function () {

    }

    $.fn.numericasDec.focus = function () {

        var decimal = $.data(this, "numericasDec");
        var callback = $.data(this, "numericasDec.callback");
        var val = $(this).val();
        if (val != "") {
            callback.apply(this);
            $(this).val(LimpiarFormatoDecimales($(this).val()));
            if (parseInt($(this).val()) == 0)
            { $(this).val(''); }
        }
    }

    $.fn.numericasDec.focusout = function () {
        var decimal = $.data(this, "numericasDec");
        var callback = $.data(this, "numericasDec.callback");
        $(this).val(formatoMilesConDecimales_($(this).val()));
        var val = $.trim($(this).val());
        if (val == "") {
            callback.apply(this);
            $(this).val(ConvercionComas_A_Puntos($(this).val()));
            $(this).val(formatoMilesConDecimales_($(this).val()));
            if ($.trim($(this).val()) == '') { $(this).val('0'); }

        }
    }

})(jQuery);
