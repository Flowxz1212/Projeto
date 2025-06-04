function toggleMode() {

    const html = document.documentElement
    
        html.classList.toggle('light')

        //pegar a tag img

        const img = document.querySelector('#profile img')

        //substituir imagem
          if(html.classList.contains('light'))
        {
            img.setAttribute('src', './assets/avatar-light.png')
            img.setAttribute('alt', 'imagem de MaykBrito sorrindo, de jaqueta preta e oculos escuros, em um fundo azul')

        }
        else
        {
            img.setAttribute('src', './assets/avatar.png')

        }
    

}