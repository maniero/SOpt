function rodarSlider(contador, rolagem) {
    var arrayimgs = ["js/img1.jpg","js/img2.jpg","js/img3.jpg"];
    var imagem = document.getElementById('imagemslide');
    imagem.src = arrayimgs[contador + rolagem];
    return contador;
}

algumContador = rodarSlider(algumContador, 1); //próximo
algumContador = rodarSlider(algumContador, -1); //anterior

//https://pt.stackoverflow.com/q/43110/101
