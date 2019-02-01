$(document).ready(function () {

   // MascaraData();

    // $(".tel").mask("(00) 90000-0000", { placeholder: "(99) 99999-9999" });
    $("#CPF").mask("000.000.000-00", { placeholder: "999.999.999-99" }, { reverse: true });
    
    //$(".btn-sm SalvarPessoa").on("click", function () {
    //  //  e.preventDefault();

    //    alert('entrou aqui');
    //    //var obj = {
    //    //    rules: {
    //    //        // Email: { required: true },
    //    //        // Telefone: { required: true, phone: true },
    //    //        CPF: { required: true, CPF: true }
    //    //        // ,                NomeForm: { required: true }
    //    //    },
    //    //    messages: {
    //    //        //  Telefone: { required: "Preencha o Telefone", phone: "Telefone inválido" },
    //    //        CPF: { required: "Preencha o CPF", custom: "CPF inválido" }
    //    //        // NomeForm: { required: "Preencha o Nome" },
    //    //        // Email: { required: "Preencha o E-mail" }
    //    //    }
    //    //};

    //    //var validou = validate(obj);

    //    ////var papel = $("#formCredenciado input[type=checkbox]:checked").length > 0;

    //    ////if (!papel) {
    //    ////    validou = papel;
    //    ////    exibeErro($(".rolagemPapel"), "Selecione pelo menos um papel");
    //    ////}
    //    //if (validou) {
    //    //    $("#formManterPessoa").submit();
    //    //}

    //});
});

function MascaraData() {
    $('.DataNascimento').mask("99/99/9999", { placeholder: "__/__/____" });
}