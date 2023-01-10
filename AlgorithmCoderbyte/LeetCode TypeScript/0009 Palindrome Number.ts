function isPalindrome(x: number): boolean {

    let input: string = `${x}`;
    let inpuArr: string[] = input.split("");

    return JSON.stringify(inpuArr) == JSON.stringify(inpuArr.reverse());
}

console.log(isPalindrome(10));