function solve() {
  let inputString = document.getElementById("input").value;
  const resultOutput = document.getElementById("resultOutput");

  let result = "";
  let input = inputString;

  input = input.split("");

  while (input.length > 1) {
    input = input
      .map(Number)
      .reduce((a, b) => a + b)
      .toString()
      .split("");
  }

  inputString = inputString.slice(input, inputString.length - input);

  let arr = inputString.split(/([\d]{8})/g).filter(Boolean);

  result = arr.reduce((a, b) => {
    return (a += String.fromCharCode(Number(parseInt(b, 2))));
  }, "");

  result = result.match(/[A-Za-z ]+/g);

  resultOutput.textContent = result.join("");
  document.getElementById("input").value = "";
}
