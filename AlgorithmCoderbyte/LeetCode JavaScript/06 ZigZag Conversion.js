var convert = function(s, numRows) {
    //create an empty array
    let arr = [];
    //make the array to be of type string and make the leght to be or numRow
    for(let i = 0; i < numRows; i++){
        arr.push("");
    }
    let i = 0;
    while(i < s.length){
        for(let j = 0; i < s .length && j < numRows; j++){
            arr[j] += s[i++];
        }
        for(let j = numRows - 2; i < s.length && j > 0; j--){
            arr[j] += s[i++];
        }

    }

    let answer = "";
    arr.forEach(element => {
        console.log(element);
        answer += element;
    });
    
    return answer;
};
console.log("Expected PAHNAPLSIIGYIR");
console.log(convert("PAYPALISHIRING",3));