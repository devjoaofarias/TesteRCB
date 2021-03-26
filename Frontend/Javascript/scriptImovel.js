//    fetch('http://localhost:5000/api/Imovel', {
//        method: 'GET'
//    })
//        .then(function(response) {
//            return response.json();
//        })
//       .then(function(data) {
//            console.log(data);
//        })

function enviar() {
  var titulo = form.tituloCasa.value;
  var cep = form.cep.value;
  var estado = form.estado.value;
  var cidade = form.cidade.value;
  var numero = form.numero.value;
  var endereco = form.endereco.value;
  var valor = form.valorCasa.value;
  var area = form.areaCasa.value;
  var nome = form.nomeProprietario.value;
  var telefone = form.telefoneProprietario.value;
  var qntQuartos = form.quartos.value;
  var qntBanheiros = form.banheiros.value;
  var tipo = form.tipoResidencia.value;

  if (
    titulo == "" ||
    cep == "" ||
    estado == "" ||
    cidade == "" ||
    numero == "" ||
    endereco == "" ||
    valor == "" ||
    area == "" ||
    nome == "" ||
    telefone == ""
  ) {
    alert("Preencha todos os campos!");
  } else {
    fetch("http://localhost:5000/api/Imovel", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        tituloCasa: titulo,
        cep: cep,
        estado: estado,
        cidade: cidade,
        numero: numero,
        endereco: endereco,
        valorCasa: valor,
        area: area,
        nomeProprietario: nome,
        telefoneProprietario: telefone,
        quartos: qntQuartos,
        banheiros: qntBanheiros,
        tipoResidencia: tipo,
      }),
    })
      .then(function (response) {
        return response.json();
      })
      .then(function (data) {
        console.log(data);
      });
      alert("Imóvel cadastrado!")
  }
}


