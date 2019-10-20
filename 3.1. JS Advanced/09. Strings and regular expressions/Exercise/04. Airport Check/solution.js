function solve() {
  const str = document.getElementById("string").value;
  const result = document.getElementById("result");

  let myText = str.split(",")[0].trim();
  let neededInfo = str.split(",")[1].trim();

  const namePattern = /([A-Z]+([A-Za-z]*)?)(-[A-Z][A-Za-z]*\.)?-([A-Z][A-Za-z]*)?/g;
  const airportPattern = / [A-Z]{3}\/[A-Z]{3} /g;
  const flightPattern = / [A-Z]{1,3}[\d]{1,5} /g;
  const companyPattern = /- [A-Z]+[a-z]*\*[A-Z]+[a-z]* /g;

  let name = myText.match(namePattern);
  let flight = myText.match(flightPattern);
  let airports = myText.match(airportPattern);
  let company = myText.match(companyPattern);

  if (neededInfo === "name") {
    name = name[0].split("-").join(" ");
    result.textContent = `Mr/Ms, ${name}, have a nice flight!`;
  } else if (neededInfo === "flight") {
    let flightNumber = flight[0];
    let [fromAirport, toAirport] = airports[0].split("/");
    result.textContent = `Your flight number ${flightNumber.trim()} is from ${fromAirport.trim()} to ${toAirport.trim()}.`;
  } else if (neededInfo === "company") {
    company = company[0].replace("- ", "").replace("*", " ");
    result.textContent = `Have a nice flight with ${company.trim()}.`;
  } else if (neededInfo === "all") {
    name = name[0].split("-").join(" ");
    let flightNumber = flight[0];
    let [fromAirport, toAirport] = airports[0].split("/");
    company = company[0].replace("- ", "").replace("*", " ");
    result.textContent = `Mr/Ms, ${name}, your flight number ${flightNumber.trim()} is from ${fromAirport.trim()} to ${toAirport.trim()}. Have a nice flight with ${company.trim()}.`;
  }
}
