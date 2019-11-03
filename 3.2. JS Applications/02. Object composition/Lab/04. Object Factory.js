function solve(str) {
  const obj = {};
  JSON.parse(str).map(x => Object.assign(obj, x));
  return obj;
}
console.log(
  solve(`[{"canMove": true},{"canMove":true, "doors": 4},{"capacity": 5}]`)
);
