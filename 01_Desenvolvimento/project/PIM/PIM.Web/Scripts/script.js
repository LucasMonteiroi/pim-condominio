var currentValue = 0;
var questoes = 0;
var numeroCaso = "";
var dataCaso = "";

$(function() {
    $("input#txtCaso").on({
        keydown: function(e) {
            if (e.which === 32)
                return false;
        },
        change: function() {
            this.value = this.value.replace(/\s/g, "");
        }
    });
});

function handleClick(myRadio) {
    var valRadio = myRadio.value;
    if (valRadio < 0) {
        $('label[name=' + myRadio.name + ']').addClass('badge badge-danger')
        currentValue = currentValue - 1;
    } else if (valRadio == 1) {
        $('label[name=' + myRadio.name + ']').addClass('badge badge-success')
        currentValue += 1;
    } else if (valRadio == 2) {
        $('label[name=' + myRadio.name + ']').addClass('badge badge-success')
        currentValue += 2;
    } else {
        currentValue = currentValue;
    }

    $(":radio[name='" + myRadio.name + "']").attr("disabled", true);
    $('label[name=' + myRadio.name + ']').text(myRadio.value).addClass('badge');

    questoes += 1;

    $("#resultadoCalculo").text(currentValue);

    if (currentValue > 0) {
        $("#resultadoCalculo").removeClass('badge badge-danger').addClass('badge badge-success');
    } else if (currentValue < 0) {
        $("#resultadoCalculo").addClass('badge badge-danger');
    } else {
        $("#resultadoCalculo").removeClass('badge badge-danger').removeClass('badge badge-success');
    }

    if (questoes == 10) {
        $("#btnCalcula").show();
    }
    // console.log(currentValue);
    // console.log(myRadio.name);
}


var calcularNaranjo = function() {
    if (currentValue.valueOf() < 2) {
        //console.log("Duvidoso");
        $("#txtCausalidade").val("DUVIDOSO");
    } else if (currentValue.valueOf() >= 2 && currentValue.valueOf() <= 4) {
        // console.log("Possivel");
        $("#txtCausalidade").val("POSSIVEL");
    } else if (currentValue.valueOf() >= 5 && currentValue.valueOf() <= 8) {
        // console.log("Provavel");
        $("#txtCausalidade").val("PROVAVEL");
    } else if (currentValue.valueOf() > 9) {
        // console.log("Definido");
        $("#txtCausalidade").val("DEFINIDO");
    }

    $("#btnImprime").show();

    // console.log(numeroCaso.valueOf());
    // console.log(dataCaso.valueOf());
}

var generatePDF = function () {
    var numeroCaso = $("#txtCaso").val();

    kendo.drawing.drawDOM(
        $("#formConfirmation"), {
            paperSize: "A4",
            margin: "0.5cm",
            scale: 0.6
        }).then(function(group) {
        kendo.drawing.pdf.saveAs(group, "Calculo de Naranjo - " + numeroCaso + ".pdf");
    });
}

var validarCampos = function() {
    var valido = true;
    var mensagem = "";
    numeroCaso = $("#txtCaso").val();
    numeroCaso = numeroCaso.toUpperCase();
    dataCaso = $("#txtDataCaso").val();

    if (numeroCaso.length == 10) {
        if (dataCaso.valueOf() != "") {
            // console.log("Validado");
            valido = true;
        } else {
            valido = false;
            mensagem = "Necessario preencher a data do caso!"
        }
    } else {
        valido = false;
        mensagem = "Necessario preencher o numero do caso!"
    }

    if (valido == true) {
        limparMensagem();
        calcularNaranjo();
    } else {
        exibirMensagem(mensagem);
    }
}


var exibirMensagem = function(mensagem) {
    $("#alerta").show();
    $("#alerta").attr("tabindex", -1).focus();
    $("#lblconteudo-alerta").focus();
    $("#lblconteudo-alerta").text(mensagem);
}

var limparMensagem = function() {
    $("#alerta").hide();
}