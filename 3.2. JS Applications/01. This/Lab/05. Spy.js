function solve(target, method) {
  let original = target[method];
  let result = {
    count: 0
  };
  target[method] = function() {
    result.count++;
    return original.apply(this, arguments);
  };
  return result;
}
