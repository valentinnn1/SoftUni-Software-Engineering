function solve() {
  const word = document.getElementById("word").value;
  const text = JSON.parse(document.getElementById("text").value);
  const result = document.getElementById("result");

  const wordToBeReplaced = text[0].split(" ")[2];

  const resultArr = text.map(x =>
    x.replace(new RegExp(wordToBeReplaced, "gi"), word)
  );

  console.log(resultArr);

  resultArr.forEach(el => {
    const p = document.createElement("p");
    p.textContent = el;
    result.appendChild(p);
  });
}
