function toggleMode() {
  const html = document.documentElement;

  html.classList.toggle("light");

  //pegar a tag img

  const img = document.querySelector("#profile img");

  //substituir imagem
  if (html.classList.contains("light")) {
    img.setAttribute("src", "./assets/Avatar_Miguel_Light-Mode_circular.png");
    img.setAttribute(
      "alt",
      "imagem de miguel tirando foto no espelho de camisa branca "
    );
  } else {
    img.setAttribute("src", "./assets/Avatar_Miguel_Dark-Mode_circular.png");
  }
}
