//   fetch('http://localhost:5000/api/Veiculo', {
//       method: 'GET'
//   })
//       .then(function(response) {
//           return response.json();
//       })
//      .then(function(data) {
//           console.log(data);
//       })

function enviar() {
  var nome = form.nomeProprietario.value;
  var telefone = form.telefoneProprietario.value;
  var marca = form.marca.value;
  var modelo = form.modelo.value;
  var ano = form.anoVeiculo.value;
  var cor = form.corVeiculo.value;
  var km = form.kilometragem.value;
  var valor = form.valorCarro.value;
  var banco = form.bancoCouro.checked;
  var vidros = form.vidroEletrico.checked;
  var ar = form.arCondicionado.checked;
  var teto = form.tetoSolar.checked;
  var chave = form.chavePresencial.checked;
  var nav = form.navegadorGps.checked;
  var compBordo = form.computadorDeBordo.checked;
  var retrovisor = form.retrovisorFotocromico.checked;
  var cambio = form.cambioAutomatico.checked;
  var volante = form.volanteMultifuncional.checked;
  var bluetooth = form.conexaoBluetooth.checked;
  var airbag = form.airbags.checked;
  var esp = form.controleEsp.checked;
  var luz = form.luzDeNeblina.checked;

  if (
    nome == "" ||
    telefone == "" ||
    marca == "" ||
    modelo == "" ||
    ano == "" ||
    cor == "" ||
    km == "" ||
    valor == ""
  ) {
    alert("Preencha todos os campos!")
  } else {
    fetch("http://localhost:5000/api/Veiculo", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        nomeProprietario: nome,
        telefoneProprietario: telefone,
        marca: marca,
        modelo: modelo,
        anoVeiculo: ano,
        corVeiculo: cor,
        kilometragem: km,
        valorCarro: valor,
        bancoCouro: banco,
        vidroEletrico: vidros,
        arCondicionado: ar,
        tetoSolar: teto,
        chavePresencial: chave,
        navegadorGps: nav,
        computadorDeBordo: compBordo,
        retrovisorFotocromico: retrovisor,
        cambioAutomatico: cambio,
        volanteMultifuncional: volante,
        conexaoBluetooth: bluetooth,
        airbags: airbag,
        controleEsp: esp,
        luzDeNeblina: luz,
      }),
    })
      .then(function (response) {
        return response.json();
      })
      .then(function (data) {
        console.log(data);
      });
      alert("Veiculo cadastrado!")
    }
}
