function solve() {
  const input = document.getElementById("array");
  const array = JSON.parse(input.value);
  const result = document.getElementById("result");

  const regex = new RegExp(
    `(\\s|^)(${array[0]}\\s+)([A-Z!#$%]{8,})(\\.|,|\\s|$)`,
    "gi"
  );

  for (let i = 1; i < array.length; i++) {
    let myStr = array[i];
    let match = regex.exec(myStr);
    while (match !== null) {
      let encodedMessage = match[3];
      if (encodedMessage.toUpperCase() !== encodedMessage) {
        match = regex.exec(myStr);
        continue;
      }

      let decodedMessage = encodedMessage.replace(/!/g, "1");
      decodedMessage = decodedMessage.replace(/%/g, "2");
      decodedMessage = decodedMessage.replace(/#/g, "3");
      decodedMessage = decodedMessage.replace(/\$/g, "4").toLowerCase();

      let message = match[1] + match[2] + decodedMessage + match[4];
      myStr = myStr.replace(match[0], message);
      match = regex.exec(myStr);
    }

    const p = document.createElement("p");
    p.textContent = myStr;
    result.appendChild(p);
  }
}
