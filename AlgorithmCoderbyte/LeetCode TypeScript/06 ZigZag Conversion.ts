function convert(s: string, numRows: number): string {
  let answer: string = "";
  let arr: string[] = [];
  let i: number = 0;

  for(let i = 0; i < numRows; i++){
    arr.push("");
 }

  while (i < s.length) {
    for (let j = 0; i < s.length && j < numRows; j++) {
      arr[j] += s[i++];
    }
    for (let j = numRows - 2; i < s.length && j > 0; j--) {
      arr[j] += s[i++];
    }
  }
  arr.forEach((elememt) => {
    console.log(elememt);
    answer = answer + elememt;
  });
  return answer;
}

console.log("Expected PAHNAPLSIIGYIR");
console.log(convert("PAYPALISHIRING",3));
